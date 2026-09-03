namespace avtoplanirovshik_start_exit
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            clock = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            clock_zapuska = new Label();
            clock_dalit = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            выходToolStripMenuItem = new ToolStripMenuItem();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            proc_del_button = new Button();
            proc_del = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button1 = new Button();
            listBox1 = new ListBox();
            tabPage3 = new TabPage();
            button3 = new Button();
            listBox2 = new ListBox();
            formStyle1 = new FormStyle(components);
            checkBoxAutostart = new CheckBox();
            contextMenuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // clock
            // 
            clock.AutoSize = true;
            clock.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clock.Location = new Point(245, 15);
            clock.Margin = new Padding(4, 0, 4, 0);
            clock.Name = "clock";
            clock.Size = new Size(79, 29);
            clock.TabIndex = 0;
            clock.Text = "label1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // clock_zapuska
            // 
            clock_zapuska.AutoSize = true;
            clock_zapuska.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clock_zapuska.Location = new Point(57, 80);
            clock_zapuska.Margin = new Padding(4, 0, 4, 0);
            clock_zapuska.Name = "clock_zapuska";
            clock_zapuska.Size = new Size(257, 24);
            clock_zapuska.TabIndex = 1;
            clock_zapuska.Text = "Время запуска приложения";
            // 
            // clock_dalit
            // 
            clock_dalit.AutoSize = true;
            clock_dalit.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clock_dalit.Location = new Point(57, 155);
            clock_dalit.Margin = new Padding(4, 0, 4, 0);
            clock_dalit.Name = "clock_dalit";
            clock_dalit.Size = new Size(285, 24);
            clock_dalit.TabIndex = 2;
            clock_dalit.Text = "Время вырубания приложения";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(110, 26);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(109, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(350, 80);
            maskedTextBox1.Margin = new Padding(4, 3, 4, 3);
            maskedTextBox1.Mask = "00:00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(116, 26);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.Click += maskedTextBox1_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(350, 155);
            maskedTextBox2.Margin = new Padding(4, 3, 4, 3);
            maskedTextBox2.Mask = "00:00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(116, 26);
            maskedTextBox2.TabIndex = 7;
            maskedTextBox2.Click += maskedTextBox2_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(61, 293);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(575, 87);
            button2.TabIndex = 9;
            button2.Text = "Выбор программы на\nавтовключения";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(62, 215);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 28);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Понедельник";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox5.Location = new Point(62, 257);
            checkBox5.Margin = new Padding(4, 3, 4, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(105, 28);
            checkBox5.TabIndex = 11;
            checkBox5.Text = "Пятница";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox4.Location = new Point(514, 215);
            checkBox4.Margin = new Padding(4, 3, 4, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(103, 28);
            checkBox4.TabIndex = 12;
            checkBox4.Text = "Четверг";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox3.Location = new Point(370, 215);
            checkBox3.Margin = new Padding(4, 3, 4, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(86, 28);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "Среда";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox2.Location = new Point(248, 215);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(104, 28);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "Вторник";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox7.Location = new Point(338, 257);
            checkBox7.Margin = new Padding(4, 3, 4, 3);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(147, 28);
            checkBox7.TabIndex = 15;
            checkBox7.Text = "Воскресенье";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox6.Location = new Point(204, 257);
            checkBox6.Margin = new Padding(4, 3, 4, 3);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(104, 28);
            checkBox6.TabIndex = 16;
            checkBox6.Text = "Суббота";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // proc_del_button
            // 
            proc_del_button.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            proc_del_button.Location = new Point(225, 524);
            proc_del_button.Margin = new Padding(4, 3, 4, 3);
            proc_del_button.Name = "proc_del_button";
            proc_del_button.Size = new Size(239, 60);
            proc_del_button.TabIndex = 17;
            proc_del_button.Text = "Сохранить";
            proc_del_button.UseVisualStyleBackColor = true;
            proc_del_button.Click += proc_del_button_Click;
            // 
            // proc_del
            // 
            proc_del.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            proc_del.Location = new Point(62, 470);
            proc_del.Margin = new Padding(4, 3, 4, 3);
            proc_del.Multiline = true;
            proc_del.Name = "proc_del";
            proc_del.Size = new Size(573, 47);
            proc_del.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(57, 400);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(427, 48);
            label1.TabIndex = 19;
            label1.Text = "Напишите процесс который нужно завершить\nпо истечении времени";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(719, 624);
            tabControl1.TabIndex = 20;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(checkBoxAutostart);
            tabPage1.Controls.Add(clock_dalit);
            tabPage1.Controls.Add(clock_zapuska);
            tabPage1.Controls.Add(maskedTextBox1);
            tabPage1.Controls.Add(clock);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(maskedTextBox2);
            tabPage1.Controls.Add(proc_del);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(proc_del_button);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(checkBox6);
            tabPage1.Controls.Add(checkBox5);
            tabPage1.Controls.Add(checkBox7);
            tabPage1.Controls.Add(checkBox4);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(711, 591);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Главная";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(711, 591);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Удалиние_из_автозапуска";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(220, 549);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(231, 37);
            button1.TabIndex = 1;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(4, 7);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(698, 524);
            listBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(listBox2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(711, 591);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Удалиние_из_автовыхода";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(219, 549);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(231, 37);
            button3.TabIndex = 3;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.Location = new Point(6, 7);
            listBox2.Margin = new Padding(4, 3, 4, 3);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(698, 524);
            listBox2.TabIndex = 2;
            // 
            // formStyle1
            // 
            formStyle1.color = Color.Black;
            formStyle1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            formStyle1.Form = this;
            formStyle1.Text_posishen = FormStyle.fStyle.Center;
            // 
            // checkBoxAutostart
            // 
            checkBoxAutostart.AutoSize = true;
            checkBoxAutostart.Location = new Point(16, 12);
            checkBoxAutostart.Name = "checkBoxAutostart";
            checkBoxAutostart.Size = new Size(106, 24);
            checkBoxAutostart.TabIndex = 20;
            checkBoxAutostart.Text = "checkBox8";
            checkBoxAutostart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 628);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Автозапуск";
            Load += Form1_Load;
            Resize += Form1_Resize;
            contextMenuStrip1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clock_zapuska;
        private System.Windows.Forms.Label clock_dalit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Button proc_del_button;
        private System.Windows.Forms.TextBox proc_del;
        private System.Windows.Forms.Label label1;
        private FormStyle formStyle1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private CheckBox checkBoxAutostart;
    }
}

