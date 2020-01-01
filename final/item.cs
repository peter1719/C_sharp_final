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


namespace final
{
    public partial class item : UserControl
    {
        TextBox rename;
        public item (shop mshop)
        {
            this.mshop = mshop;
            InitializeComponent();
        }
        public Panel panel
        {
            get
            {
                return panel_index;
            }
            set
            {
                panel_index = value;
            }
        }
        public int index = 0;
        public int price = 0;
        public int bought_number = 0;
        public string name = "x";
        public string file_path = "";
        private shop mshop;
        private void item_Load (object sender, EventArgs e)
        {
            this.Click += new EventHandler(select_info);
            foreach (Control c in Controls)
            {
                c.Click += new EventHandler(select_info);
            }
            this.Click += new EventHandler(edit_set);
            foreach (Control c in Controls)
            {
                c.Click += new EventHandler(edit_set);
            }
        }
        public void re_info ()
        {
            label_name.Text = name;
            label_num.Text = bought_number.ToString();
            label_price.Text = price.ToString();
        }
        private bool edit_state = false;
        private int edit_item = 0;
        private void label_name_DoubleClick (object sender, EventArgs e)
        {
            edit_item = 0;
            edit_state = true;
            rename = new TextBox();
            rename.Location = label_name.Location;
            rename.Width = this.Width / 2;
            rename.Height = label_name.Height;
            rename.Text = label_name.Text;
            this.Controls.Add(rename);
            rename.BringToFront();
            rename.KeyDown += new KeyEventHandler(this.rename_Enter);
        }
        private void label_price_DoubleClick (object sender, EventArgs e)
        {
            edit_item = 1;
            edit_state = true;
            rename = new TextBox();
            rename.Location = label_price.Location;
            rename.Width = this.Width / 2;
            rename.Height = label_price.Height;
            rename.Text = "";
            this.Controls.Add(rename);
            rename.BringToFront();
            rename.KeyDown += new KeyEventHandler(this.rename_Enter);
            rename.KeyPress += new KeyPressEventHandler(int_limit);
        }
        private void int_limit (object sender, KeyPressEventArgs e)
        {
            // e.KeyChar == (Char)48 ~ 57 -----> 0~9
            // e.KeyChar == (Char)8 -----------> Backpace
            // e.KeyChar == (Char)13-----------> Enter
            if (e.KeyChar == (Char)48 || e.KeyChar == (Char)49 ||
               e.KeyChar == (Char)50 || e.KeyChar == (Char)51 ||
               e.KeyChar == (Char)52 || e.KeyChar == (Char)53 ||
               e.KeyChar == (Char)54 || e.KeyChar == (Char)55 ||
               e.KeyChar == (Char)56 || e.KeyChar == (Char)57 ||
               e.KeyChar == (Char)13 || e.KeyChar == (Char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void rename_Enter (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && rename.Text != "")
            {
                edit_state = false;
                SqlConnection quest_db_connect;
                quest_db_connect = new SqlConnection();
                quest_db_connect.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|theQuest.mdf;" +
                     "Integrated Security=True";
                quest_db_connect.Open();
                if (edit_item == 0)
                {
                    SqlCommand sql = new SqlCommand($"UPDATE  items SET name=N'{rename.Text}' WHERE id={index} ", quest_db_connect);
                    sql.ExecuteNonQuery();
                    quest_db_connect.Close();
                    label_name.Text = rename.Text;
                    name = rename.Text;
                    label_name.BringToFront();
                }
                else if (edit_item == 1)
                {
                    if (int.Parse(rename.Text) < 10000)
                    {
                        SqlCommand sql = new SqlCommand($"UPDATE  items SET price ={int.Parse(rename.Text)} WHERE id={index} ", quest_db_connect);
                        sql.ExecuteNonQuery();
                        quest_db_connect.Close();
                        label_price.Text = rename.Text;
                        price = int.Parse(rename.Text);
                    }
                    else
                    {
                        SqlCommand sql = new SqlCommand($"UPDATE  items SET price =9999 WHERE id={index} ", quest_db_connect);
                        sql.ExecuteNonQuery();
                        quest_db_connect.Close();
                        label_price.Text = (9999).ToString();
                        price = 9999;
                    }
                    label_price.BringToFront();
                }
                rename.Dispose();               
            }
        }
        private void edit_set (object sender, EventArgs e)
        {
            if (edit_state && rename.Text != "")
            {
                edit_state = false;
                SqlConnection quest_db_connect;
                quest_db_connect = new SqlConnection();
                quest_db_connect.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|theQuest.mdf;" +
                     "Integrated Security=True";
                quest_db_connect.Open();
                if (edit_item == 0)
                {
                    SqlCommand sql = new SqlCommand($"UPDATE  items SET name=N'{rename.Text}' WHERE id={index} ", quest_db_connect);
                    sql.ExecuteNonQuery();
                    quest_db_connect.Close();
                    label_name.Text = rename.Text;
                    label_name.BringToFront();
                    name = rename.Text;
                }
                else if (edit_item == 1)
                {
                    if (int.Parse(rename.Text) < 10000)
                    {
                        SqlCommand sql = new SqlCommand($"UPDATE  items SET price ={int.Parse(rename.Text)} WHERE id={index} ", quest_db_connect);
                        sql.ExecuteNonQuery();
                        quest_db_connect.Close();
                        label_price.Text = rename.Text;
                        price = int.Parse(rename.Text);
                    }
                    else
                    {
                        SqlCommand sql = new SqlCommand($"UPDATE  items SET price =9999 WHERE id={index} ", quest_db_connect);
                        sql.ExecuteNonQuery();
                        quest_db_connect.Close();
                        label_price.Text = ( 9999 ).ToString();
                        price = 9999;
                    }
                    label_price.BringToFront();
                }
                rename.Dispose();
            }
        }

        public void select_info (object sender, EventArgs e)
        {           
            mshop.recolor();
            panel_index.BackColor = Color.Red;
            mshop.focus_index = index;
        }

        private void pictureBox1_DoubleClick (object sender, EventArgs e)
        {
            OpenFileDialog upload_pic = new OpenFileDialog();
            upload_pic.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png,*.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (upload_pic.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(upload_pic.FileName);
                file_path = upload_pic.FileName;
                // upload the path
                SqlConnection quest_db_connect;
                quest_db_connect = new SqlConnection();
                quest_db_connect.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|theQuest.mdf;" +
                     "Integrated Security=True";
                quest_db_connect.Open();
                SqlCommand sql = new SqlCommand($"UPDATE  items SET file_address=N'{file_path}' WHERE id={index} ", quest_db_connect);
                sql.ExecuteNonQuery();
                quest_db_connect.Close();
            }
        }
    }
}
