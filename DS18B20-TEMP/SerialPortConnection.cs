using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    static class SerialPortConnection
    {
        public static SerialPort serial_port;
        public static bool Connect(string port, int baud_rate)
        {
            try
            {
                serial_port = new SerialPort(port, baud_rate);
                serial_port.Open();
            }
            catch(IOException)
            {
                 MessageBox.Show("Your arduino is not connected in this Port");
                 return false;
            }   
            return true;      
        }
        
  


    }
}
