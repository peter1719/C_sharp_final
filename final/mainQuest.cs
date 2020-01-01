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
    public partial class mainQuest : UserControl
    {
        public List<mQuestInfo> mQuests = new List<mQuestInfo>();
        public int focus_index = -1;
        public int level_select = -1;
        SqlConnection quest_db_connect;
       
        public mainQuest ()
        {
            InitializeComponent();
        }

        private void mainQuest_Load (object sender, EventArgs e)
        {
            init();
            load_main_quest();
        }
        private void init ()
        {
            quest_db_connect = new SqlConnection();
            quest_db_connect.ConnectionString =   @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|theQuest.mdf;" +
                 "Integrated Security=True";
        }

        private void load_main_quest ()
        {
            flp_left.Controls.Clear();
            quest_db_connect.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter db_quest = new SqlDataAdapter
                                        ("SELECT *  FROM  main_quest", quest_db_connect);
            db_quest.Fill(ds);
            foreach (DataRow datarow in ds.Tables[0].Rows)
            {
                mQuestInfo temp = new mQuestInfo();
                temp.quest_name = datarow[1].ToString();//name
                temp.setmq(this);//set the main quest
                temp.setindex((int)datarow[0]);//add db index of the quest
                temp.db_sub_quest();//load sub quest
                mQuests.Add(temp);
               
                if (flp_left.Controls.Count < 0)
                    flp_left.Controls.Clear();
                else
                    flp_left.Controls.Add(temp);
                //datarow[2] //user
            }
            quest_db_connect.Close();           
        }
       

        public void recolor ()
        {
            //to clear the red color 
            foreach (mQuestInfo m in mQuests)
            {
                m.button_easy.BackColor = Color.White;
                m.button_normall.BackColor = Color.White;
                m.button_master.BackColor = Color.White;
                m.panel.BackColor = SystemColors.ActiveCaption;              
            }
        }

        public void load_sub_quest (List<subMainQuest> smq, int level)
        {
            level_select = level;
            flp_right.Controls.Clear();
            for (int i = 0; i < smq.Count; i++)
            {
                if (flp_right.Controls.Count < 0)
                    flp_right.Controls.Clear();
                else
                    flp_right.Controls.Add(smq[i]);
            }
        }


        private void btn_add_Click (object sender, EventArgs e)
        {
            quest_db_connect.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter db_quest = new SqlDataAdapter
                                        ($"INSERT INTO  main_quest(name) OUTPUT INSERTED.id VALUES(N'按下重新命名...')", quest_db_connect);
            db_quest.Fill(ds);
            int return_index  = (int)(ds.Tables[0].Rows[0][0]);
            quest_db_connect.Close();
            //add new main Quest
            mQuestInfo temp = new mQuestInfo();
            //initial main Quest properties
            temp.quest_name = "按下重新命名...";
            temp.setmq(this);
            temp.setindex(return_index);
            mQuests.Add(temp);
            if (flp_left.Controls.Count < 0)
                flp_left.Controls.Clear();
            else
                flp_left.Controls.Add(temp);
        }

        private void btn_delete_Click (object sender, EventArgs e)
        {
            if (focus_index != -1)
            {                
                flp_left.Controls.Clear();
                flp_right.Controls.Clear();
                //delete it from database
                quest_db_connect.Open();
                SqlCommand sql = new SqlCommand($"DELETE   FROM main_quest WHERE id={focus_index} ", quest_db_connect);
                sql.ExecuteNonQuery();
                SqlCommand sql2 = new SqlCommand($"DELETE   FROM sub_quest WHERE id={focus_index} ", quest_db_connect);
                sql2.ExecuteNonQuery();
                quest_db_connect.Close();
                for (int i = mQuests.Count - 1 ; i >= 0; i--)//remove the item in backward
                {
                    if (mQuests[i].getindex() == focus_index)
                    {
                        mQuests.Remove(mQuests[i]);
                        break;
                    }
                }
                foreach (mQuestInfo m in mQuests)
                {
                    if (flp_left.Controls.Count < 0)
                        flp_left.Controls.Clear();
                    else
                        flp_left.Controls.Add(m);
                }
            }
            focus_index = -1;
            level_select = -1;
        }

        private void btn_add_sub_Click (object sender, EventArgs e)
        {
            if (level_select == -1 || focus_index == -1)
                return;
            quest_db_connect.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter db_quest = new SqlDataAdapter
                                        ($"INSERT INTO sub_quest(id,name,level,time) OUTPUT INSERTED.db_index VALUES ({focus_index},N'按下重新命名...',{level_select},0) ", quest_db_connect);
            db_quest.Fill(ds);
            int return_index = (int)( ds.Tables[0].Rows[0][0] );
            quest_db_connect.Close();
            //creat a temp sub main quest           
            subMainQuest temp = new subMainQuest(level_select, info_find_by_index(focus_index));
            temp.quest_name = "按下重新命名...";
            temp.engage_time = 0;
            temp.setindex(return_index);
            info_find_by_index(focus_index).list_quests[level_select].Add(temp);
            load_sub_quest(info_find_by_index(focus_index).list_quests[level_select],level_select);           
        }

        private void btn_delete_sub_Click (object sender, EventArgs e)
        {
            if (focus_index == -1 || level_select == -1)
                return;
            info_find_by_index(focus_index).remove_sub();
            flp_right.Controls.Clear();
            for (int i = 0; i < info_find_by_index(focus_index).list_quests[level_select].Count; i++)
            {
                flp_right.Controls.Add(info_find_by_index(focus_index).list_quests[level_select][i]);
            }
        }
        private mQuestInfo info_find_by_index (int index)
        {
            foreach (mQuestInfo m in mQuests)
            {
                if (m.getindex() == focus_index)
                {
                    return m;
                }               
            }
            return null;
        }
    }
}
