using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace TaskerManager
{
    public partial class RunTask : Form
    {
        public RunTask()
        {
            InitializeComponent();
        }

        private void RunTask_Load(object sender, EventArgs e)
        {

        }

        private void btnRunTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOpen.Text))
            {
                try
                {
                    //Start new process
                    Process proc = new Process();
                    proc.StartInfo.FileName = txtOpen.Text;
                    proc.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtOpen.Text))
            {
                Interaction.Shell("explorer /select," + "C:\\file.txt", AppWinStyle.NormalFocus);
            }
        }

        private void txtOpen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
