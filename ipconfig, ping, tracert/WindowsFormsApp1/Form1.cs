using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & " + textBox1.Text,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001  & " + textBox3.Text,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });
            textBox7.Text = process.StandardOutput.ReadToEnd();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001  & tracert -d " + textBox20.Text + " " + textBox21.Text + " " + textBox22.Text + " " + textBox23.Text + " "
                + textBox24.Text + " " + textBox25.Text,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            //process.BeginOutputReadLine();
            //process.OutputDataReceived += (s, a) => { textBox4.Text = a.Data; };
            textBox4.Text = process.StandardOutput.ReadToEnd();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) // ipconfig ручной ввод
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & " + textBox5.Text,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox6.Text = process.StandardOutput.ReadToEnd();
        }

        private void button5_Click(object sender, EventArgs e) //ipconfig /all
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & ipconfig /all" ,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox6.Text = process.StandardOutput.ReadToEnd();
        }

        private void button6_Click(object sender, EventArgs e) //ipconfig /renew
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & ipconfig /renew",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox6.Text = process.StandardOutput.ReadToEnd();
        }

        private void label11_Click(object sender, EventArgs e) 
        {
           
        }

        private void button9_Click(object sender, EventArgs e) //  /flushdns
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 &  ipconfig /flushdns",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox6.Text = process.StandardOutput.ReadToEnd();
        }

        private void button8_Click(object sender, EventArgs e) //release
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 &  ipconfig /release",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox6.Text = process.StandardOutput.ReadToEnd();
        }

        private void button10_Click(object sender, EventArgs e) // ipconfig /showclassid
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 &  ipconfig /showclassid",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox6.Text = process.StandardOutput.ReadToEnd();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & ipconfig /?",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox6.Text = process.StandardOutput.ReadToEnd();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e) // проверка связи с указанным узлом
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 &  ping -t" + textBox8.Text,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox7.Text = process.StandardOutput.ReadToEnd();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 &  ping " + textBox8.Text + " "+ textBox9.Text + " " + textBox10.Text + " " + textBox11.Text + " "
                + textBox12.Text + " " + textBox13.Text + " " + textBox14.Text + " " + textBox15.Text + " " + textBox16.Text
                + " " + textBox17.Text + " " + textBox18.Text + " " + textBox19.Text,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox7.Text = process.StandardOutput.ReadToEnd();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 &  ping -a " + textBox8.Text + " " + textBox9.Text + " " + textBox10.Text + " " + textBox11.Text + " "
                + textBox12.Text + " " + textBox13.Text + " " + textBox14.Text + " " + textBox15.Text + " " + textBox16.Text
                + " " + textBox17.Text + " " + textBox18.Text + " " + textBox19.Text,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox7.Text = process.StandardOutput.ReadToEnd();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 &  tracert " + textBox20.Text + " " + textBox21.Text + " " + textBox22.Text + " " + textBox23.Text + " "
                + textBox24.Text + " " + textBox25.Text,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox4.Text = process.StandardOutput.ReadToEnd();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 &  ping /?" + textBox8.Text + " " + textBox9.Text + " " + textBox10.Text + " " + textBox11.Text + " "
                + textBox12.Text + " " + textBox13.Text + " " + textBox14.Text + " " + textBox15.Text + " " + textBox16.Text
                + " " + textBox17.Text + " " + textBox18.Text + " " + textBox19.Text,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox7.Text = process.StandardOutput.ReadToEnd();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 &  tracert " + textBox20.Text + " " + textBox21.Text + " " + textBox22.Text + " " + textBox23.Text + " "
                 + textBox24.Text + " " + textBox25.Text,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox4.Text = process.StandardOutput.ReadToEnd();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
