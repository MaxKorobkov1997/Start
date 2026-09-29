using Start.Properties;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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

        Keys keys;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Static.path))
                Directory.CreateDirectory(Static.path);
                comboBox1.DataSource = Enum.GetValues(typeof(Keys));
            notifyIcon1.BalloonTipTitle = "Сохранено";
            LoadSettings();

            //SendKeys.SendWait("%+{TAB}");1
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Win32.GetIdleTime() > sec)
            {
                if (checkBox2.Checked == true)
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
                    try
                    {
                        
                            keybd_event((byte)keys, 0, 0, 0);
                            keybd_event((byte)keys, 0, KEYEVENTF_KEYUP, 0);
                    }
                    catch { }
                }
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
            if (comboBox1.SelectedItem is Keys k)
            {
                keys = k;
                SaveSettings();
            }
            else
            {
                MessageBox.Show("Кнопка ни подходит");
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
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
        public void LoadSettings()
        {
            if (!File.Exists(Static.settingsPath)) return; // первый запуск — всё по умолчанию

            var json = File.ReadAllText(Static.settingsPath);
            var settings = System.Text.Json.JsonSerializer.Deserialize<AppSeting>(json);

            if (settings != null)
            {
                checkBox1.Checked = settings.chec1;
                checkBox2.Checked = settings.chec2;
                textBox1.Text = settings.min;
                textBox2.Text= settings.sec;
                if (!string.IsNullOrEmpty(settings.key))
                {
                    if (Enum.TryParse<Keys>(settings.key, out var parsedKey))
                    {
                        // Ищем элемент в DataSource (там лежат Keys)
                        var item = comboBox1.Items.Cast<Keys>()
                            .FirstOrDefault(k => k == parsedKey);

                        if (item != null)
                        {
                            keys = item;
                            comboBox1.SelectedItem = item;
                        }
                    }
                }
            }
        }
        private void SaveSettings()
        {
            var settings = new AppSeting
            {
                chec1 = checkBox1.Checked,
                chec2 = checkBox2.Checked,
                key = comboBox1.Text,
                min = textBox1.Text,
                sec = textBox2.Text,
            };
            File.WriteAllText(Static.settingsPath, System.Text.Json.JsonSerializer.Serialize(settings));
        }
    }
}