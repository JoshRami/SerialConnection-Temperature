using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Globalization;

namespace GUI_MODERNISTA
{
    public partial class MainUI : Form
    {       
        private Timer timer;     
        public MainUI()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Enabled = true;
            SerialPortConnection.serial_port.DataReceived += SerialPort_DataReceived;
            timer.Tick += new EventHandler(TimerEvent);
        }

        private void BtnCerrar_Click(object sender, EventArgs e) => Application.Exit();
        private void BtnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private delegate void LineReceivedEvent(string POT);
        private void LineReceived(string serial_data)
        {
            double temperature;
            double.TryParse(serial_data, out temperature);

            CENT.Text = $"°C: {serial_data}";
            FAHR.Text = $"°F: {Math.Round(temperature * 9 / 5 + 32, 2)}";
            KELV.Text = $"K:  {temperature + 273.15}";
            JOSU.Text = $"°J: {Math.Round(temperature * 1.8 - 10, 2)}";
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string serial_data = SerialPortConnection.serial_port.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), serial_data);
        }

        private void TimerEvent(object te, EventArgs e)
        {
            DateTime time = DateTime.Now;
            Timer.Text = time.ToString("hh:mm:ss tt");
        }


    }
}
