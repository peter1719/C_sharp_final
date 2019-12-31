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
       
    public partial class practiceForm : Form
    {

        string[] INFO = { "克西和一", "3", "20", "66", "80", "65", "67", "64", "99" };

        string[] GIFs = { "study.gif", "draw.gif", "piano.gif", "dance.gif", "fly.gif" };
        string[] ITEMs = { "韋編三絕", "妙手丹青", "繞樑三日", "翩翩起舞", "一飛衝天" }; 

        bool practicing = false;

        int timer_count = 0;  int minute = 0; int second = 0; int second_count = 0; int second_remainder = 0;

        public practiceForm()
        {
            InitializeComponent();
        }

        private void get_info()
        {
            INFO = Form1.mchar.status();
            return;
        }

        private void renew_info()
        {
            // 等級
            if (pgb_practice.Value == pgb_practice.Maximum)
            {
                pgb_practice.Value = 0;
                INFO[1] = (int.Parse(INFO[1]) + 1).ToString();
            }
            // 時數
            if (second == 0 && second_remainder == 0) INFO[2] = (int.Parse(INFO[2]) + minute).ToString();
            // 經驗值
            INFO[3] = pgb_practice.Value.ToString();
            INFO[4] = Form1.mchar.max_exp(int.Parse(INFO[1])).ToString();     
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
                practicing = true;
                timer_practice.Enabled = true;
                pgb_practice.Value = int.Parse(INFO[3]);
                pgb_practice.Maximum = int.Parse(INFO[4]);
                pbx_gif.Image = Image.FromFile(@"../../Resources/"+ GIFs[index]);
                pbx_gif.BackColor = SystemColors.ControlText;
                btn_end.Text = "停止修煉";
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
                practicing = false;
                timer_practice.Enabled = false;
                pbx_gif.Image = null;
                pbx_gif.BackColor = SystemColors.Control;
                btn_end.Text = "結束修煉";
            }
        }

        private void timer_practice_Tick(object sender, EventArgs e)
        {
            // Renew ProgressBar
            timer_practice.Interval = 250;
            pgb_practice.Value += 1;

            // Renew Timer
            timer_count += 1;
            second_count = timer_count / (1000 / timer_practice.Interval);
            second_remainder = timer_count % (1000 / timer_practice.Interval);
            minute = second_count / 60;
            second = second_count % 60;
            lb_time.Text = minute.ToString() + "分:" + second.ToString() + "秒";

            // Renew INFO
            renew_info();
            show_info();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            get_info();
            pbx_gif.Image = null;       
            pgb_practice.Value = int.Parse(INFO[3]);
            pgb_practice.Maximum = int.Parse(INFO[4]);
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
            Form1.mchar.set_all_properties(int.Parse(INFO[5]), int.Parse(INFO[7]), int.Parse(INFO[2]), int.Parse(INFO[8]), int.Parse(INFO[1]), int.Parse(INFO[6]), int.Parse(INFO[3]), INFO[0]);
        }

    }
}
