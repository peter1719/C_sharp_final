using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Media;

namespace final
{
       
    public partial class practiceForm : Form
    {
        ////////////////////////////////////////////////////////////////////// 宣告 //////////////////////////////////////////////////////////////////////

        // 修煉難度之分
        public int level = 0; // 簡單:0, 普通:1, 大師:2
        private string[] LEVELS = { "【簡單】", "【普通】", "【大師】" };
        private int[] INTERVALS = { 150, 300, 450 };
        private subMainQuest smq;

        // 角色資訊
        private string[] INFO = { "克西和一", "3", "20", "66", "80", "65", "67", "64", "99" };

        // 修煉動畫
        private int current_gif = -1;
        private string[] GIFs = { "study.gif", "draw.gif", "piano.gif", "dance.gif", "fly.gif" };
        private string[] ITEMs = { "韋編三絕", "妙手丹青", "繞樑三日", "翩翩起舞", "一飛衝天" };
        private string[] SOUNDs = { "study.mp3", "draw.mp3", "piano.mp3", "dance.mp3", "fly.mp3" };

        // 升級資訊 // 第一維:修煉動畫(index:0~4), 第二維:智力、體力、超能力、獎勵點數(index:0~3)
        int[,] UPDATES = { { 5, 2, 4, 1 }, { 4, 3, 3, 2 }, { 3, 3, 3, 3 }, { 2, 4, 2, 4 }, { 1, 1, 5, 5 } };
                            
        // 修煉中
        private bool practicing = false;

        // 計時器
        private int minute = 0; int second = 0;

        // 亂數
        Random ranobj = new Random();

        ////////////////////////////////////////////////////////////////////// 函式 //////////////////////////////////////////////////////////////////////

        public practiceForm(subMainQuest smq)
        {
            this.smq = smq;
            InitializeComponent();
        }

        private void get_info()
        {
            INFO = Form1.mchar.status();
            return;
        }

        private void upgrade()
        {
            // 智力、體力、超能力、獎勵點數
            for (int i = 5; i < 9; i++)
            {
                int value = Convert.ToInt32( (level + 1) * UPDATES[current_gif, (i - 5)] * 0.5 ); // 升級數值
                value += int.Parse(INFO[i]) + ranobj.Next(0, int.Parse(INFO[1])); // 升級數值 + 原本數值 + 隨機數值
                INFO[i] = value.ToString();
            }         
        }

        private void renew_info()
        {
            // 等級
            if (pgb_practice.Value == pgb_practice.Maximum)
            {
                pgb_practice.Value = 0;
                INFO[1] = ( int.Parse(INFO[1]) + 1 ).ToString();
                upgrade();
            }

            // 時數
            if (second == 60)
            {
                INFO[2] = (int.Parse(INFO[2]) + 1).ToString();
                second = 0;
            }                

            // 經驗值
            INFO[3] = pgb_practice.Value.ToString();
            INFO[4] = Form1.mchar.max_exp(int.Parse(INFO[1])).ToString(); pgb_practice.Maximum = int.Parse(INFO[4]);

        }

