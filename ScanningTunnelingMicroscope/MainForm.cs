using NationalInstruments.DAQmx;
using System;
using System.Windows.Forms;

namespace ScanningTunnelingMicroscope {
    public partial class MainForm: Form {
        public MainForm() {
            InitializeComponent();
        }

        private void refreshDevicesButtonClick(object sender, EventArgs e) {
            string[] deviceNames = DaqSystem.Local.Devices;
            devices.Items.Clear();
            foreach (string deviceName in deviceNames) {
                devices.Items.Add(deviceName);
            }
            devices.Text = (string)devices.Items[0];
        }

        private void testButtonClick(object sender, EventArgs e) {
            using (Task task = new Task()) {
                task.AIChannels.CreateVoltageChannel(devices.Text + "/AI0", "",
                    (AITerminalConfiguration)(-1), minValueSlider.Value, maxValueSlider.Value,
                    AIVoltageUnits.Volts);

                AnalogMultiChannelReader reader = new AnalogMultiChannelReader(task.Stream);

                task.Control(TaskAction.Verify);

                double[,] data = reader.ReadMultiSample(10);
                string result = "";
                foreach (double value in data) {
                    result += value + "\n";
                }
                output.Text = result;
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }
    }
}