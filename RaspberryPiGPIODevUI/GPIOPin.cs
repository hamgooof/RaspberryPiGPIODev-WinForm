using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaspberryPiGPIODevUI
{
    class GPIOPin
    {
        public int BCM { get; private set; }
        public int WiringPi { get; private set; }
        public GPIOPinStatus PinStatus { get; set; }
        public int PWMDutyCycle = -1;
        public string Name { get; set; }

        public GPIOPin(int bcm, int wiringPi)
        {
            BCM = bcm;
            WiringPi = wiringPi;
            PinStatus = GPIOPinStatus.Off;
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Config.IsBCM ? $"[{BCM}] " : $"[{WiringPi}] ");
            if (!string.IsNullOrWhiteSpace(Name))
                sb.Append($"{Name} ");
            switch (PinStatus)
            {
                case GPIOPinStatus.Off:
                    break;
                case GPIOPinStatus.On:
                    sb.Append(" - On");
                    break;
                case GPIOPinStatus.PWM:
                    sb.Append($" - PWM {PWMDutyCycle}");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return sb.ToString();
        }
    }

    enum GPIOPinStatus
    {
        Off,
        On,
        PWM
    }
}