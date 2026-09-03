using Microsoft.Win32;
using System.Diagnostics;
using System.Text;

namespace avtoplanirovshik_start_exit
{
    public partial class Form1 : Form
    {
        //
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\avtoplanirovshik_start-exit.git";
        string file_start = path + @"\avtosapusk.txt";
        string file_exit = path + @"\exit.txt";

        private string settingsPath;

private const string RunKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
    private const string AppName = "avtoplanirovshik_start_exit";

    // Проверяет, есть ли запись в автозагрузке
    private bool IsInStartup()
    {
        using (var key = Registry.CurrentUser.OpenSubKey(RunKey))
        {
            return key?.GetValue(AppName) != null;
        }
    }

    // Добавляет в автозагрузку
    private void AddToStartup()
    {
        try
        {
            // Получаем путь к текущему exe
            string path = System.Reflection.Assembly.GetEntryAssembly().Location;
            using (var key = Registry.CurrentUser.CreateSubKey(RunKey))
            {
                key.SetValue(AppName, $"\"{path}\"");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Не удалось добавить в автозагрузку: " + ex.Message);
        }
    }

    // Удаляет из автозагрузки
    private void RemoveFromStartup()
    {
        try
        {
            using (var key = Registry.CurrentUser.OpenSubKey(RunKey, true))
            {
                if (key != null)
                    key.DeleteValue(AppName, false);
            }
        }
        catch { /* Игнорируем, если уже нет */ }
    }


    public Form1()
        {
            InitializeComponent();
            FormClosing += (s, e) => SaveSettings();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // проверяем наше окно, и если оно было свернуто, делаем событие        
            if (WindowState == FormWindowState.Minimized)
            {
                // прячем наше окно из панели
                Hide();
                // делаем нашу иконку в трее активной
                //notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
                //разворачиваем окно
                WindowState = FormWindowState.Normal;
            }
            Activate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.CheckedChanged += (s, e) => SaveSettings();
            checkBox2.CheckedChanged += (s, e) => SaveSettings();
            checkBox3.CheckedChanged += (s, e) => SaveSettings();
            checkBox4.CheckedChanged += (s, e) => SaveSettings();
            checkBox5.CheckedChanged += (s, e) => SaveSettings();
            checkBox6.CheckedChanged += (s, e) => SaveSettings();
            checkBox7.CheckedChanged += (s, e) => SaveSettings();
            settingsPath = Path.Combine(path, "settings.json");

            LoadSettings(); // сначала загружаем, потом инициализируем UI
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            if (!File.Exists(file_start))
                File.Create(file_start);
            if (!File.Exists(file_exit))
                File.Create(file_exit);
            checkBoxAutostart.Checked = IsInStartup();

            // При изменении галочки сразу пишем в реестр
            checkBoxAutostart.CheckedChanged += (s, ev) =>
            {
                if (checkBoxAutostart.Checked)
                    AddToStartup();
                else
                    RemoveFromStartup();
            };
        }

        private void LoadSettings()
        {
            if (!File.Exists(settingsPath)) return; // первый запуск — всё по умолчанию

            try
            {
                var json = File.ReadAllText(settingsPath);
                var settings = System.Text.Json.JsonSerializer.Deserialize<AppSettings>(json);

                if (settings != null)
                {
                    checkBox1.Checked = settings.Monday;
                    checkBox2.Checked = settings.Tuesday;
                    checkBox3.Checked = settings.Wednesday;
                    checkBox4.Checked = settings.Thursday;
                    checkBox5.Checked = settings.Friday;
                    checkBox6.Checked = settings.Saturday;
                    checkBox7.Checked = settings.Sunday;

                    maskedTextBox1.Text = settings.StartTime ?? "";
                    maskedTextBox2.Text = settings.StopTime ?? "";
                }
            }
            catch
            {
                // файл повреждён — игнорируем, оставляем по умолчанию
            }
        }

        private void SaveSettings()
        {
            var settings = new AppSettings
            {
                Monday = checkBox1.Checked,
                Tuesday = checkBox2.Checked,
                Wednesday = checkBox3.Checked,
                Thursday = checkBox4.Checked,
                Friday = checkBox5.Checked,
                Saturday = checkBox6.Checked,
                Sunday = checkBox7.Checked,

                StartTime = maskedTextBox1.Text.Trim(),
                StopTime = maskedTextBox2.Text.Trim()
            };

            File.WriteAllText(settingsPath, System.Text.Json.JsonSerializer.Serialize(settings));
        }


        private List<string> Chit(string str)
        {
            List<string> a = new List<string>();
            using (StreamReader sr = new StreamReader(str, Encoding.GetEncoding("UTF-8")))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    a.Add(line);
            }
            return a;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            //Console.WriteLine($"D: {now.ToString("D")}"); //D: 6 января 2022 г.
            //Console.WriteLine($"d: {now.ToString("d")}"); //d: 06.01.2022
            //Console.WriteLine($"F: {now.ToString("F")}"); //F: 6 января 2022 г. 14:45:20
            //Console.WriteLine($"f: {now:f}"); //f: 6 января 2022 г. 14:45
            //Console.WriteLine($"G: {now:G}"); //G: 06.01.2022 14:45:20
            //Console.WriteLine($"g: {now:g}"); //g: 06.01.2022 14:45
            //Console.WriteLine($"M: {now:M}"); //M: 6 января
            //Console.WriteLine($"O: {now:O}"); //O: 2022-01-06T14:45:20.3942344+04:00
            //Console.WriteLine($"o: {now:o}"); //o: 2022-01-06T14:45:20.3942344+04:00
            //Console.WriteLine($"R: {now:R}"); //R: Thu, 06 Jan 2022 14:45:20 GMT
            //Console.WriteLine($"s: {now:s}"); //s: 2022-01-06T14:45:20
            clock.Text = $"{now:T} {now:dddd}"; //T: 14:45:20
            //Console.WriteLine($"t: {now:t}"); //t: 14:45
            //Console.WriteLine($"U: {now:U}"); //U: 6 января 2022 г. 10:45:20
            //Console.WriteLine($"u: {now:u}"); //u: 2022-01-06 14:45:20
            //Console.WriteLine($"Y: {now:Y}"); //Y: январь 2022 г.
            if ($"{now:T}" == maskedTextBox1.Text.Replace(" ", ""))
                if (check($"{now:dddd}"))
                    start_exit_proc(file_start, true);
            if ($"{now:T}" == maskedTextBox2.Text.Replace(" ", ""))
                if (check($"{now:dddd}"))
                    start_exit_proc(file_exit, false);
        }

