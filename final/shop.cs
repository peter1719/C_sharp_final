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
    public partial class shop : UserControl
    {
        private int _reward;
        private List<item> items = new List<item>();
        SqlConnection quest_db_connect;
        public int focus_index = -1;

        public int reward
        {                                 
            set
            {
                _reward = value;
                label_reward.Text = "剩餘獎勵: " + value.ToString();
            }
        }
        public shop ()
        {
            quest_db_connect = new SqlConnection();
            quest_db_connect.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|theQuest.mdf;" +
                 "Integrated Security=True";
            InitializeComponent();
        }
        private void db_init ()
        {           
            flp.Controls.Clear();
            quest_db_connect.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter db_quest = new SqlDataAdapter
                                        ("SELECT *  FROM  items", quest_db_connect);
            db_quest.Fill(ds);
            foreach (DataRow datarow in ds.Tables[0].Rows)
            {
                //id name price number address
                item temp = new item(this);
                temp.index = (int)datarow[0];
                temp.name = datarow[1].ToString();
                temp.price = (int)datarow[2];
                temp.bought_number = (int)datarow[3];
                temp.file_path = datarow[4].ToString();
                temp.re_info();
                items.Add(temp);
                if (flp.Controls.Count < 0)
                    flp.Controls.Clear();
                else
                    flp.Controls.Add(temp);
            }
            quest_db_connect.Close();
        }
        private void shop_Load (object sender, EventArgs e)
        {
            db_init();
        }

        private void btn_buy_Click (object sender, EventArgs e)
        {
            if (focus_index == -1)
            {
                MessageBox.Show("尚未點選項目", "貼心提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (item_find_by_index(focus_index).price > _reward)
            {
                MessageBox.Show("餘額不足", "貼心提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            item_find_by_index(focus_index).bought_number = item_find_by_index(focus_index).bought_number + 1;
            item_find_by_index(focus_index).re_info();
            reward = _reward - item_find_by_index(focus_index).price;
            quest_db_connect.Open();
            SqlCommand sql = new SqlCommand($"UPDATE  items SET bought_number = { item_find_by_index(focus_index).bought_number} WHERE id={focus_index} ", quest_db_connect);
            sql.ExecuteNonQuery();
            quest_db_connect.Close();
            Form1.mchar.set_reard(_reward);
        }
        public void recolor ()
        {
            foreach (item i in items)
            {
                i.panel.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void btn_add_Click (object sender, EventArgs e)
        {
            //id name price number address
            quest_db_connect.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter db_quest = new SqlDataAdapter
                                        ($"INSERT INTO  items(name,price,bought_number) OUTPUT INSERTED.id VALUES(N'按下重新命名...',1,0)", quest_db_connect);
            db_quest.Fill(ds);
            int return_index = (int)( ds.Tables[0].Rows[0][0] );
            quest_db_connect.Close();
            //add new main Quest
            item temp = new item(this);
            temp.index = return_index;
            temp.name = "按下重新命名...";
            temp.price = 1;
            temp.bought_number = 0;
            temp.file_path = "";
            temp.re_info();
            items.Add(temp);
            if (flp.Controls.Count < 0)
                flp.Controls.Clear();
            else
                flp.Controls.Add(temp);
        }

        private void btn_delete_Click (object sender, EventArgs e)
        {
            if (focus_index != -1)
            {
                flp.Controls.Clear();
                flp.Controls.Clear();
                //delete it from database
                quest_db_connect.Open();
                SqlCommand sql = new SqlCommand($"DELETE   FROM items WHERE id={focus_index} ", quest_db_connect);
                sql.ExecuteNonQuery();                
                quest_db_connect.Close();
                for (int i = items.Count - 1; i >= 0; i--)//remove the item in backward
                {
                    if (items[i].index == focus_index)
                    {
                        items.Remove(items[i]);
                        break;
                    }
                }
                foreach (item i in items)
                {
                    if (flp.Controls.Count < 0)
                        flp.Controls.Clear();
                    else
                        flp.Controls.Add(i);
                }
            }
            focus_index = -1;
        }

        private item item_find_by_index (int index)
        {
            foreach (item i in items)
            {
                if (i.index == focus_index)
                {
                    return i;
                }
            }
            return null;
        }

    }
}
