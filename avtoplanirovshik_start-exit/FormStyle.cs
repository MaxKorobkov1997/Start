using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace avtoplanirovshik_start_exit
{
    public partial class FormStyle : Component
    {
        bool clouseHowe = false;
        Rectangle rectangle_clouse = new Rectangle();

        bool MousePresed = false;
        Point clickPosishen;
        Point mouseStartPosishen;

        private bool minimizeHovered = false;
        Rectangle rectangle_Min = new Rectangle();

        public Form Form { get; set; }
        private fStyle text_posishen;
        private int HeaderHeigt = 25;

        [Description("Цвет шапки (заголовка)")]
        public Color color { get; set; } = Color.DimGray;

        Pen pen = new Pen(Color.White) { Width = 1.55F };

        public StringFormat sf = new StringFormat();

        [Description("Шрифт текста шапки (заголовка)")]
        public Font Font { get; set; } = new Font("Arial", 8.75f, FontStyle.Regular);

        private Size icon_size = new Size(14, 20);
        public fStyle Text_posishen
        {
            get => text_posishen;
            set
            {
                text_posishen = value;
                sign();
            }
        }

        public enum fStyle // Позиция нидписи
        {
            Near,
            Center,
        }

        public FormStyle()
        {
            InitializeComponent();
        }

        public FormStyle(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void sign()
        {
            if (Form != null)
            {
                Form.Load += Form_Load;
            }
        }

        private void Apply()
        {
            if (Text_posishen == fStyle.Near)
                sf.Alignment = StringAlignment.Near;
            else
                sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            Form.FormBorderStyle = FormBorderStyle.None;
            //Size minimumSize = new Size(100, 50);
            //if (Form.MinimumSize.Width < minimumSize.Width || Form.MinimumSize.Height < minimumSize.Height)
            //    Form.MinimumSize = minimumSize;
            Ofset_controls();
            SetDoubleBuffered(Form);
            Form.Paint += Form_Paint;
            Form.MouseDown += Form_MouseDown;
            Form.MouseUp += Form_MouseUp;
            Form.MouseMove += Form_MouseMove;
            Form.MouseLeave += Form_MouseLeave;
        }

        private void Form_MouseLeave(object sender, EventArgs e)
        {
            clouseHowe = false;
            minimizeHovered = false;
            Form.Invalidate();

        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (MousePresed)
            {
                Size frmOfset = new Size(Point.Subtract(Cursor.Position, new Size(clickPosishen)));
                Form.Location = Point.Add(mouseStartPosishen, frmOfset);
            }
            else
            {
                if (rectangle_clouse.Contains(e.Location))
                {
                    if (clouseHowe == false)
                    {
                        clouseHowe = true;
                        Form.Invalidate();
                    }
                }
                else
                {
                    if (clouseHowe == true)
                    {
                        clouseHowe = false;
                        Form.Invalidate();
                    }
                }
                if (rectangle_Min.Contains(e.Location))
                {
                    if (minimizeHovered == false)
                    {
                        minimizeHovered = true;
                        Form.Invalidate();
                    }
                }
                else
                {
                    if (minimizeHovered == true)
                    {
                        minimizeHovered = false;
                        Form.Invalidate();
                    }
                }
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            MousePresed = false;
            if (e.Button == MouseButtons.Left)
            {
                if (rectangle_clouse.Contains(e.Location))
                    Form.Close();
                if (rectangle_Min.Contains(e.Location))
                    Form.WindowState = FormWindowState.Minimized;
            }

        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Location.Y <= HeaderHeigt)
            {
                MousePresed = true;
                clickPosishen = Cursor.Position;
                mouseStartPosishen = Form.Location;
            }
        }

        private void Ofset_controls()
        {
            Form.Height = Form.Height + HeaderHeigt;
            foreach (Control control in Form.Controls)
            {
                control.Location = new Point(control.Location.X, control.Location.Y + HeaderHeigt);
                control.Refresh();
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Apply();
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            DrawStyle(e.Graphics);
        }

        private void DrawStyle(Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            //Шапка
            Rectangle rectangle_heder = new Rectangle(0, 0, Form.Width - 1, HeaderHeigt);
            graphics.DrawRectangle(new Pen(color), rectangle_heder);
            graphics.FillRectangle(new SolidBrush(color), rectangle_heder);

            //Обводка
            Rectangle rectangle_boder = new Rectangle(0, 0, Form.Width - 1, Form.Height - 1);
            graphics.DrawRectangle(new Pen(Color.Black), rectangle_boder);

            //Текст заголовка
            Rectangle rectangle_text = new Rectangle(rectangle_heder.X + 20, rectangle_heder.Y,
                rectangle_heder.Width - 50, rectangle_heder.Height);
            graphics.DrawString(Form.Text, Font, new SolidBrush(Color.White), rectangle_text, sf);

            //Иконка
            Rectangle rectangle_icon = new Rectangle(rectangle_heder.Height / 2 - icon_size.Width / 2,
                rectangle_heder.Height / 2 - icon_size.Height / 2, icon_size.Width, icon_size.Height);
            graphics.DrawImage(Form.Icon.ToBitmap(), rectangle_icon);

            //Кнопка X
            rectangle_clouse = new Rectangle(rectangle_heder.Width - rectangle_heder.Height,
                rectangle_heder.Y, rectangle_heder.Height, rectangle_heder.Height);
            Rectangle rectangle_X = new Rectangle(rectangle_clouse.X + rectangle_clouse.Width / 2 - 5,
                rectangle_clouse.Height / 2 - 5, 10, 10);
            graphics.DrawRectangle(new Pen(clouseHowe ? Color.Red : color), rectangle_clouse);
            graphics.FillRectangle(new SolidBrush(clouseHowe ? Color.Red : color), rectangle_clouse);
            DrowCrossheir(graphics, rectangle_X, pen);

            //Кнопка _
            rectangle_Min = new Rectangle(rectangle_heder.Width - rectangle_heder.Height * 2,
                rectangle_heder.Y, rectangle_heder.Height, rectangle_heder.Height);
            Rectangle rectangle_ = new Rectangle(rectangle_Min.X + rectangle_Min.Width / 2 - 5,
                rectangle_Min.Height / 2 - 5, 10, 10);
            graphics.DrawRectangle(new Pen(minimizeHovered ? Color.Blue : color), rectangle_Min);
            graphics.FillRectangle(new SolidBrush(minimizeHovered ? Color.Blue : color), rectangle_Min);
            DrowCrossheir_(graphics, rectangle_, pen);
        }

        private void DrowCrossheir(Graphics graphics, Rectangle rectangle, Pen p)
        {
            graphics.DrawLine(p, rectangle.X, rectangle.Y, rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);
            graphics.DrawLine(p, rectangle.X + rectangle.Width, rectangle.Y, rectangle.X, rectangle.Y + rectangle.Height);
        }

        private void DrowCrossheir_(Graphics graphics, Rectangle rectangle, Pen p)
        {
            graphics.DrawLine(p, rectangle.X, rectangle.Y + rectangle.Height, rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);
            //graphics.DrawLine(p, rectangle.X + rectangle.Width, rectangle.Y, rectangle.X, rectangle.Y + rectangle.Height);
        }

        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo pDoubleBuffered =
                  typeof(Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            pDoubleBuffered.SetValue(c, true, null);
        }
    }
}