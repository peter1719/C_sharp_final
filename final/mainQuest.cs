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
    public partial class mainQuest : UserControl
    {
        public List<mQuestInfo> mQuests = new List<mQuestInfo>();
        public int focus_index = -1;
        public int level_select = -1;
       
        public mainQuest ()
        {
            InitializeComponent();
        }

        private void mainQuest_Load (object sender, EventArgs e)
        {
            //creat some temp to demo
            for (int i = 0; i < 10; i++)
            {
                mQuestInfo temp = new mQuestInfo();
                temp.quest_name =(i+1).ToString();
                temp.setmq(this);
                temp.setindex(i);
                mQuests.Add(temp);
                if (flp_left.Controls.Count < 0)
                    flp_left.Controls.Clear();
                else
                    flp_left.Controls.Add(temp);
            }
        }

        public void recolor ()
        {
            //to clear the red color 
            for (int i = 0; i < mQuests.Count; i++)
            {
                mQuests[i].panel.BackColor = SystemColors.ActiveCaption;              
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
            //add new main Quest
            mQuestInfo temp = new mQuestInfo();
            //initial main Quest properties
            temp.quest_name = mQuests.Count.ToString();
            temp.setmq(this);
            temp.setindex(mQuests.Count - 1);
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
                mQuests.RemoveAt(focus_index);

                flp_left.Controls.Clear();
                for (int i = 0; i < mQuests.Count ; i++)
                {
                    mQuests[i].setindex(i);
                    flp_left.Controls.Add(mQuests[i]);
                }
                flp_right.Controls.Clear();
            }
            focus_index = -1;
            level_select = -1;

        }

        private void btn_add_sub_Click (object sender, EventArgs e)
        {
            if (level_select == -1 || focus_index == -1)
                return;
            //creat a temp sub main quest           
            subMainQuest temp = new subMainQuest(2, mQuests[focus_index]);
            temp.quest_name = "重新命名...";
            temp.engage_time = 0;
            temp.setindex(mQuests[focus_index].list_quests[level_select].Count);
            mQuests[focus_index].list_quests[level_select].Add(temp);
            load_sub_quest(mQuests[focus_index].list_quests[level_select],level_select);           
        }

        private void btn_delete_sub_Click (object sender, EventArgs e)
        {
            if (focus_index == -1 || level_select == -1)
                return;
            mQuests[focus_index].remove_sub();
            flp_right.Controls.Clear();
            for (int i = 0; i < mQuests[focus_index].list_quests[level_select].Count; i++)
            {
                flp_right.Controls.Add(mQuests[focus_index].list_quests[level_select][i]);
            }
        }

    }
}
