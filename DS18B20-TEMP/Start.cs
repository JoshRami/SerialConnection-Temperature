using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace GUI_MODERNISTA
{
    public partial class Start : Form
    {
        Thread thread;
        public Start()
        {
            InitializeComponent();
        }
        private void BtnCerrar_1_Click(object sender, EventArgs e) => Application.Exit();
        private void BtnMinimizar_1_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void Start_Load(object sender, EventArgs e)
        {
            available_ports.Items.AddRange(SerialPort.GetPortNames()); 
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            int baud_rate;
            string port;
            try
            {
               baud_rate =  int.Parse(textBox1.Text);
               port = available_ports.SelectedItem.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("The baud rate is in invalid input or you haven't select a port...");
                return;
            }


            if(SerialPortConnection.Connect(port, baud_rate))
            {
                conexion_correctanoti.ShowBalloonTip(3000);
                this.Close();
                thread = new Thread(OpenMainForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            } 
        }
        private void OpenMainForm(object obj)
        {
            Application.Run(new MainUI());
        }


    }
}
