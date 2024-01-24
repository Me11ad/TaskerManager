using System;
using System.Diagnostics;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace TaskerManager
{
     
    public partial class Main : Form
    {
        /// \brief Основной класс, отвечающий за запуск программы.
        public Main()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        {
            
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
            var timer = new Timer() { Interval = 1000 };
            timer.Tick += (o, args) =>
            {
                var processInfo = Process.GetProcesses();
                var results = processInfo.Select(p => (object)string.Format("Name: {0}; ID: {1}", p.ProcessName, p.Id)).ToArray();
                Invoke(new Action(() =>
                {
                    var index = listBox1.TopIndex;
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(results);
                    listBox1.TopIndex = Math.Min(index, listBox1.Items.Count - 1);
                }));
            };
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAllProcess();

            listBox1.Sorted = true;
        }

        private void запуститьЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RunTask frm = new RunTask())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    GetAllProcess();
            }

            listBox1.Sorted = true;

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
