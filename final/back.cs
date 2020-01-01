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
        public back()
        {
            InitializeComponent();

        }

        private void back_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(46, 114, 138);
            calendarGrid.Top = 96;
            weekGrid.Top = 63;
            int pWnd = FindWindow("SysListView32", null);
            int tWnd = Handle.ToInt32();
            SetParent(tWnd, pWnd);
        }

        private void back_Click(object sender, EventArgs e)
        {
            SendToBack();
        }
    }
}
