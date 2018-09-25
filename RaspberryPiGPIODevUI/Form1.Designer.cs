namespace RaspberryPiGPIODevUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pinInactiveList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pinActiveList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updatePinButton = new System.Windows.Forms.Button();
            this.selectedPinLabel = new System.Windows.Forms.Label();
            this.pinOffRadio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pinOnRadio = new System.Windows.Forms.RadioButton();
            this.pinPWMRadio = new System.Windows.Forms.RadioButton();
            this.pinNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raspberryPi3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dutyCycleSpinner = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dutyCycleSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(148, 29);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(17, 13);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(171, 26);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(106, 20);
            this.ipTextBox.TabIndex = 1;
            this.ipTextBox.Text = "192.168.1.202:8070";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pinInactiveList
            // 
            this.pinInactiveList.FormattingEnabled = true;
            this.pinInactiveList.Location = new System.Drawing.Point(13, 67);
            this.pinInactiveList.Name = "pinInactiveList";
            this.pinInactiveList.Size = new System.Drawing.Size(120, 251);
            this.pinInactiveList.TabIndex = 3;
            this.pinInactiveList.SelectedValueChanged += new System.EventHandler(this.ListPinValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inactive Pins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Active Pins";
            // 
            // pinActiveList
            // 
            this.pinActiveList.FormattingEnabled = true;
            this.pinActiveList.Location = new System.Drawing.Point(309, 67);
            this.pinActiveList.Name = "pinActiveList";
            this.pinActiveList.Size = new System.Drawing.Size(195, 251);
            this.pinActiveList.TabIndex = 7;
            this.pinActiveList.SelectedValueChanged += new System.EventHandler(this.ListPinValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selected Pin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PWM Duty Cycle";
            // 
            // updatePinButton
            // 
            this.updatePinButton.Location = new System.Drawing.Point(174, 295);
            this.updatePinButton.Name = "updatePinButton";
            this.updatePinButton.Size = new System.Drawing.Size(75, 23);
            this.updatePinButton.TabIndex = 13;
            this.updatePinButton.Text = "Update Pin";
            this.updatePinButton.UseVisualStyleBackColor = true;
            this.updatePinButton.Click += new System.EventHandler(this.updatePinButton_Click);
            // 
            // selectedPinLabel
            // 
            this.selectedPinLabel.Location = new System.Drawing.Point(139, 67);
            this.selectedPinLabel.Name = "selectedPinLabel";
            this.selectedPinLabel.Size = new System.Drawing.Size(149, 20);
            this.selectedPinLabel.TabIndex = 14;
            this.selectedPinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pinOffRadio
            // 
            this.pinOffRadio.AutoSize = true;
            this.pinOffRadio.Checked = true;
            this.pinOffRadio.Location = new System.Drawing.Point(179, 154);
            this.pinOffRadio.Name = "pinOffRadio";
            this.pinOffRadio.Size = new System.Drawing.Size(39, 17);
            this.pinOffRadio.TabIndex = 15;
            this.pinOffRadio.TabStop = true;
            this.pinOffRadio.Text = "Off";
            this.pinOffRadio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pin Output";
            // 
            // pinOnRadio
            // 
            this.pinOnRadio.AutoSize = true;
            this.pinOnRadio.Location = new System.Drawing.Point(179, 177);
            this.pinOnRadio.Name = "pinOnRadio";
            this.pinOnRadio.Size = new System.Drawing.Size(39, 17);
            this.pinOnRadio.TabIndex = 17;
            this.pinOnRadio.Text = "On";
            this.pinOnRadio.UseVisualStyleBackColor = true;
            // 
            // pinPWMRadio
            // 
            this.pinPWMRadio.AutoSize = true;
            this.pinPWMRadio.Location = new System.Drawing.Point(179, 200);
            this.pinPWMRadio.Name = "pinPWMRadio";
            this.pinPWMRadio.Size = new System.Drawing.Size(52, 17);
            this.pinPWMRadio.TabIndex = 18;
            this.pinPWMRadio.Text = "PWM";
            this.pinPWMRadio.UseVisualStyleBackColor = true;
            // 
            // pinNameTextBox
            // 
            this.pinNameTextBox.Location = new System.Drawing.Point(152, 113);
            this.pinNameTextBox.Name = "pinNameTextBox";
            this.pinNameTextBox.Size = new System.Drawing.Size(112, 20);
            this.pinNameTextBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Pin Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.AutoSize = false;
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.toolStripSeparator1});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.DropDownOpening += new System.EventHandler(this.connectionToolStripMenuItem_DropDownOpening);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(116, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinNumbersToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // pinNumbersToolStripMenuItem
            // 
            this.pinNumbersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.pinNumbersToolStripMenuItem.Name = "pinNumbersToolStripMenuItem";
            this.pinNumbersToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pinNumbersToolStripMenuItem.Text = "Pin Numbers";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "BCM",
            "WiringPi"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinLayoutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // pinLayoutToolStripMenuItem
            // 
            this.pinLayoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raspberryPi3ToolStripMenuItem});
            this.pinLayoutToolStripMenuItem.Name = "pinLayoutToolStripMenuItem";
            this.pinLayoutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pinLayoutToolStripMenuItem.Text = "PinLayout";
            this.pinLayoutToolStripMenuItem.Click += new System.EventHandler(this.pinLayoutToolStripMenuItem_Click);
            // 
            // raspberryPi3ToolStripMenuItem
            // 
            this.raspberryPi3ToolStripMenuItem.Name = "raspberryPi3ToolStripMenuItem";
            this.raspberryPi3ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.raspberryPi3ToolStripMenuItem.Text = "Raspberry Pi 3";
            this.raspberryPi3ToolStripMenuItem.Click += new System.EventHandler(this.raspberryPi3ToolStripMenuItem_Click);
            // 
            // dutyCycleSpinner
            // 
            this.dutyCycleSpinner.Location = new System.Drawing.Point(169, 244);
            this.dutyCycleSpinner.Name = "dutyCycleSpinner";
            this.dutyCycleSpinner.Size = new System.Drawing.Size(85, 20);
            this.dutyCycleSpinner.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 353);
            this.Controls.Add(this.dutyCycleSpinner);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pinNameTextBox);
            this.Controls.Add(this.pinPWMRadio);
            this.Controls.Add(this.pinOnRadio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pinOffRadio);
            this.Controls.Add(this.selectedPinLabel);
            this.Controls.Add(this.updatePinButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pinActiveList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pinInactiveList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.ipLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GPIO Remote Dev Tools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dutyCycleSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox pinInactiveList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox pinActiveList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updatePinButton;
        private System.Windows.Forms.Label selectedPinLabel;
        private System.Windows.Forms.RadioButton pinOffRadio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton pinOnRadio;
        private System.Windows.Forms.RadioButton pinPWMRadio;
        private System.Windows.Forms.TextBox pinNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raspberryPi3ToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown dutyCycleSpinner;
    }
}

