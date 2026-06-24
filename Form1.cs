namespace Lab1_Discussion
{
    public partial class Form1 : Form
    {
        private readonly SmartDevice[] _devices = new SmartDevice[3];
        public Form1()
        {
            _devices[0] = new SmartLight("SL1", "Living Room Light", 50);
            _devices[1] = new SmartThermostat("ST1", "Bedroom Thermostat", 22.0);
            _devices[2] = new SmartLight("SL2", "Kitchen Light", 75);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            labelSL1.Text = _devices[0].DeviceName;
            labelST1.Text = _devices[1].DeviceName;
            labelSL2.Text = _devices[2].DeviceName;

            updateDeviceStatus();

        }

        void updateDeviceStatus()
        {
            if (_devices[0].Status)
            {
                progressBarSL1.Value = ((SmartLight)_devices[0]).BrightnessLevel;
            }
            else
            {
                progressBarSL1.Value = 0;
            }

            if (_devices[1].Status)
            {
                progressBarST1.Value = (int)((SmartThermostat)_devices[1]).TemperatureSetting;
            }
            else
            {
                progressBarST1.Value = 16;
            }

            if (_devices[2].Status)
            {
                progressBarSL2.Value = ((SmartLight)_devices[2]).BrightnessLevel;
            }
            else
            {
                progressBarSL2.Value = 0;
            }


            buttonSL1.Text = _devices[0].Status ? "Turn Off" : "Turn On";
            buttonST1.Text = _devices[1].Status ? "Turn Off" : "Turn On";
            buttonSL2.Text = _devices[2].Status ? "Turn Off" : "Turn On";
        }

        private void buttonSL1_Click(object sender, EventArgs e)
        {
            _devices[0].Status = !_devices[0].Status;
            updateDeviceStatus();
        }

        private void buttonST1_Click(object sender, EventArgs e)
        {
            _devices[1].Status = !_devices[1].Status;
            updateDeviceStatus();
        }

        private void buttonSL2_Click(object sender, EventArgs e)
        {
            _devices[2].Status = !_devices[2].Status;
            updateDeviceStatus();
        }
    }
}
