using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using GMap.NET.MapProviders;
using GMap.NET;

namespace CanSat
{
    public partial class Form1 : Form
    {
        int mov, movX, movY;
        bool connected = false, test_mode = false;
        Label[] telemetry_array;
        Thread th;
        private string selected_port = null;
        //string test = "2548,4,5,-2.58,1013.56,29.11,11.44,12:58:35,40.8082,29.3565,0.00,0.00,2.277,-5.19,-1.10,Active,0.04";

        private SerialPort port = new SerialPort("COM5", 9600);

        public Form1()
        {
            InitializeComponent();
            telemetry_array = new Label[] {labelTeamID,labelMissionTime,labelPacketCount,labelAltitude,labelPressure,
            labelTemperature,labelVoltage,labelGPSTime,labelGPSLatitude,labelGPSLongitude,labelGPSAltitude,labelGPSSats,
            labelPitch,labelRoll,labelBladeSpinRate,labelSoftwareState,labelCurrentSpeed};
            string[] com_ports = SerialPort.GetPortNames();
            comboBoxComPort.Items.Clear();
            foreach (string port_name in com_ports)
            {
                comboBoxComPort.Items.Add(port_name);
            }
            this.Icon = Icon.ExtractAssociatedIcon("./../../cansatLogo.ico");
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            backgroundWorker1.RunWorkerAsync();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if(connected)
            {
                MessageBox.Show("You must be disconnected from XBEE!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                MessageBox.Show("You must be connected to XBEE!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            th = new Thread(printTelemetry);
            th.Start();
        }

        private void printTelemetry()
        {
            string[] telemetry_list;
            string[] telemetry_header = new string[] { "Time", "TeamID", "Mission Time", "Packet Count", "Altitude", "Pressure",
            "Temperature", "Voltage", "GPS Time", "GPS Latitude", "GPS Longitude", "GPS Altitude", "GPS Sats",
            "Pitch", "Roll", "Blade Spin Rate", "Software State", "Speed"};

            string excel_column = String.Join(";",telemetry_header) + ";\n";
            string excel_row = null;

            string old_readline = null;

            string filePath = @"FLIGHT_2548.csv";
            File.AppendAllText(filePath, excel_column);

            while (true)
            {
                //if (!String.IsNullOrEmpty(port.ReadLine()) && !String.Equals(old_readline, port.ReadLine())) {
                    if (port.ReadLine().Length < 25) continue;
                    old_readline = port.ReadLine();
                    telemetry_list = port.ReadLine().Split(',');

                    //telemetry_list = test.Split(',');
                    excel_row = null;
                    excel_row = String.Format("=(\"{0}\");=(\"{1}", DateTime.Now.ToString("HH:mm:ss"), String.Join("\");=(\"", telemetry_list));
                    excel_row = excel_row.Remove(excel_row.Length - 1);
                    excel_row += "\");\n";
                    File.AppendAllText(filePath, excel_row);

                    for (int i = 0; i < telemetry_array.Length; i++)
                    {
                        if (old_readline.Length < 25) break;
                        Invoke(new Action(() => {
                            telemetry_array[i].Text = telemetry_list[i];
                            if (telemetry_array[i] == labelAltitude)
                                telemetry_array[i].Text += " m";
                            if (telemetry_array[i] == labelPressure)
                                telemetry_array[i].Text += " P";
                            if (telemetry_array[i] == labelTemperature)
                                telemetry_array[i].Text += " C";
                            if (telemetry_array[i] == labelVoltage)
                                telemetry_array[i].Text += " V";
                            if (telemetry_array[i] == labelBladeSpinRate)
                                telemetry_array[i].Text += " rpm";
                            if (telemetry_array[i] == labelGPSAltitude)
                                telemetry_array[i].Text += " m";
                            if (telemetry_array[i] == labelCurrentSpeed)
                                telemetry_array[i].Text += "m/s";
                            if(telemetry_array[i] == labelSoftwareState)
                            {
                                if (telemetry_array[i].Text == "Active")
                                    telemetry_array[i].ForeColor = System.Drawing.Color.Green;
                                else
                                    telemetry_array[i].ForeColor = System.Drawing.Color.Red;
                            }
                            gMapControl1.Position = new PointLatLng(Convert.ToDouble(labelGPSLatitude.Text.Replace('.',',')), Convert.ToDouble(labelGPSLongitude.Text.Replace('.',',')));
                            gMapControl1.Zoom = 15;
                        }));
                    //}
                }
                Thread.Sleep(1000);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                MessageBox.Show("You must be connected to XBEE!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(th.IsAlive) th.Abort();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                MessageBox.Show("You are already connected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(selected_port))
            {
                MessageBox.Show("You must select a port!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connected = true;
            port.PortName = selected_port;
            try
            {
                port.Open();
            }
            catch(Exception _e)
            {
                MessageBox.Show("Error in port opening!\n\n"+_e, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                MessageBox.Show("You are already disconnected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (th.IsAlive) th.Abort();

            connected = false;
            port.Close();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                MessageBox.Show("You must be connected to XBEE!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Label _label in telemetry_array)
            {
                _label.Text = "0";
            }

            labelCurrentStage.Text = "N/A";
            labelSignalRate.Text = "N/A";
            labelSignalRate.ForeColor = System.Drawing.Color.FromArgb(199, 219, 244);

            port.WriteLine("z");
        }

        private void ComboBoxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_port = comboBoxComPort.Text;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int batterystatus;
            PowerStatus pwr;

            while(true)
            {
                pwr = SystemInformation.PowerStatus;
                batterystatus = (int)(pwr.BatteryLifePercent * 100);

                Invoke(new Action(() =>
                {
                    labelCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
                    labelBatteryStatus.Text = "% "+batterystatus.ToString();
                    if (batterystatus >= 70)
                        labelBatteryStatus.ForeColor = System.Drawing.Color.Green;
                    if (20 <= batterystatus && batterystatus < 70)
                        labelBatteryStatus.ForeColor = System.Drawing.Color.Yellow;
                    if (batterystatus < 20)
                        labelBatteryStatus.ForeColor = System.Drawing.Color.Red;
                }));

                Thread.Sleep(1000);
            }
        }

        private void ButtonTestMode_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                MessageBox.Show("You must be connected to XBEE!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (test_mode)
            {
                buttonTestMode.Text = "Test Mode OFF";
                buttonTestMode.ForeColor = System.Drawing.Color.FromArgb(80, 0, 0);
                test_mode = false;
            }
            else
            {
                buttonTestMode.Text = "Test Mode ON";
                buttonTestMode.ForeColor = System.Drawing.Color.FromArgb(0, 80, 0);
                test_mode = true;
            }

            port.WriteLine("x");
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
