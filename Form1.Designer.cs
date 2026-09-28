namespace Start
{
    partial class Form1
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            закрытьToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            comboBox1 = new ComboBox();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(45, 23);
            textBox1.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { закрытьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(121, 26);
            // 
            // закрытьToolStripMenuItem
            // 
            закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            закрытьToolStripMenuItem.Size = new Size(120, 22);
            закрытьToolStripMenuItem.Text = "Закрыть";
            закрытьToolStripMenuItem.Click += закрытьToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(40, 131);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 1;
            label1.Text = "Мин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(40, 156);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 2;
            label2.Text = "Сек";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(45, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(39, 180);
            button1.Name = "button1";
            button1.Size = new Size(155, 42);
            button1.TabIndex = 4;
            button1.Text = "Сщхранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 31);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // button2
            // 
            button2.Location = new Point(217, 5);
            button2.Name = "button2";
            button2.Size = new Size(43, 23);
            button2.TabIndex = 0;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft YaHei", 14.25F);
            checkBox1.Location = new Point(12, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(77, 29);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Своя";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Microsoft YaHei", 14.25F);
            checkBox2.Location = new Point(12, 72);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(98, 29);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Alt-Tab";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 234);
            Controls.Add(comboBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private NotifyIcon notifyIcon1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem закрытьToolStripMenuItem;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private ComboBox comboBox1;
    }
}
