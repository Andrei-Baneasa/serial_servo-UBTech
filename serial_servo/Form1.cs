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
        static byte[] servoAngle = new byte[3]; //array servo angle
        static byte[] servoID = new byte[3]; //array servo ID
        static byte[] servoTime = new byte[3]; //array time is MAX time
        static UInt32[] checkSum = new UInt32[3]; //array checksum
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
            servoAngle[0] = (byte) (trackBar1.Value); //get byte
            textBox1.Text = (trackBar1.Value * 360 / 240).ToString(); //display
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            servoTime[0] = (byte) trackBar2.Value; //get byte
            textBox2.Text = (trackBar2.Value * 20).ToString(); //display
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            servoID[0] = (byte) numericUpDown1.Value; //get byte
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
            byte noMotors = 1; //number of motors by default is one 

            label = ""; //clear label buffer string

            if (checkBox1.Checked == true)
            {
                noMotors = 3; //if using 3 motors
            }

            for (byte j = 0; j < noMotors; j++) //for every motor in use
            {
                checkSum[j] = 1; //reset checksum
                byte[] buffer = new byte[10]; //serial buffer
                buffer[0] = 0xFA; //header MSByte
                buffer[1] = 0xAF; //header LSByte
                buffer[2] = servoID[j]; //servo ID
                buffer[3] = 0x01; //command move to angle
                buffer[4] = servoAngle[j]; //servo angle
                buffer[5] = servoTime[0]; //time of motion
                if (checkBox2.Checked == true)
                {
                    buffer[5] = servoTime[j]; //time of motion
                }
                
                buffer[6] = 0x00; //dunno MSByte
                buffer[7] = 0x01; //dunno LSByte
                for (int i = 2; i < 7; i++)
                {
                    checkSum[j] += buffer[i];
                }
                checkSum[j] %= 255;
                buffer[8] = (byte)checkSum[j];
                buffer[9] = 0xED;
        
                sp.Write(buffer, 0, 10);

                for (int i = 0; i < 10; i++)
                {
                    label += buffer[i].ToString("X") + " ";
                }
                label += "\n\r"; //add new line and carriage return to string
                label5.Text = label; //display buffer
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*Int32 value =Int32.Parse(textBox1.Text); //read number from text box
            trackBar1.Value = value * 255 / 360; //send value from textbox to trackbar*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            trackBar4.Enabled = true;
            trackBar6.Enabled = true;
            textBox4.Enabled = true;
            textBox6.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            trackBar3.Enabled = true;
            trackBar5.Enabled = true;
            textBox3.Enabled = true;
            textBox5.Enabled = true;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            servoAngle[1] = (byte)trackBar4.Value; //get byte
            textBox4.Text = (trackBar4.Value * 360 / 240).ToString(); //display
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            /*Int32 value = Int32.Parse(textBox4.Text); //read number from text box
            trackBar4.Value = value * 255 / 360; //send value from textbox to trackbar*/
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            servoID[1] = (byte)numericUpDown2.Value; //get byte
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            servoAngle[2] = (byte)trackBar6.Value; //get byte
            textBox6.Text = (trackBar6.Value * 360 / 240).ToString(); //display
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            /*Int32 value = Int32.Parse(textBox6.Text); //read number from text box
            trackBar6.Value = value * 255 / 360; //send value from textbox to trackbar*/
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            servoID[2] = (byte)numericUpDown3.Value; //get byte
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            servoTime[1] = (byte)trackBar3.Value; //get byte
            textBox3.Text = (trackBar3.Value * 20).ToString(); //display
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            
            servoTime[2] = (byte)trackBar5.Value; //get byte
            textBox5.Text = (trackBar5.Value * 20).ToString(); //display
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox4.Enabled = true;
                trackBar4.Enabled = true;
                numericUpDown2.Enabled = true;
                textBox6.Enabled = true;
                trackBar6.Enabled = true;
                numericUpDown3.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
                trackBar4.Enabled = false;
                numericUpDown2.Enabled = false;
                textBox6.Enabled = false;
                trackBar6.Enabled = false;
                numericUpDown3.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.Enabled = true;
                trackBar3.Enabled = true;
                
                textBox5.Enabled = true;
                trackBar5.Enabled = true;
             
            }
            else
            {
                textBox3.Enabled = false;
                trackBar3.Enabled = false;
               
                textBox5.Enabled = false;
                trackBar5.Enabled = false;
            
            }
        }
    }
}
