using System;
using System.Collections.Generic;
using System.Text;

namespace avtoplanirovshik_start_exit
{
    internal class AppSettings
    {
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }

        public string StartTime { get; set; }      // как в maskedTextBox1
        public string StopTime { get; set; }       // как в maskedTextBox2
    }
}
