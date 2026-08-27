using Start.Properties;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Start
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern bool SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        int sec = 100000000;
        [DllImport("user32")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int
dwExtraInfo);
        private const int KEYEVENTF_KEYUP = 0x02;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Сохранено";

            //SendKeys.SendWait("%+{TAB}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Win32.GetIdleTime() > sec)
            {
                keybd_event((byte)Keys.Menu, 0, 0, 0);
                keybd_event((byte)Keys.Tab, 0, 0, 0);
                System.Threading.Thread.Sleep(1000);
                keybd_event((byte)Keys.Tab, 0, 0, 0);
                System.Threading.Thread.Sleep(1000);
                keybd_event((byte)Keys.Menu, 0, KEYEVENTF_KEYUP, 0);
                keybd_event((byte)Keys.Tab, 0, KEYEVENTF_KEYUP, 0);
            }
            else
            {
                timer1.Stop();
                timer1.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            if (textBox1.Text != "")
                a = Convert.ToInt32(textBox1.Text);
            if (textBox2.Text != "")
                b = Convert.ToInt32(textBox2.Text);
            sec = (a * 60 * 1000) + (b * 1000);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide(); // Скрываем окно
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;// Возвращаем возможность изменения размера
            //notifyIcon1.Visible = false; // Скрываем иконку в трее
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}