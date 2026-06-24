using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Discussion
{
    public class SmartLight : SmartDevice
    {
        private int _brightnessLevel;

        public SmartLight(string deviceId, string deviceName, int brightnessLevel) : base(deviceId, deviceName)
        {
            _brightnessLevel = brightnessLevel;
        }

        public int BrightnessLevel
        {
            get { return _brightnessLevel; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Brightness level must be between 0 and 100.");
                }
                _brightnessLevel = value;
            }
        }

        public override void executePrimaryFunction()
        {
            if(Status)
            {
                Console.WriteLine($"The {_deviceName} light is ON with brightness level: {_brightnessLevel}%");
            }
            else
            {
                Console.WriteLine($"The {_deviceName} light is OFF.");
            }
        }
    }
}
