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
            int pWnd = FindWindow("SysListView32", null);
            int tWnd = Handle.ToInt32();
            SetParent(tWnd, pWnd);
        }
    }
}
