using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RaspberryPiGPIODevUI
{
    public partial class Form1 : Form
    {
        private List<GPIOPin> InactivePins = new List<GPIOPin>();
        private List<GPIOPin> ActivePins = new List<GPIOPin>();
        private GPIOPin SelectedPin = null;
        private PinoutForm pinoutForm = null;
        private ConnectionManager connectionManager = new ConnectionManager();

        private List<string> UsedIps = new List<string>()
        {
            "192.168.1.202:8070"
        };

        public Form1()
        {
            InitializeComponent();
            InstantiatePins();
        }

        private void InstantiatePins()
        {
            //Ids go down left side of the board, then down the right
            var bcms = new int[]
                {2, 3, 4, 17, 27, 22, 10, 9, 11, 0, 5, 6, 13, 19, 26, 14, 15, 18, 23, 24, 25, 8, 7, 1, 12, 16, 20, 21};
            var wiringPi = new int[]
                {8, 9, 7, 0, 2, 3, 12, 13, 14, 30, 21, 22, 23, 24, 25, 15, 16, 1, 4, 5, 6, 10, 11, 31, 26, 27, 28, 29};
            for (var i = 0; i < bcms.Length; i++)
            {
                InactivePins.Add(new GPIOPin(bcms[i], wiringPi[i]));
            }

            pinInactiveList.Items.AddRange(items: InactivePins.OrderBy(p => p.BCM).ToArray());
        }

        private void SelectPin(GPIOPin pin)
        {
            SelectedPin = pin;
            ClearLists();
            if (pin != null)
            {
                RefreshLists();
                selectedPinLabel.Text = pin.ToString();
                pinNameTextBox.Text = pin.Name ?? "";
                SetUIPinStatus(pin.PinStatus);
            }
        }

        private void ClearLists()
        {
            if (!pinInactiveList.Items.Contains(SelectedPin))
                pinInactiveList.ClearSelected();
            if (!pinActiveList.Items.Contains(SelectedPin))
                pinActiveList.ClearSelected();
        }

        private void RefreshLists()
        {
            var list = new[] {pinInactiveList, pinActiveList};
            foreach (var listBox in list)
            {
                var count = listBox.Items.Count;
                listBox.SuspendLayout();
                for (var i = 0; i < count; i++)
                {
                    listBox.Items[i] = listBox.Items[i];
                }

                listBox.ResumeLayout();
                if (SelectedPin != null && listBox.Items.Contains(SelectedPin))
                    listBox.SelectedItem = SelectedPin;
            }
        }

        private void ListPinValueChanged(object sender, EventArgs e)
        {
            if (sender is ListBox listbox)
            {
                if (listbox.SelectedItem != SelectedPin && listbox.SelectedItem != null)
                    SelectPin(listbox.SelectedItem as GPIOPin);
            }

            if (((ListBox) sender).SelectedItem == SelectedPin)
                return;

            //Console.WriteLine(JsonConvert.SerializeObject(sender));
        }

        private void updatePinButton_Click(object sender, EventArgs e)
        {
            if (SelectedPin == null) return;

            var newStatus = GetUpdatePinStatus();
            SelectedPin.Name = pinNameTextBox.Text;

            //Is it off and we're just updating name?
            if (newStatus == GPIOPinStatus.Off && SelectedPin.PinStatus == GPIOPinStatus.Off)
            {
                SelectPin(SelectedPin);
                return;
            }

            SelectedPin.PinStatus = newStatus;
            if (newStatus == GPIOPinStatus.PWM)
                SelectedPin.PWMDutyCycle = (int) dutyCycleSpinner.Value;

            MovePinList(SelectedPin, newStatus);

            SelectPin(SelectedPin);

            SendPinData(SelectedPin);
        }

        private void SendPinData(GPIOPin selectedPin)
        {
            var sb = new StringBuilder();

            sb.Append("setpin," + selectedPin.WiringPi + ",");
            sb.Append(selectedPin.PinStatus);
            if (selectedPin.PinStatus == GPIOPinStatus.PWM)
                sb.Append("," + selectedPin.PWMDutyCycle);
            if (connectionManager.IsConnected())
                connectionManager.WriteToStream(sb.ToString());
        }

        private void MovePinList(GPIOPin selectedPin, GPIOPinStatus newStatus)
        {
            if (newStatus == GPIOPinStatus.Off && ActivePins.Contains(selectedPin))
            {
                ActivePins.Remove(selectedPin);
                pinActiveList.Items.Remove(selectedPin);
                InactivePins.Add(selectedPin);
                pinInactiveList.Items.Add(selectedPin);
            }
            else if (newStatus != GPIOPinStatus.Off && InactivePins.Contains(selectedPin))
            {
                InactivePins.Remove(selectedPin);
                pinInactiveList.Items.Remove(selectedPin);
                ActivePins.Add(selectedPin);
                pinActiveList.Items.Add(selectedPin);
            }
        }

        private GPIOPinStatus GetUpdatePinStatus()
        {
            if (pinOffRadio.Checked)
                return GPIOPinStatus.Off;
            if (pinOnRadio.Checked)
                return GPIOPinStatus.On;
            if (pinPWMRadio.Checked)
                return GPIOPinStatus.PWM;
            throw new Exception($"No radio buttons checked?!?!");
        }

        private void SetUIPinStatus(GPIOPinStatus status)
        {
            var buttons = new[] {pinOffRadio, pinOnRadio, pinPWMRadio};
            RadioButton toSelect = null;
            switch (status)
            {
                case GPIOPinStatus.Off:
                    toSelect = pinOffRadio;
                    break;
                case GPIOPinStatus.On:
                    toSelect = pinOnRadio;
                    break;
                case GPIOPinStatus.PWM:
                    toSelect = pinPWMRadio;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }

            foreach (var radioButton in buttons)
            {
                radioButton.Checked = radioButton == toSelect;
            }
        }


        private void connectionToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            while (connectionToolStripMenuItem.DropDownItems.Count != 2)
                connectionToolStripMenuItem.DropDownItems.RemoveAt(connectionToolStripMenuItem.DropDownItems.Count - 1);
            foreach (var usedIp in UsedIps)
            {
                var item = new ToolStripButton(usedIp) {AutoSize = true};
                item.Click += IpClicked;
                connectionToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        private void IpClicked(object sender, EventArgs e)
        {
            var item = sender as ToolStripButton;
            if (item != null)
            {
                Connect(item.Text);
            }
        }

        private void Connect(string itemValue)
        {
            MessageBox.Show(itemValue);
            throw new NotImplementedException();
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            switch ((string) toolStripComboBox1.SelectedItem)
            {
                case "BCM":
                    Config.IsBCM = true;
                    break;
                case "WiringPi":
                    Config.IsBCM = false;
                    break;
                default:
                    throw new Exception($"Unknown item {toolStripComboBox1.SelectedText}");
            }

            RefreshLists();
        }

        private void pinLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void raspberryPi3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pinoutForm == null)
            {
                pinoutForm = new PinoutForm();
                pinoutForm.Show();
            }

            pinoutForm.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ip = ipTextBox.Text;
            connectionManager.Connect(ip);
            button1.Text = "Disconnect";
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
    }
}