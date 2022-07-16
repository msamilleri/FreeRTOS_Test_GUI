using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace RTOSGUI
{
   
    public partial class Form1 : Form
    {
        string[] ports = SerialPort.GetPortNames();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string port in ports)
            {
                cmbox_com.Items.Add(port);

            }
            btn_close.Enabled = false;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            btn_open.Enabled = false;
            btn_close.Enabled = true;

            try
            {
                
                serialPort1.PortName = cmbox_com.Text;
                serialPort1.BaudRate = Convert.ToInt32(cmbox_baud.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
                port_durum.Text = "Port'a bağlandı";
                port_durum.ForeColor = Color.Green;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            btn_close.Enabled = false;
            btn_open.Enabled = true;
     
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                port_durum.Text = "Port Kapandı";
                port_durum.ForeColor = Color.Red;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            listBox_Recv.Items.Clear();
        }

        private void cmbox_gerek_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbox_gerek.Text == "001_Tasks_Scheduling")
            {
                cmbox_testyon.Items.Clear();
                cmbox_testyon.Items.Add("Round Robin");
                cmbox_testyon.Items.Add("Co Operative");
            }

            if (cmbox_gerek.Text == "002_LedTasks")
            {
                cmbox_testyon.Items.Clear();
                cmbox_testyon.Items.Add("Ledes lighting");

            }

            if (cmbox_gerek.Text == "003(6)_Led_Btn_ISR")
            {
                cmbox_testyon.Items.Clear();
                cmbox_testyon.Items.Add("Led button ISR");

            }

            if (cmbox_gerek.Text == "004()_Change_Task_Priority")
            {
                cmbox_testyon.Items.Clear();
                cmbox_testyon.Items.Add("Set the prioty");

            }
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                if (cmbox_testyon.SelectedItem == "Round Robin")
                {
                    serialPort1.WriteLine("R");
                }

                if (cmbox_testyon.SelectedItem == "Co Operative")
                {
                    serialPort1.WriteLine("C");
                }

                if (cmbox_testyon.SelectedItem == "Ledes lighting")
                {
                    serialPort1.WriteLine("L");
                }
                if (cmbox_testyon.SelectedItem == "Led button ISR")
                {
                    serialPort1.WriteLine("S");
                }

                if (cmbox_testyon.SelectedItem == "Set the prioty")
                {
                    int task1, task2, task3, task4;
                    task1 = Int32.Parse(txt_box_task1.Text);

                    task2 = Int32.Parse(txt_box_task2.Text);

                    task3 = Int32.Parse(txt_box_task3.Text);

                    task4 = Int32.Parse(txt_box_task4.Text);

                    //String bigData = task1+"T1"+task2 + "T2" + task3 + "T3" + task4 + "T4";

                    serialPort1.WriteLine(task1 + "T1" + task2 + "T2" + task3 + "T3" + task4 + "T4" + "\n");



                }

            }
            else
            {
                MessageBox.Show("Port close");
            }
        }
    }
}
