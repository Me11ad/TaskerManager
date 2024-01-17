using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TaskerManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void GetAllProcess()
        {
            listBox1.Items.Clear();
            foreach (var item in Process.GetProcesses())
            {
                listBox1.Items.Add(item.ProcessName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            processes[listBox1.SelectedIndex].Kill();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAllProcess();
        }
    }
}
