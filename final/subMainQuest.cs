using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class subMainQuest : UserControl
    {

        private string[ ] master_level = { "不熟", "稍微知道", "熟悉", "精通" };
        private int index = 0;
        public int _level = 2;
        public int base_time = 20;
        private mQuestInfo _mqi;

        public void setindex (int _index)
        {
            index = _index;
        }
        public subMainQuest (int level,mQuestInfo mqi)
        {
            InitializeComponent();
            _level = level;
            _mqi = mqi;
        }
        #region Properties
        private string _quest_name;
        private int _engage_time;
        [Category("Custom Props")]
        public string quest_name
        {
            get
            {
                return _quest_name;
            }
            set
            {
                _quest_name = value;
                label_quest_name.Text = _quest_name;
            }
        }
        [Category("Custom Props")]
        public int engage_time
        {
            get
            {
                return _engage_time;
            }
            set
            {
                _engage_time = value;
                int i = 0;
                int full = 0;
                int width = 0;
                i = (int)Math.Log((_engage_time / base_time),_level);
              
                if (i > master_level.Length - 1)
                    i = master_level.Length - 1;
                else if (i < 0)
                    i = 0;
                if (engage_time > base_time)
                {
                    full = (int)( Math.Pow(_level, i + 1) - Math.Pow(_level, i) ) * base_time;
                    width = ( this.Width - panelindicator.Width) * ( engage_time - (int)Math.Pow(_level, i) * base_time ) / full;
                    panel_exe.Width = width;
                }
                else
                {
                    full = base_time;
                    width = ( this.Width - panelindicator.Width ) * (engage_time ) / full;
                    panel_exe.Width = width;
                }

                if (i == master_level.Length - 1)
                    panel_exe.Width = this.Width;

                string level_title = master_level[i];
                if (engage_time < 60)
                    label_engage_time.Text = level_title + "(" + _engage_time.ToString() + "分)";
                else
                {
                    label_engage_time.Text = level_title + "(" + ( _engage_time/60).ToString() + "時" + (_engage_time%60).ToString() + "分)";
                }
            }
        }
        public Panel panelindicator
        {
            get
            {
                return panel_indicator;
            }
            set
            {
                panel_indicator = value;
            }
        }
        
        #endregion
        private void subMainQuest_Load (object sender, EventArgs e)
        {
            
        }
        private void select_sub ()
        {
            _mqi.recolor_sub_quest();
            _mqi.focus_index = index;
            panel_indicator.BackColor = Color.Red;
        }

        private void subMainQuest_Click (object sender, EventArgs e)
        {
            select_sub();
        }

        private void btn_edit_Click (object sender, EventArgs e)
        {

        }

        private void btn_train_Click (object sender, EventArgs e)
        {
            practiceForm pForm = new practiceForm();
            pForm.level = _level;
            pForm.Show();
        }

        private void pictureBox1_Click (object sender, EventArgs e)
        {
            select_sub();
            OpenFileDialog upload_pic = new OpenFileDialog();
            upload_pic.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png,*.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (upload_pic.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(upload_pic.FileName);
            }
        }

        private void label_quest_name_DoubleClick (object sender, EventArgs e)
        {
            TextBox rename = new TextBox();
            rename.Location = label_quest_name.Location;
            rename.Width = label_quest_name.Width;
            rename.Height = label_quest_name.Height;
            rename.Text = label_quest_name.Text;
            this.Controls.Add(rename);
            rename.BringToFront();
            rename.KeyDown += new KeyEventHandler(this.rename_Enter);
        }

        private void rename_Enter (object sender, KeyEventArgs e)
        {
            TextBox text = sender as TextBox;
            if (e.KeyCode == Keys.Enter &&  text.Text != "" )
            {     
                label_quest_name.Text = text.Text;
                text.Dispose();
                label_quest_name.BringToFront();
            }
        }

        private void label_engage_time_DoubleClick (object sender, EventArgs e)
        {

        }
    }
}
