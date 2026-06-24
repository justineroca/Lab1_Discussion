using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Discussion
{
    public abstract class SmartDevice
    {
        private string _deviceId;
        private bool _status;
        private protected string _deviceName;

        public SmartDevice(string deviceId, string deviceName)
        {
            _deviceId = deviceId;
            _deviceName = deviceName;
            _status = false; // Default status is OFF
        }

        public string DeviceId
        {
            get {  return _deviceId; }
            set { _deviceId = value; }
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string DeviceName
        {
            get { return _deviceName; }
            set { _deviceName = value; }
        }

        public abstract void executePrimaryFunction();

        public void togglePower()
        {
            _status = !_status;
            Console.WriteLine($"Device {_deviceName} is now {(_status ? "ON" : "OFF")}");
            // if (_status)
            // {
            //Console.WriteLine("ON");
            // }
            // else
            // {
            //     Console.WriteLine("OFF");
            //
        }
    }
}
