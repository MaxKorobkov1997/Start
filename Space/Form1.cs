using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int
dwExtraInfo);
        private const int KEYEVENTF_KEYUP = 0x02;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            if (btn.Text == "Старт")
            { 
                btn.Text = "Стоп";
                timer1.Enabled = true;
            }
            else
            {
                btn.Text = "Старт";
                timer1.Enabled = false;
            }
            ActiveControl = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            keybd_event((byte)Keys.Space, 0, 0, 0);
            keybd_event((byte)Keys.Space, 0, KEYEVENTF_KEYUP, 0);
        }
    }
}
