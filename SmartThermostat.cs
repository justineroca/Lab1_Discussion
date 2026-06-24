using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Discussion
{
    public class SmartThermostat : SmartDevice
    {
        private double _temperatureSetting;

        public SmartThermostat(string deviceId, string deviceName, double temperatureSetting) : base(deviceId, deviceName)
        {
            _temperatureSetting = temperatureSetting;
        }

        public double TemperatureSetting
        {
            get { return _temperatureSetting; }
            set
            {
                if (value < 16 || value > 30)
                {
                    throw new ArgumentOutOfRangeException("Temperature setting must be between 16 and 30 degrees Celsius.");
                }
                _temperatureSetting = value;
            }
        }

        public override void executePrimaryFunction()
        {
            if(Status)
            {
                Console.WriteLine($"The {_deviceName} thermostat is ON with temperature setting: {_temperatureSetting}°C");
            }
            else
            {
                Console.WriteLine($"The {_deviceName} thermostat is OFF.");
            }
        }
    }
}
