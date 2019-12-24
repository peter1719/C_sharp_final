﻿using System;
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
    public partial class mQuestInfo : UserControl
    {
        private mainQuest _mq;
        public List<subMainQuest> easy_quest;
        public List<subMainQuest> normal_quest;
        public List<subMainQuest> hard_quest;
        public List<List<subMainQuest>> list_quests;
        public int level_select = 0;
        public int focus_index = -1;

        private int index = 0;
        public void setmq ( mainQuest mq)
        {
            _mq = mq;
        }
        public void setindex (int _index)
        {
            index = _index;
        }
        public mQuestInfo ()
        {
            easy_quest = new List<subMainQuest>();
            normal_quest = new List<subMainQuest>();
            hard_quest = new List<subMainQuest>();
            list_quests = new List<List<subMainQuest>>();
            list_quests.Add(easy_quest);
            list_quests.Add(normal_quest);
            list_quests.Add(hard_quest);
            InitializeComponent();
        }
        public Panel panel
        {
            get
            {
                return panel1;
            }
            set
            {
                panel1 = value;
            }
        }
        private void mQuestInfo_Load (object sender, EventArgs e)
        {

        }

        #region Properties
        private string _quest_name;
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
                label_quest.Text = _quest_name;
            }
        }

        #endregion

        

        private void mQuestInfo_Click (object sender, EventArgs e)
        {
            select_info();
            load_sub_quest(easy_quest, 0);
        }
        private void btn_easy_Click (object sender, EventArgs e)
        {
            select_info();
            load_sub_quest(easy_quest, 0);
            focus_index = -1;
            recolor_sub_quest();
        }
        private void btn_normall_Click (object sender, EventArgs e)
        {
            select_info();
            load_sub_quest(normal_quest, 1);
            focus_index = -1;
            recolor_sub_quest();
        }

        private void btn_master_Click (object sender, EventArgs e)
        {
            select_info();
            load_sub_quest(hard_quest, 2);
            focus_index = -1;
            recolor_sub_quest();
        }
        public void select_info ()
        {
            _mq.recolor();
            panel1.BackColor = Color.Red;
            _mq.focus_index = index;

        }
        public void load_sub_quest (List<subMainQuest> smq, int level)
        {
            level_select = level;
            _mq.load_sub_quest(smq, level);
        }

        public void recolor_sub_quest ()
        {
            for (int i = 0; i < list_quests[level_select].Count; i++)
            {
                list_quests[level_select][i].panelindicator.BackColor = Color.FromArgb(192, 255, 192);
            }
        }

        public void remove_sub ()
        {
            if (focus_index != -1 && level_select != -1 && list_quests[level_select].Count >0)
            {
                list_quests[level_select].RemoveAt(focus_index);
                for (int i = 0; i < list_quests[level_select].Count; i++)
                {
                    list_quests[level_select][i].setindex(i);
                }
            }
            focus_index = -1;
        }

        private void label_quest_DoubleClick (object sender, EventArgs e)
        {
            TextBox rename = new TextBox();
            rename.Location = label_quest.Location;
            rename.Width = this.Width/2;
            rename.Height = label_quest.Height;
            rename.Text = label_quest.Text;
            this.Controls.Add(rename);
            rename.BringToFront();
            rename.KeyDown += new KeyEventHandler(this.rename_Enter);
        }

        private void rename_Enter (object sender, KeyEventArgs e)
        {
            TextBox text = sender as TextBox;
            if (e.KeyCode == Keys.Enter && text.Text != "")
            {
                label_quest.Text = text.Text;
                text.Dispose();
                label_quest.BringToFront();
            }
        }
    }
}
