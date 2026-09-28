using System;
using System.Collections.Generic;
using System.Text;

namespace Start
{
    public class Static
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Exel";
        public static string settingsPath = Path.Combine(path, "settings.json");
    }
}
