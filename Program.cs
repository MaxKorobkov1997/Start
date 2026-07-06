namespace Start
{
    internal static class Program
    {
        private static readonly string UniqueMutexName = "{E1B0F4CC-49B7-463C-A129-7B2A9D7315D2}"; // Замените на свой уникальный GUID
        private static Mutex mutex = new Mutex(true, UniqueMutexName);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true)) // true — попытка стать владельцем
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                mutex.ReleaseMutex(); // Не забудьте освободить, когда приложение закрывается
            }
            else
            {
                MessageBox.Show("Программа уже запущена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}