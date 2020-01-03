using System.IO;
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace final
{
    public partial class Calendar : Form
    {
        [DllImport("User32.dll")]
        static extern Int32 FindWindow(String lpClassName, String lpWindowName);

        [DllImport("user32.dll")]
        static extern int SetParent(int hWndChild, int hWndNewParent);
        private back back;
        private int tick = 0;
        private int month = 0;
        private int year = 0;
        private bool resizing;
        private int direction = -1;
        private bool onborder;
        private bool resize;
        private bool move;
        private bool mouseDown;
        private Point lastLocation;
        private Point lastCorner;
        private SqlConnection cn;
        private DataTable dt = new DataTable();

        public void enable_move(Control p)
        {
            p.MouseMove += Form1_MouseMove;
            p.MouseDown += Form1_MouseDown;
            p.MouseUp += Form1_MouseUp;
            foreach (Control c in p.Controls)
            {
                c.MouseMove += Form1_MouseMove;
                c.MouseDown += Form1_MouseDown;
                c.MouseUp += Form1_MouseUp;
                if (c.HasChildren)
                    enable_move(c);
            }
        }


        public Calendar()
        {
            InitializeComponent();

            //TransparencyKey = BackColor;

            back = new back(this);
            //Color.FromArgb(10, 200, 0, 200);
            back.Size = Size;
            back.Location = Location;
            calendarGrid.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(calendarGrid, true, null);
            weekGrid.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(calendarGrid, true, null);

            toolbar.Left += 10;

            titlebar.Width = Width;
            titlebar.Height = weekGrid.Top - 2;

            timer1.Start();
            ControlBox = false;//隱藏標題列
            Text = string.Empty;
            title_month.Text = DateTime.Now.Month.ToString();
            title_year.Text = DateTime.Now.Year.ToString();

            cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|theQuest.mdf;" +
                 "Integrated Security=True";
            cn.Open();
            
            SqlDataAdapter db = new SqlDataAdapter("SELECT *  FROM  calendar_data", cn);
            db.Fill(dt);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Panel panel = new Panel();
                    TextBox box = new TextBox();
                    Label date_label = new Label();
                    Label text = new Label();
                    panel.Dock = DockStyle.Fill;
                    panel.Tag = box;
                    panel.Controls.Add(box);
                    panel.Controls.Add(date_label);
                    panel.Controls.Add(text);
                    panel.Click += FinishEdit;
                    panel.Click += edit;

                    box.Hide();
                    box.Dock = DockStyle.Fill;
                    box.Multiline = true;                  
                    box.Width = panel.Width;
                    box.Height = panel.Height;
                    Control[] k = { date_label, text };
                    box.Tag = k;

                    date_label.Top = 0;
                    date_label.Width = panel.Width;
                    date_label.Anchor = (AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                    var d = (int)DateTime.Today.DayOfWeek;
                    date_label.Text = DateTime.Today.AddDays(7*i+j-d).Day.ToString();
                    if (7 * i + j - d == 0)//今天
                        date_label.ForeColor = Color.Red;
                    else
                        date_label.ForeColor = ForeColor;
                    date_label.Click += FinishEdit;
                    date_label.Click += EditOnText;
               
                    text.Text = (dt.Select($@"date='{DateTime.Today.AddDays(7 * i + j - d).ToShortDateString()}'").ElementAtOrDefault(0) ?? dt.Select(@"date='1900/1/1'")[0])["data"].ToString();
                    text.Tag = DateTime.Today.AddDays(7 * i + j - d);
                    text.ForeColor = Color.White;
                    text.Height = panel.Height - date_label.Height + 100;
                    text.Width = panel.Width;
                    text.Anchor = (AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                    text.Click += FinishEdit;
                    text.Click += EditOnText;
                    text.Top = date_label.Bottom;
                    text.BringToFront();

                    calendarGrid.Controls.Add(panel, j, i);
                }
            }

            enable_move(this);
            titlebar.Click += FinishEdit;
            cn.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (move)
            {
                resizing = true;
                mouseDown = true;
                lastLocation = e.Location;
                if (onborder)
                {
                    resize = true;
                }
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //label9.Text = PointToClient(Cursor.Position).ToString();

            if (mouseDown && !resize)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
            back.Location = Location;
            if (move && !resizing)
            {
                if (PointToClient(Cursor.Position).X < 10 && PointToClient(Cursor.Position).Y < 10)
                {
                    onborder = true;
                    direction = 5;
                    Cursor = Cursors.SizeNWSE;
                }
                else if (PointToClient(Cursor.Position).X < 10)
                {
                    onborder = true;
                    direction = 1;
                    Cursor = Cursors.SizeWE;
                }
                else if (PointToClient(Cursor.Position).X > ClientSize.Width - 10)
                {
                    onborder = true;
                    direction = 2;
                    Cursor = Cursors.SizeWE;
                }
                else if (PointToClient(Cursor.Position).Y > ClientSize.Height - 10)
                {
                    onborder = true;
                    direction = 4;
                    Cursor = Cursors.SizeNS;
                }
                else if (PointToClient(Cursor.Position).Y < 10)
                {
                    onborder = true;
                    direction = 3;
                    Cursor = Cursors.SizeNS;
                }
                else
                {
                    onborder = false;
                    resizing = false;
                    Cursor = Cursors.SizeAll;
                }
            }

            if (resize)
            {
                lastCorner = new Point(Right, Bottom);
                if (direction == 1)
                {
                    Left = (this.Location.X - lastLocation.X) + e.X;
                    Width += lastCorner.X - Right;
                    lastCorner.X = Right;
                }
                else if (direction == 2)
                {
                    Width = PointToClient(Cursor.Position).X;
                }
                else if (direction == 3)
                {
                    Top = (this.Location.Y - lastLocation.Y) + e.Y;
                    Height += lastCorner.Y - Bottom;
                    lastCorner.Y = Bottom;
                }
                else if (direction == 4)
                {
                    Height = PointToClient(Cursor.Position).Y;
                }
                else if (direction == 5)
                {
                    Left = (this.Location.X - lastLocation.X) + e.X;
                    Width += lastCorner.X - Right;
                    lastCorner.X = Right;
                    Top = (this.Location.Y - lastLocation.Y) + e.Y;
                    Height += lastCorner.Y - Bottom;
                    lastCorner.Y = Bottom;
                }
            }

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            resize = false;
            resizing = false;
            onborder = false;
            if(move)
                Cursor = Cursors.SizeAll;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.Sizable;
            Cursor = Cursors.SizeAll;
            move = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            move = false;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (back == null)
                return;
            back.Size = Size;
            back.Location = Location;

            int count = 0;
            calendarGrid.Left = 0;
            weekGrid.Left = 0;
            //tableLayoutPanel3.Top = 40;
            titlebar.Width = Width;
            weekGrid.Width = Width;
            calendarGrid.Width = Width;
            calendarGrid.Height = Height - weekGrid.Bottom-2;
            foreach (Panel x in Controls.OfType<Panel>())
            {
                if ((string)x.Tag != "week")
                    continue;
                //x.BorderStyle = BorderStyle.FixedSingle;
                x.Width = Width / 7;
                x.Left = Width / 7 * count;
                if (count == 6)
                    x.Width += 1;
                count++;
            }
            /*foreach (Panel x in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                x.BorderStyle = BorderStyle.FixedSingle;
                if(tableLayoutPanel1.GetRowHeights().Length != 0)
                    x.Height = tableLayoutPanel1.GetRowHeights()[0];
                else
                    x.Height = 107;
                x.Width = Width / 7;
                x.Height = tableLayoutPanel1.Height/4;
                x.Left = Width / 7 * (count % 7);
                if (count % 7 == 6)
                    x.Width = Right - x.Left - 87;
                count++;
                if ((string)x.Tag == "week")
                    continue;
                TextBox z = new TextBox();
                z.Multiline = true;

                x.Controls.Add(z);
                z.Width = x.Width;
                z.Height = x.Height;
                z.Hide();
                x.Click += edit;
                Label y = new Label();
                y.Text = "24";
                x.Controls.Add(y);
            }*/
        }

        private void edit(object sender, EventArgs e)
        {
            ((Control)((Control)sender).Tag).BringToFront();
            ((Control)((Control)sender).Tag).Show();
            ((Control)((Control)sender).Tag).Text = ((Control[])((Control)((Control)sender).Tag).Tag)[1].Text;
            ((Control)((Control)sender).Tag).Focus();
        }
        private void EditOnText(object sender, EventArgs e)
        {
            ((Control)((Control)sender).Parent.Tag).BringToFront();
            ((Control)((Control)sender).Parent.Tag).Show();
            string ee = ((Control[])((Control)((Control)sender).Parent.Tag).Tag)[1].Text;
            ((Control)((Control)sender).Parent.Tag).Text = ((Control[])((Control)((Control)sender).Parent.Tag).Tag)[1].Text;
            ((Control)((Control)sender).Parent.Tag).Focus();
        }
        public void FinishEdit(object sender, EventArgs e)
        {
            foreach (Panel x in calendarGrid.Controls.OfType<Panel>())
            {
                if (((TextBox)x.Tag).Visible) {
                    ((TextBox)x.Tag).Hide();
                    ((Control[])((Control)x.Tag).Tag)[1].Text = ((TextBox)x.Tag).Text;
                    string yy = $"SELECT * FROM calendar_data WHERE date='{((DateTime)((Control[])((Control)x.Tag).Tag)[1].Tag).ToShortDateString()}'";
                    SqlDataAdapter is_exist = new SqlDataAdapter($"SELECT * FROM calendar_data WHERE date='{((DateTime)((Control[])((Control)x.Tag).Tag)[1].Tag).ToShortDateString()}'", cn);
                    DataTable dtt = new DataTable();
                    is_exist.Fill(dtt);
                    if (dtt.Rows.Count == 0)
                    {
                        if (((TextBox)x.Tag).Text != "")
                        {
                            SqlDataAdapter sql = new SqlDataAdapter($"INSERT INTO calendar_data VALUES('{((DateTime)((Control[])((Control)x.Tag).Tag)[1].Tag).ToShortDateString()}',N'{((TextBox)x.Tag).Text}')", cn);
                            sql.Fill(dt);
                        }
                    }
                    else
                    {
                        SqlDataAdapter sql = new SqlDataAdapter($"UPDATE calendar_data SET data = N'{((TextBox)x.Tag).Text}' WHERE date='{((DateTime)((Control[])((Control)x.Tag).Tag)[1].Tag).ToShortDateString()}'", cn);
                        sql.Fill(dt);
                    }
                }
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            back.Close();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            month--;
            title_month.Text = DateTime.Now.AddMonths(month).Month.ToString();
            year--;
            title_year.Text = DateTime.Now.AddYears(year).Year.ToString();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Panel y = (Panel)calendarGrid.GetControlFromPosition(j, i);
                    var d = (int)DateTime.Today.DayOfWeek;
                    ((Control[])((Control)y.Tag).Tag)[0].Text = DateTime.Today.AddDays(7 * i + j - d+28*month).Day.ToString();
                    if (7 * i + j - d + 28 * month == 0)
                        ((Control[])((Control)y.Tag).Tag)[0].ForeColor = Color.Red;
                    else
                        ((Control[])((Control)y.Tag).Tag)[0].ForeColor = ForeColor;
                    ((Control[])((Control)y.Tag).Tag)[1].Text = (dt.Select($@"date='{DateTime.Today.AddDays(7 * i + j - d + 28 * month).ToShortDateString()}'").ElementAtOrDefault(0) ?? dt.Select(@"date='1900/1/1'")[0])["data"].ToString();
                    ((Control[])((Control)y.Tag).Tag)[1].Tag = DateTime.Today.AddDays(7 * i + j - d + 28 * month);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            month++;
            title_month.Text = DateTime.Now.AddMonths(month).Month.ToString();
            year++;
            title_year.Text = DateTime.Now.AddYears(year).Year.ToString();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Panel y = (Panel)calendarGrid.GetControlFromPosition(j, i);
                    var d = (int)DateTime.Today.DayOfWeek;
                    ((Control[])((Control)y.Tag).Tag)[0].Text = DateTime.Today.AddDays(7 * i + j - d + 28 * month).Day.ToString();
                    if (7 * i + j - d + 28 * month == 0)
                        ((Control[])((Control)y.Tag).Tag)[0].ForeColor = Color.Red;
                    else
                        ((Control[])((Control)y.Tag).Tag)[0].ForeColor = ForeColor;
                    ((Control[])((Control)y.Tag).Tag)[1].Text = (dt.Select($@"date='{DateTime.Today.AddDays(7 * i + j - d + 28 * month).ToShortDateString()}'").ElementAtOrDefault(0) ?? dt.Select(@"date='1900/1/1'")[0])["data"].ToString();
                    ((Control[])((Control)y.Tag).Tag)[1].Tag = DateTime.Today.AddDays(7 * i + j - d + 28 * month);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            /*int pWnd = FindWindow("Progman", null);
            int tWnd = Handle.ToInt32();
            SetParent(tWnd, pWnd);*/
            back.Show();
            back.Location = Location;
        }
    }
}
