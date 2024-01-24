namespace TaskerManager
{
    partial class RunTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunTask));
            txtOpen = new TextBox();
            btnRunTask = new Button();
            lblOpen = new Label();
            btnBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // txtOpen
            // 
            txtOpen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOpen.BorderStyle = BorderStyle.FixedSingle;
            txtOpen.Location = new Point(82, 12);
            txtOpen.MinimumSize = new Size(200, 23);
            txtOpen.Name = "txtOpen";
            txtOpen.Size = new Size(328, 23);
            txtOpen.TabIndex = 0;
            txtOpen.TextChanged += txtOpen_TextChanged;
            // 
            // btnRunTask
            // 
            btnRunTask.Anchor = AnchorStyles.Top;
            btnRunTask.DialogResult = DialogResult.OK;
            btnRunTask.Location = new Point(206, 41);
            btnRunTask.Name = "btnRunTask";
            btnRunTask.Size = new Size(99, 27);
            btnRunTask.TabIndex = 1;
            btnRunTask.Text = "OK";
            btnRunTask.UseVisualStyleBackColor = true;
            btnRunTask.Click += btnRunTask_Click;
            // 
            // lblOpen
            // 
            lblOpen.AutoSize = true;
            lblOpen.Location = new Point(16, 14);
            lblOpen.Name = "lblOpen";
            lblOpen.Size = new Size(60, 15);
            lblOpen.TabIndex = 2;
            lblOpen.Text = "Открыть :";
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top;
            btnBrowse.DialogResult = DialogResult.OK;
            btnBrowse.Location = new Point(311, 41);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(99, 27);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Обзор...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.InitialDirectory = "c:\\\\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Выбор файла";
            // 
            // RunTask
            // 
            AcceptButton = btnRunTask;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 80);
            Controls.Add(btnBrowse);
            Controls.Add(lblOpen);
            Controls.Add(btnRunTask);
            Controls.Add(txtOpen);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(447, 119);
            Name = "RunTask";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Запуск задачи";
            Load += RunTask_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOpen;
        private Button btnRunTask;
        private Label lblOpen;
        private Button btnBrowse;
        private OpenFileDialog openFileDialog1;
    }
}