        private void show_info()
        {           
            lb_name.Text = "名稱: " + INFO[0];
            lb_grade.Text = "等級: " + INFO[1];
            lb_hours.Text = "時數: " + INFO[2] + "分鐘";
            lb_experience.Text = "經驗值: " + INFO[3] + "/" + INFO[4];
            lb_wit.Text = "智力: " + INFO[5];
            lb_strength.Text = "體力: " + INFO[6];
            lb_superpower.Text = "超能力: " + INFO[7];
            lb_bonus.Text = "獎勵點數: " + INFO[8];
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            // Get index of ComboBox
            int index = cbb_practice.SelectedIndex;

            // Start Practice
            if (practicing == false && index  != -1)
            {
                current_gif = index;
                practicing = true;
                timer_practice.Enabled = true;
                timer_watch.Enabled = true;
                pgb_practice.Value = int.Parse(INFO[3]);
                pgb_practice.Maximum = int.Parse(INFO[4]);
                pbx_gif.Image = Image.FromFile(@"../../Resources/"+ GIFs[index]);
                pbx_gif.BackColor = SystemColors.ControlText;
                lb_hint.Visible = false;
                btn_end.Text = "停止修煉";
                cbb_practice.Enabled = false;
                SoundPlayer player = new SoundPlayer(@"../../Resources/Music" + SOUNDs[index]);   // 使用完整檔名建立物件
                player.PlayLooping();　　　　　　　　                 // 重複播放
            }
            else if (practicing == true)
            {
                MessageBox.Show("修煉正在進行中", "貼心提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (index == -1)
            {
                MessageBox.Show("尚未點選修煉項目", "貼心提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            if (practicing == false)
            {
                this.Close();
            }
            else
            {
                //save the status
                smq.engage_time += minute;
                Form1.mchar.set_all_properties(int.Parse(INFO[5]), int.Parse(INFO[7]), int.Parse(INFO[2]), int.Parse(INFO[8]), int.Parse(INFO[1]), int.Parse(INFO[6]), int.Parse(INFO[3]), INFO[0]);
                Form1.mchar.write_pros_file();
                db_sub_quest_save();
                //engage time update
                INFO[2] = ( int.Parse(INFO[2]) + minute ).ToString();
                lb_hours.Text = "時數: " + INFO[2] + "分鐘";
                second = 0;//set the time to 0
                minute = 0;
                //
                practicing = false;
                timer_practice.Enabled = false;
                timer_watch.Enabled = false;
                pbx_gif.Image = null;
                pbx_gif.BackColor = Color.DimGray;
                lb_hint.Visible = true;
                btn_end.Text = "結束修煉";
                cbb_practice.Enabled = true;
                SoundPlayer player = new SoundPlayer(@"../../Resources/Music" + SOUNDs[cbb_practice.SelectedIndex]);
                player.Stop();
            }
        }


        private void timer_watch_Tick(object sender, EventArgs e)
        {
            // Renew Watch
            second += 1;
            if (second == 60)
            {
                minute += 1;
                INFO[8] = (int.Parse(INFO[8]) + 1).ToString();
            }           
            lb_time.Text = minute.ToString() + "分:" + second.ToString() + "秒";

            // Take a rest
            if (minute >= 45) take_rest();

        }

        private void timer_practice_Tick(object sender, EventArgs e)
        {
            // Renew ProgressBar
            timer_practice.Interval = INTERVALS[level];
            pgb_practice.Value += 1;
            
            // Renew INFO
            renew_info();
            show_info();
        }
        private void take_rest ()
        {
            //save the status
            smq.engage_time += minute;
            Form1.mchar.set_all_properties(int.Parse(INFO[5]), int.Parse(INFO[7]), int.Parse(INFO[2]), int.Parse(INFO[8]), int.Parse(INFO[1]), int.Parse(INFO[6]), int.Parse(INFO[3]), INFO[0]);
            Form1.mchar.write_pros_file();
            db_sub_quest_save();
            //engage time update
            INFO[2] = ( int.Parse(INFO[2]) + minute ).ToString();
            lb_hours.Text = "時數: " + INFO[2] + "分鐘";
            //stop the counter
            second = 0;//set the time to 0
            minute = 0;
            practicing = false;
            timer_practice.Enabled = false;
            timer_watch.Enabled = false;
            pbx_gif.Image = null;
            pbx_gif.BackColor = SystemColors.Control;
            lb_hint.Visible = true;
            btn_end.Text = "結束修煉";            
            MessageBox.Show("休息是為了走更長遠的路，每45分鐘就要休息一下喔!", "貼心提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            groupBox1.Text = "修煉狀態" + LEVELS[level];
            lb_hint.Text = "請點選修煉項目";
            get_info();
            pbx_gif.Image = null;
            pgb_practice.Maximum = int.Parse(INFO[4]);
            pgb_practice.Value = int.Parse(INFO[3]);
            pgb_practice.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            lb_time.Text = minute.ToString() + "分 : " + second.ToString() + "秒";
            show_info();
        }

        private void cbb_practice_Click(object sender, EventArgs e)
        {
            cbb_practice.Items.Clear();
            cbb_practice.Items.AddRange(ITEMs);
        }

        private void practiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.on_training = false;
            smq.engage_time += minute;
            //engage time update
            INFO[2] = ( int.Parse(INFO[2]) + minute ).ToString();
            Form1.mchar.set_all_properties(int.Parse(INFO[5]), int.Parse(INFO[7]), int.Parse(INFO[2]), int.Parse(INFO[8]), int.Parse(INFO[1]), int.Parse(INFO[6]), int.Parse(INFO[3]), INFO[0]);
            Form1.mchar.write_pros_file();
            db_sub_quest_save();
        }
        private void db_sub_quest_save ()
        {
            SqlConnection quest_db_connect;
            quest_db_connect = new SqlConnection();
            quest_db_connect.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|theQuest.mdf;" +
                 "Integrated Security=True";
            quest_db_connect.Open();
            SqlCommand sql = new SqlCommand($"UPDATE  sub_quest SET time= {smq.engage_time} WHERE db_index = {smq.getindex()}", quest_db_connect);
            sql.ExecuteNonQuery();
            quest_db_connect.Close();
        }
    }
}
