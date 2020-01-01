using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class back : Form
    {
        [DllImport("User32.dll")]
        static extern Int32 FindWindow(String lpClassName, String lpWindowName);

        [DllImport("user32.dll")]
        static extern int SetParent(int hWndChild, int hWndNewParent);

        Calendar c;
        public back(Calendar r)
        {
            InitializeComponent();
            c = r;
            c.enable_move(this);
        }

        private void back_Load(object sender, EventArgs e)
        {
            /*int pWnd = FindWindow("Progman", null);
            int tWnd = Handle.ToInt32();
            SetParent(tWnd, pWnd);*/
            ControlBox = false;//隱藏標題列
            Text = string.Empty;
            BackColor = Color.FromArgb(46, 114, 138);
            calendarGrid.Top = 96;
            weekGrid.Top = 63;
            Size = c.Size;
        }

        private void back_MouseDown(object sender, MouseEventArgs e)
        {
            c.Focus();
        }

        private void back_SizeChanged(object sender, EventArgs e)
        {
            calendarGrid.Top = 96;
            weekGrid.Top = 63;
        }
    }
}
