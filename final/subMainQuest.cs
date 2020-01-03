using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace final
{
    public partial class subMainQuest : UserControl
    {
        TextBox rename;
        private string[ ] master_level = { "不熟", "稍微知道", "熟悉", "精通" };
        private int index = 0;
        public int _level = 0;
        public int base_time = 20;
        private mQuestInfo _mqi;
        private bool edit_state = false;
        public void setindex (int _index)
        {
            index = _index;
        }
        public int getindex ()
        {
            return index;
        }
        public subMainQuest (int level, mQuestInfo mqi)
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
                int level_base = 2 + _level;
                i = (int)Math.Log(( _engage_time / base_time ), level_base);

                if (i > master_level.Length - 1)
                    i = master_level.Length - 1;
                else if (i < 0)
                    i = 0;
                if (engage_time > base_time)
                {
                    full = (int)( Math.Pow(level_base, i + 1) - Math.Pow(level_base, i) ) * base_time;
                    width = ( this.Width - panelindicator.Width ) * ( engage_time - (int)Math.Pow(level_base, i) * base_time ) / full;
                    panel_exe.Width = width;
                }
                else
                {
                    full = base_time;
                    width = ( this.Width - panelindicator.Width ) * ( engage_time ) / full;
                    panel_exe.Width = width;
                }

                if (i == master_level.Length - 1)
                    panel_exe.Width = this.Width;

                string level_title = master_level[i];
                if (engage_time < 60)
                    label_engage_time.Text = level_title + "(" + _engage_time.ToString() + "分)";
                else
                {
                    label_engage_time.Text = level_title + "(" + ( _engage_time / 60 ).ToString() + "時" + ( _engage_time % 60 ).ToString() + "分)";
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
            this.Click += new EventHandler(select_sub);
            foreach (Control c in Controls)
            {
                c.Click += new EventHandler(select_sub);
            }
        }
        private void select_sub (object sender, EventArgs e)
        {
            _mqi.recolor_sub_quest();
            _mqi.focus_index = index;
            panel_indicator.BackColor = Color.Red;
            if (edit_state && rename.Text != "")
            {
                edit_state = false;
                SqlConnection quest_db_connect;
                quest_db_connect = new SqlConnection();
                quest_db_connect.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|theQuest.mdf;" +
                     "Integrated Security=True";
                quest_db_connect.Open();
                SqlCommand sql = new SqlCommand($"UPDATE  sub_quest SET name=N'{rename.Text}' WHERE db_index = {index}", quest_db_connect);
                sql.ExecuteNonQuery();
                quest_db_connect.Close();
                label_quest_name.Text = rename.Text;
                rename.Dispose();
                label_quest_name.BringToFront();
                edit_state = false;
            }
        }

        private void subMainQuest_Click (object sender, EventArgs e)
        {
            select_sub(sender, e);
        }

        private void btn_edit_Click (object sender, EventArgs e)
        {

        }

        private void btn_train_Click (object sender, EventArgs e)
        {
            if (!Form1.on_training)
            {
                Form1.on_training = true;
                select_sub(sender, e);
                practiceForm pForm = new practiceForm(this);
                pForm.level = _level;
                pForm.Show();
            }
            else
            {
                MessageBox.Show("一次只能修練一個項目喔!", "貼心提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string path = "";
        public string file_path
        {
            set
            {
                path = value;
                if (File.Exists(value)) //存在
                {
                    pictureBox1.Image = new Bitmap(value);
                }
            }

        }
    
        private void pictureBox1_Click (object sender, EventArgs e)
        {
            select_sub(sender,e);
            OpenFileDialog upload_pic = new OpenFileDialog();
            upload_pic.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png,*.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (upload_pic.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(upload_pic.FileName);
                SqlConnection quest_db_connect;
                quest_db_connect = new SqlConnection();
                quest_db_connect.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|theQuest.mdf;" +
                     "Integrated Security=True";
                quest_db_connect.Open();
                SqlCommand sql = new SqlCommand($"UPDATE sub_quest  SET path=N'{upload_pic.FileName}' WHERE db_index = {index} ", quest_db_connect);
                sql.ExecuteNonQuery();
                quest_db_connect.Close();
            }
        }

        private void label_quest_name_DoubleClick (object sender, EventArgs e)
        {
            edit_state = true;
            rename = new TextBox();
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
                edit_state = false;
                SqlConnection quest_db_connect;
                quest_db_connect = new SqlConnection();
                quest_db_connect.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|theQuest.mdf;" +
                     "Integrated Security=True";
                quest_db_connect.Open();
                SqlCommand sql = new SqlCommand($"UPDATE  sub_quest SET name=N'{text.Text}' WHERE db_index = {index}", quest_db_connect);
                sql.ExecuteNonQuery();
                quest_db_connect.Close();
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
