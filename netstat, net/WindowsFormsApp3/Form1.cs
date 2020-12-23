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

namespace WindowsFormsApp3
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
                Arguments = "/c cd/ & cd WINDOWS & cd system32 &  chcp 65001 & netstat -a ",
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
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & " + textBox1.Text,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "cd/ & cd WINDOWS & cd system32 & chcp 65001 & netstat -b ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "cd/ & cd WINDOWS & cd system32 & chcp 65001 & netstat -e ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "cd/ & cd WINDOWS & cd system32 & chcp 65001 & netstat -e -s ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "c/ cd/ & cd WINDOWS & cd system32 & chcp 65001 & netstat -f ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "c/ cd/ & cd WINDOWS & cd system32 & chcp 65001 & netstat -n ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & netstat -o ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & -p " +  textBox3.Text,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & netstat -q ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & netstat -r ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & netstat -s ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & netstat -t ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & netstat -x ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & netstat -y ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox2.Text = process.StandardOutput.ReadToEnd();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c chcp 65001 & net  ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net ACCOUNTS ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net COMPUTER ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net CONFIG ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net CONTINUE ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net GROUP ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net  FILE ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net  HELP ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net  HELPMSG ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net  LOCALGROUP ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net  PAUSE ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net  SESSION ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net  SHARE ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net  START ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net  STATISTICS ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net  STOP ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net   TIME ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net   USE ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net   USER ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cd/ & cd WINDOWS & cd system32 & chcp 65001 & net   VIEW ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden

            });

            textBox5.Text = process.StandardOutput.ReadToEnd();
        }
    }
}
