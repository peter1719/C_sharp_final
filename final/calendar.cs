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

namespace final
{
    public partial class Calendar : Form
    {
        private Form back;
        private int tick = 0;
        private int m = 0;
        private bool resizing;
        private int direction = -1;
        private bool onborder;
        private bool resize;
        private bool move;
        private bool mouseDown;
        private Point lastLocation;
        private Point lastCorner;

        public Calendar()
        {
            InitializeComponent();
            back = new back();

            back.Size = Size;
            back.Location = Location;
            back.Show();
            tableLayoutPanel1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel1, true, null);
            tableLayoutPanel3.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel1, true, null);
            //tableLayoutPanel1.BackColor = Color.FromArgb(10, 200, 0, 200);
            TransparencyKey = BackColor;
            //tableLayoutPanel3.BackColor = Color.FromArgb(1, 200, 0, 200);
            tableLayoutPanel2.Left += 10;

            panel1.Width = Width;
            panel1.Height = tableLayoutPanel3.Top - 2;

            timer1.Start();
            ControlBox = false;
            Text = string.Empty;
            label8.Text = DateTime.Now.Month.ToString();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Panel x = new Panel();
                    TextBox z = new TextBox();
                    x.Dock = DockStyle.Fill;
                    z.Dock = DockStyle.Fill;
                    //x.Height = 1000;
                    //z.Height = 1000;
                    z.Multiline = true;
                    
                    x.Tag = z;
                    x.Controls.Add(z);
                    z.Width = x.Width;
                    z.Height = x.Height;
                    z.Hide();
                    x.Click += Form1_Click;
                    x.Click += edit;
                    Label y = new Label();
                    var d = (int)DateTime.Today.DayOfWeek;
                    y.Text = DateTime.Today.AddDays(7*i+j-d).Day.ToString();
                    x.Controls.Add(y);
                    y.Click += Form1_Click;
                    y.Click += edit_l;
                    y.Top = 0;

                    Label a = new Label();
                    a.ForeColor = Color.White;
                    y.Width = x.Width;
                    a.Width = x.Width;
                    y.Anchor = (AnchorStyles.Right | AnchorStyles.Left| AnchorStyles.Top);
                    a.Anchor = (AnchorStyles.Right|AnchorStyles.Left| AnchorStyles.Top);
                    a.Click += Form1_Click;
                    a.Click += edit_l;
                    a.Height = x.Height - y.Height + 100;
                    //a.Text = "test456";
                    Control[] k = { y, a };
                    z.Tag = k;
                    x.Controls.Add(a);
                    a.BringToFront();
                    a.Top = y.Bottom;
                    tableLayoutPanel1.Controls.Add(x, j, i);
                }
            }
            foreach (Control x in Controls)
            {
                x.Click += Form1_Click;
                x.MouseMove += Form1_MouseMove;
                x.MouseDown += Form1_MouseDown;
                x.MouseUp += Form1_MouseUp;
            }
            foreach (Control x in tableLayoutPanel1.Controls)
            {
                foreach (Control y in x.Controls)
                {
                    y.MouseMove += Form1_MouseMove;
                    y.MouseDown += Form1_MouseDown;
                    y.MouseUp += Form1_MouseUp;
                }
            }
            /*tableLayoutPanel1.MouseMove += Form1_MouseMove;
            tableLayoutPanel1.MouseDown += Form1_MouseDown;
            tableLayoutPanel1.MouseUp += Form1_MouseUp;
            tableLayoutPanel3.MouseMove += Form1_MouseMove;
            tableLayoutPanel3.MouseDown += Form1_MouseDown;
            tableLayoutPanel3.MouseUp += Form1_MouseUp;
            panel1.MouseMove += Form1_MouseMove;
            panel1.MouseDown += Form1_MouseDown;
            panel1.MouseUp += Form1_MouseUp;*/
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
            back.Location = Location;
            if (mouseDown && !resize)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
            if (move && !resizing)
            {
                if (e.X < 10 && e.Y < 10)
                {
                    onborder = true;
                    direction = 5;
                    Cursor = Cursors.SizeNWSE;
                }
                else if (e.X < 10)
                {
                    onborder = true;
                    direction = 1;
                    Cursor = Cursors.SizeWE;
                }
                else if (e.X > ClientSize.Width - 10)
                {
                    onborder = true;
                    direction = 2;
                    Cursor = Cursors.SizeWE;
                }
                else if (e.Y > ClientSize.Height - 10)
                {
                    onborder = true;
                    direction = 4;
                    Cursor = Cursors.SizeNS;
                }
                else if (e.Y < 10)
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
                    Width = e.X;
                }
                else if (direction == 3)
                {
                    Top = (this.Location.Y - lastLocation.Y) + e.Y;
                    Height += lastCorner.Y - Bottom;
                    lastCorner.Y = Bottom;
                }
                else if (direction == 4)
                {
                    Height = e.Y+87;
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
            back.Size = Size;
            back.Location = Location;

            int count = 0;
            tableLayoutPanel1.Left = 0;
            tableLayoutPanel3.Left = 0;
            //tableLayoutPanel3.Top = 40;
            panel1.Width = Width;
            tableLayoutPanel3.Width = Width;
            tableLayoutPanel1.Width = Width;
            tableLayoutPanel1.Height = Height - tableLayoutPanel3.Bottom-2;
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
            ((Control)((Control)sender).Tag).Focus();
        }
        private void edit_l(object sender, EventArgs e)
        {
            ((Control)((Control)sender).Parent.Tag).BringToFront();
            ((Control)((Control)sender).Parent.Tag).Show();
            ((Control)((Control)sender).Parent.Tag).Focus();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            foreach (Panel x in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                ((TextBox)x.Tag).Hide();
                ((Control[])((Control)x.Tag).Tag)[1].Text = ((TextBox)x.Tag).Text;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            m--;
            label8.Text = DateTime.Now.AddMonths(m).Month.ToString();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Panel y = (Panel)tableLayoutPanel1.GetControlFromPosition(j, i);
                    var d = (int)DateTime.Today.DayOfWeek;
                    ((Control[])((Control)y.Tag).Tag)[0].Text = DateTime.Today.AddDays(7 * i + j - d+28*m).Day.ToString();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m++;
            label8.Text = DateTime.Now.AddMonths(m).Month.ToString();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Panel y = (Panel)tableLayoutPanel1.GetControlFromPosition(j, i);
                    var d = (int)DateTime.Today.DayOfWeek;
                    ((Control[])((Control)y.Tag).Tag)[0].Text = DateTime.Today.AddDays(7 * i + j - d + 28 * m).Day.ToString();

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
        }

    }
}
