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
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static mainChar mchar = new mainChar();
        private mainQuest mquest = new mainQuest();
        private Calendar calendar = new Calendar();
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        public Form1 ()
        {
            InitializeComponent();

        }
        public Panel Panelcontainer
        {
            get
            {
                return panelcontainer;
            }
            set
            {
                panelcontainer = value;
            }
        }


        private void Form1_Load (object sender, EventArgs e)
        {
            _obj = this;
            btn_char_Click( sender, e);
            mchar.read_pros_file();            
        }

        private void btn_char_Click (object sender, EventArgs e)
        {
            if (!panelcontainer.Controls.ContainsKey("mainChar"))
            {
                panelcontainer.Controls.Clear();
                mchar.Dock = DockStyle.Fill;
                panelcontainer.Controls.Add(mchar);
                panelcontainer.Controls["mainChar"].BringToFront();
            }
        }

        private void btn_main_Click (object sender, EventArgs e)
        {
            if (!panelcontainer.Controls.ContainsKey("mainQuest"))
            {
                panelcontainer.Controls.Clear();
                mquest.Dock = DockStyle.Fill;
                panelcontainer.Controls.Add(mquest);
                panelcontainer.Controls["mainQuest"].BringToFront();
            }
        }

        private void btn_branch_Click (object sender, EventArgs e)
        {
            calendar.Show();
            Focus();
        }
    }
}
