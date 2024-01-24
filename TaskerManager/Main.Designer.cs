namespace TaskerManager
{
    partial class Main
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            файлToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemRunTask = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            параметрыToolStripMenuItem = new ToolStripMenuItem();
            поверхОстальныхОконToolStripMenuItem = new ToolStripMenuItem();
            сворачиватьПослеОбращенияToolStripMenuItem = new ToolStripMenuItem();
            скрыватьСвернутоеToolStripMenuItem = new ToolStripMenuItem();
            задатьВкладкуПоУмолчаниюToolStripMenuItem = new ToolStripMenuItem();
            процессыToolStripMenuItem = new ToolStripMenuItem();
            производительностьToolStripMenuItem = new ToolStripMenuItem();
            журналПриложенийToolStripMenuItem = new ToolStripMenuItem();
            автозагрузкаToolStripMenuItem = new ToolStripMenuItem();
            пользователиToolStripMenuItem = new ToolStripMenuItem();
            подробноToolStripMenuItem = new ToolStripMenuItem();
            сToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            скоростьОбновленияToolStripMenuItem = new ToolStripMenuItem();
            высокаяToolStripMenuItem = new ToolStripMenuItem();
            обычнаяToolStripMenuItem = new ToolStripMenuItem();
            низкаяToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(172, 327);
            button1.Name = "button1";
            button1.Size = new Size(89, 22);
            button1.TabIndex = 1;
            button1.Text = "Снять задачу\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(23, 327);
            button2.Name = "button2";
            button2.Size = new Size(66, 22);
            button2.TabIndex = 2;
            button2.Text = "Обновить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(2, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(282, 289);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemRunTask, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Padding = new Padding(0, 0, 4, 0);
            файлToolStripMenuItem.Size = new Size(44, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // ToolStripMenuItemRunTask
            // 
            ToolStripMenuItemRunTask.Name = "ToolStripMenuItemRunTask";
            ToolStripMenuItemRunTask.Size = new Size(180, 22);
            ToolStripMenuItemRunTask.Text = "Запустить задачу";
            ToolStripMenuItemRunTask.Click += запуститьЗадачуToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // параметрыToolStripMenuItem
            // 
            параметрыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поверхОстальныхОконToolStripMenuItem, сворачиватьПослеОбращенияToolStripMenuItem, скрыватьСвернутоеToolStripMenuItem, задатьВкладкуПоУмолчаниюToolStripMenuItem });
            параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            параметрыToolStripMenuItem.Size = new Size(83, 20);
            параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // поверхОстальныхОконToolStripMenuItem
            // 
            поверхОстальныхОконToolStripMenuItem.CheckOnClick = true;
            поверхОстальныхОконToolStripMenuItem.Name = "поверхОстальныхОконToolStripMenuItem";
            поверхОстальныхОконToolStripMenuItem.Size = new Size(248, 22);
            поверхОстальныхОконToolStripMenuItem.Text = "Поверх остальных окон";
            // 
            // сворачиватьПослеОбращенияToolStripMenuItem
            // 
            сворачиватьПослеОбращенияToolStripMenuItem.CheckOnClick = true;
            сворачиватьПослеОбращенияToolStripMenuItem.Name = "сворачиватьПослеОбращенияToolStripMenuItem";
            сворачиватьПослеОбращенияToolStripMenuItem.Size = new Size(248, 22);
            сворачиватьПослеОбращенияToolStripMenuItem.Text = "Сворачивать после обращения";
            // 
            // скрыватьСвернутоеToolStripMenuItem
            // 
            скрыватьСвернутоеToolStripMenuItem.Name = "скрыватьСвернутоеToolStripMenuItem";
            скрыватьСвернутоеToolStripMenuItem.Size = new Size(248, 22);
            скрыватьСвернутоеToolStripMenuItem.Text = "Скрывать свернутое";
            // 
            // задатьВкладкуПоУмолчаниюToolStripMenuItem
            // 
            задатьВкладкуПоУмолчаниюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { процессыToolStripMenuItem, производительностьToolStripMenuItem, журналПриложенийToolStripMenuItem, автозагрузкаToolStripMenuItem, пользователиToolStripMenuItem, подробноToolStripMenuItem, сToolStripMenuItem });
            задатьВкладкуПоУмолчаниюToolStripMenuItem.Name = "задатьВкладкуПоУмолчаниюToolStripMenuItem";
            задатьВкладкуПоУмолчаниюToolStripMenuItem.Size = new Size(248, 22);
            задатьВкладкуПоУмолчаниюToolStripMenuItem.Text = "Задать вкладку по умолчанию";
            // 
            // процессыToolStripMenuItem
            // 
            процессыToolStripMenuItem.CheckOnClick = true;
            процессыToolStripMenuItem.Name = "процессыToolStripMenuItem";
            процессыToolStripMenuItem.Size = new Size(192, 22);
            процессыToolStripMenuItem.Text = "Процессы";
            // 
            // производительностьToolStripMenuItem
            // 
            производительностьToolStripMenuItem.CheckOnClick = true;
            производительностьToolStripMenuItem.Name = "производительностьToolStripMenuItem";
            производительностьToolStripMenuItem.Size = new Size(192, 22);
            производительностьToolStripMenuItem.Text = "Производительность";
            // 
            // журналПриложенийToolStripMenuItem
            // 
            журналПриложенийToolStripMenuItem.CheckOnClick = true;
            журналПриложенийToolStripMenuItem.Name = "журналПриложенийToolStripMenuItem";
            журналПриложенийToolStripMenuItem.Size = new Size(192, 22);
            журналПриложенийToolStripMenuItem.Text = "Журнал приложений";
            // 
            // автозагрузкаToolStripMenuItem
            // 
            автозагрузкаToolStripMenuItem.CheckOnClick = true;
            автозагрузкаToolStripMenuItem.Name = "автозагрузкаToolStripMenuItem";
            автозагрузкаToolStripMenuItem.Size = new Size(192, 22);
            автозагрузкаToolStripMenuItem.Text = "Автозагрузка";
            // 
            // пользователиToolStripMenuItem
            // 
            пользователиToolStripMenuItem.CheckOnClick = true;
            пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            пользователиToolStripMenuItem.Size = new Size(192, 22);
            пользователиToolStripMenuItem.Text = "Пользователи";
            // 
            // подробноToolStripMenuItem
            // 
            подробноToolStripMenuItem.CheckOnClick = true;
            подробноToolStripMenuItem.Name = "подробноToolStripMenuItem";
            подробноToolStripMenuItem.Size = new Size(192, 22);
            подробноToolStripMenuItem.Text = "Подробно";
            // 
            // сToolStripMenuItem
            // 
            сToolStripMenuItem.CheckOnClick = true;
            сToolStripMenuItem.Name = "сToolStripMenuItem";
            сToolStripMenuItem.Size = new Size(192, 22);
            сToolStripMenuItem.Text = "Службы";
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { скоростьОбновленияToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";
            // 
            // скоростьОбновленияToolStripMenuItem
            // 
            скоростьОбновленияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { высокаяToolStripMenuItem, обычнаяToolStripMenuItem, низкаяToolStripMenuItem });
            скоростьОбновленияToolStripMenuItem.Name = "скоростьОбновленияToolStripMenuItem";
            скоростьОбновленияToolStripMenuItem.Size = new Size(196, 22);
            скоростьОбновленияToolStripMenuItem.Text = "Скорость обновления";
            // 
            // высокаяToolStripMenuItem
            // 
            высокаяToolStripMenuItem.Name = "высокаяToolStripMenuItem";
            высокаяToolStripMenuItem.Size = new Size(180, 22);
            высокаяToolStripMenuItem.Text = "Высокая";
            // 
            // обычнаяToolStripMenuItem
            // 
            обычнаяToolStripMenuItem.Name = "обычнаяToolStripMenuItem";
            обычнаяToolStripMenuItem.Size = new Size(180, 22);
            обычнаяToolStripMenuItem.Text = "Обычная";
            // 
            // низкаяToolStripMenuItem
            // 
            низкаяToolStripMenuItem.Name = "низкаяToolStripMenuItem";
            низкаяToolStripMenuItem.Size = new Size(180, 22);
            низкаяToolStripMenuItem.Text = "Низкая";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, параметрыToolStripMenuItem, видToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(284, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(300, 400);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Диспетчер задач";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemRunTask;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem параметрыToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem поверхОстальныхОконToolStripMenuItem;
        private ToolStripMenuItem сворачиватьПослеОбращенияToolStripMenuItem;
        private ToolStripMenuItem скрыватьСвернутоеToolStripMenuItem;
        private ToolStripMenuItem задатьВкладкуПоУмолчаниюToolStripMenuItem;
        private ToolStripMenuItem процессыToolStripMenuItem;
        private ToolStripMenuItem производительностьToolStripMenuItem;
        private ToolStripMenuItem журналПриложенийToolStripMenuItem;
        private ToolStripMenuItem автозагрузкаToolStripMenuItem;
        private ToolStripMenuItem пользователиToolStripMenuItem;
        private ToolStripMenuItem подробноToolStripMenuItem;
        private ToolStripMenuItem сToolStripMenuItem;
        private ToolStripMenuItem скоростьОбновленияToolStripMenuItem;
        private ToolStripMenuItem высокаяToolStripMenuItem;
        private ToolStripMenuItem обычнаяToolStripMenuItem;
        private ToolStripMenuItem низкаяToolStripMenuItem;
    }
}