        private void start_exit_proc(string filePath, bool isStart)
        {
            if (!File.Exists(filePath)) return;

            foreach (var line in File.ReadLines(filePath))
            {
                string path = line.Trim();
                if (string.IsNullOrEmpty(path)) continue;

                if (isStart)
                {
                    try
                    {
                        var startInfo = new ProcessStartInfo(path)
                        {
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            ErrorDialog = false
                        };
                        Process.Start(startInfo);
                    }
                    catch (Exception ex)
                    {
                        // Лучше логировать в файл, а не в консоль
                        Debug.WriteLine($"Не удалось запустить {path}: {ex.Message}");
                    }
                }
                else
                {
                    // Для завершения берём имя процесса без пути и расширения
                    string processName = Path.GetFileNameWithoutExtension(path);
                    if (string.IsNullOrEmpty(processName)) continue;

                    var processes = Process.GetProcessesByName(processName);
                    foreach (var proc in processes)
                    {
                        try
                        {
                            proc.Kill();
                        }
                        catch (Exception) { /* процесс уже умер */ }
                    }
                }
            }
        }


        bool check(string text)
        {
            Dictionary<string, CheckBox> days = new Dictionary<string, CheckBox>
            {
                ["понедельник"] = checkBox1,
                ["вторник"] = checkBox2,
                ["среда"] = checkBox3,
                ["четверг"] = checkBox4,
                ["пятница"] = checkBox5,
                ["суббота"] = checkBox6,
                ["воскресенье"] = checkBox7
            };
            CheckBox pr = days[text];
            if (pr.Checked)
                return true;
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Filter = "Executables|*.exe|All files|*.*",
                Title = "Выберите файл для автозапуска"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Проверяем, нет ли уже такого пути
                var lines = File.Exists(file_start) ? File.ReadAllLines(file_start).ToList() : new List<string>();
                if (!lines.Contains(filePath))
                {
                    lines.Add(filePath);
                    File.WriteAllLines(file_start, lines);
                    rem(); // обновить список
                }
            }
        }

        private void proc_del_button_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter(file_exit, true))
                stream.WriteLine(proc_del.Text);
            proc_del.Text = "";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rem();
        }

        private void rem()
        {
            int select_Index = tabControl1.SelectedIndex;
            switch (select_Index)
            {
                case 1:
                    try
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.AddRange(Chit(file_start).ToArray());
                    }
                    catch
                    {
                        MessageBox.Show("В автозапуске ничего нет");
                        listBox1.Items.Clear();
                    }
                    break;
                case 2:
                    try
                    {
                        listBox2.Items.Clear();
                        listBox2.Items.AddRange(Chit(file_exit).ToArray());
                    }
                    catch
                    {
                        MessageBox.Show("В авто-выходе ничего нет");
                        listBox1.Items.Clear();
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            del(file_start, listBox1.SelectedItem.ToString());
        }

        private void del(string file, string a)
        {
            // Читаем все строки из файла
            if (string.IsNullOrEmpty(a)) return;

            var lines = File.ReadAllLines(file).ToList();
            lines.RemoveAll(line => line.Trim() == a.Trim());
            File.WriteAllLines(file, lines);
            rem();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            del(file_exit, listBox2.SelectedItem.ToString());
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            Point mousePoint = Cursor.Position;

            // Преобразуем координаты экрана в координаты клиента MaskedTextBox
            Point clientPoint = maskedTextBox1.PointToClient(mousePoint);
            if (clientPoint.X > 70)
            {
                maskedTextBox1.Select(maskedTextBox1.Text.Replace(" :", "").Replace(" ", "").Length, 0);
                maskedTextBox1.Focus();
            }
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Select(maskedTextBox2.Text.Replace(" :", "").Replace(" ", "").Length, 0);
            maskedTextBox2.Focus();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
