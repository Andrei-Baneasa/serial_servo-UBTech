using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;


namespace serial_servo
{
    
    public partial class Form1 : Form
    {
        static byte servoAngle = 0; //init servo angle
        static byte servoID = 0; //init servo ID
        static byte servoTime = 0xFF; //init time is MAX time
        static UInt32 checkSum = 0; //init checksum
        static string port; //serial port
        SerialPort sp = new SerialPort(); //serial port
        string label = ""; //serial buffer visualiser 

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            servoAngle = (byte) (trackBar1.Value); //get byte
            textBox1.Text = (trackBar1.Value * 360 / 240).ToString(); //display
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            servoTime = (byte) trackBar2.Value; //get byte
            textBox2.Text = (trackBar2.Value * 20).ToString(); //display
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            servoID = (byte) numericUpDown1.Value; //get byte
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            port = comboBox1.Text; //get com port name;         
        }

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sp.BaudRate = 115200;
                sp.Parity = Parity.None;
                sp.StopBits = StopBits.One;
                sp.DataBits = 8;
                sp.PortName = port; //port name
                sp.Handshake = 0; // no handshake
                sp.Open();
            }
            catch
            {
                Console.WriteLine("pizda ma-si");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sp.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkSum = 1; //reset checksum
            byte[] buffer = new byte[10]; //serial buffer
            buffer[0] = 0xFA; //header MSByte
            buffer[1] = 0xAF; //header LSByte
            buffer[2] = servoID; //servo ID
            buffer[3] = 0x01; //command move to angle
            buffer[4] = servoAngle; //servo angle
            buffer[5] = servoTime; //time of motion
            buffer[6] = 0x00; //dunno MSByte
            buffer[7] = 0x01; //dunno LSByte
            for (int i=2; i<7; i++)
            {
                checkSum += buffer[i];
            }
            checkSum %= 255;
            buffer[8] = (byte) checkSum;
            buffer[9] = 0xED;
            label = ""; //clear label buffer string
            sp.Write(buffer, 0, 10);
            for (int i = 0; i < 10; i++)
            {
               label += buffer[i].ToString("X") + " ";
            }
            label5.Text = label; //display buffer
        }

    }
}
