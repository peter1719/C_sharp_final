using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace final
{
    public partial class mainChar : UserControl
    {
        bool edit_state = false;
        TextBox rename;
        private string name = "克西和夫";
        private int EXEbase = 2;
        private int wisdom = 0;
        private int ESP = 0;
        private int time = 0;
        private int reward = 0;
        private int level = 1;
        private int energy = 0;
        private int exe = 0;
        private int max_exe = 0;

        public void set_all_properties (int _wisdom,int _ESP,int _time,int _reward,int _level,int _energy,
            int _exe,string _name)
        {
            wisdom = _wisdom;
            label_wisdom.Text = "智力: " + wisdom.ToString(); 
            ESP = _ESP;
            label_ESP.Text = "超能力: " + ESP.ToString();
            time = _time;
            label_time.Text = "時數: " + time.ToString() + "分鐘";
            reward = _reward;
            label_reward.Text = "獎勵點數: " + reward.ToString();
            level = _level;
            label_level.Text = "等級: " + level.ToString();
            energy = _energy;
            label_energy.Text = "體力: " + energy.ToString();
            exe = _exe;
            max_exe = (int)(Math.Pow(level, EXEbase)- Math.Pow(level - 1, EXEbase) ) * 10;
            label_exe.Text = "經驗值: " +exe.ToString() + "/" + max_exe.ToString();
            name = _name;
            label_name.Text = name;
        }
        private void set_pros ()
        {
            label_wisdom.Text = "智力: " + wisdom.ToString();
            label_ESP.Text = "超能力: " + ESP.ToString();
            label_time.Text = "時間: " + time.ToString() + " 分鐘";
            label_reward.Text = "獎勵點數: " + reward.ToString();
            label_level.Text = "等級: " + level.ToString();
            label_energy.Text = "體力: " + energy.ToString();
            max_exe = (int)( Math.Pow(level, EXEbase) - Math.Pow(level - 1, EXEbase) ) * 10;
            label_exe.Text = "經驗值: " + exe.ToString() + "/" + max_exe.ToString();
            label_name.Text = name;
        }
        public string char_pros ()
        {
            string temp = wisdom.ToString() + "," + ESP.ToString() + "," + time.ToString() + "," + reward.ToString()
             + "," + level.ToString() + "," + energy.ToString() + "," + exe.ToString() + "," + name;
            return temp;
        }

        public int max_exp(int level)
        {
            return (int)(Math.Pow(level, EXEbase) - Math.Pow(level - 1, EXEbase)) * 10;
        }
        public string[] status()
        {
            string[] temp = { name, level.ToString(), time.ToString(), exe.ToString(), max_exe.ToString(), wisdom.ToString(),
                                            energy.ToString(), energy.ToString(), ESP.ToString(), reward.ToString() };
            return temp;
        }
        public int get_reward ()
        {
            return reward;
        }
        public void set_reard (int reward)
        {
            this.reward = reward;
            label_reward.Text = "獎勵點數: " + reward.ToString();
            write_pros_file();
        }
        public mainChar ()
        {
            InitializeComponent();
            // label_name.Text = "克西和夫";
        }

        private void mainChar_Load (object sender, EventArgs e)
        {
            this.Click += new EventHandler(edit_set);
            foreach (Control c in Controls)
            {
                c.Click += new EventHandler(edit_set);
            }
        }

        private void pictureBox1_DoubleClick (object sender, EventArgs e)
        {
            OpenFileDialog upload_Avatar = new OpenFileDialog();
            upload_Avatar.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png,*.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (upload_Avatar.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(upload_Avatar.FileName);
            }            
        }

        private void label_name_DoubleClick (object sender, EventArgs e)
        {
            rename = new TextBox();
            rename.Location = label_name.Location;
            rename.Width = label_name.Width;
            rename.Height = label_name.Height;
            rename.Text = label_name.Text;
            panel_name.Controls.Add(rename);
            rename.BringToFront();
            rename.KeyDown += new KeyEventHandler(this.rename_Enter);
            rename.Focus();
            edit_state = true;
        }
        public void write_pros_file ()
        {
            FileInfo finfo = new FileInfo(@"../../Resources/status.txt");
            StreamWriter sw = finfo.CreateText();
            sw.Write(char_pros());
            sw.Flush();
            sw.Close();
        }
        public void read_pros_file ()
        {
            string path = @"../../Resources/status.txt";
            FileInfo finfo = new FileInfo(path);
            if (finfo.Exists)
            {
                StreamReader sr =  new StreamReader(path);
                string data = sr.ReadLine();
                string [] datas = data.Split(',');
                set_all_properties(int.Parse( datas[0]),int.Parse( datas[1]), int.Parse(datas[2]), int.Parse(datas[3]), 
                    int.Parse(datas[4]),int.Parse( datas[5]),int.Parse( datas[6]),datas[7]);
                sr.Close();
            }

        }
        private void rename_Enter (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && rename.Text != "")
            {
                label_name.Text = rename.Text;
                name = rename.Text;
               rename.Dispose();
                label_name.BringToFront();
                edit_state = false;
                write_pros_file();
            }
        }
        private void edit_set (object sender, EventArgs e)
        {
            if (edit_state &&  rename.Text != "")
            {
                label_name.Text =rename.Text;
                name = rename.Text;
                rename.Dispose();
                label_name.BringToFront();
                edit_state =false;
                write_pros_file();
            }
        }
    }
}
