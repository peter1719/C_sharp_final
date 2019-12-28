namespace final
{
    partial class practiceForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pgb_practice = new System.Windows.Forms.ProgressBar();
            this.timer_practice = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_time = new System.Windows.Forms.Label();
            this.cbb_practice = new System.Windows.Forms.ComboBox();
            this.btn_end = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_superpower = new System.Windows.Forms.Label();
            this.lb_strength = new System.Windows.Forms.Label();
            this.lb_wit = new System.Windows.Forms.Label();
            this.lb_bonus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_experience = new System.Windows.Forms.Label();
            this.lb_hours = new System.Windows.Forms.Label();
            this.lb_grade = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.pbx_gif = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // pgb_practice
            // 
            this.pgb_practice.BackColor = System.Drawing.SystemColors.Control;
            this.pgb_practice.ForeColor = System.Drawing.Color.Cyan;
            this.pgb_practice.Location = new System.Drawing.Point(37, 351);
            this.pgb_practice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgb_practice.Name = "pgb_practice";
            this.pgb_practice.Size = new System.Drawing.Size(376, 30);
            this.pgb_practice.TabIndex = 3;
            this.pgb_practice.Value = 40;
            // 
            // timer_practice
            // 
            this.timer_practice.Interval = 25;
            this.timer_practice.Tick += new System.EventHandler(this.timer_practice_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.lb_time);
            this.groupBox1.Controls.Add(this.cbb_practice);
            this.groupBox1.Controls.Add(this.btn_end);
            this.groupBox1.Controls.Add(this.pbx_gif);
            this.groupBox1.Controls.Add(this.pgb_practice);
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(445, 476);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修煉狀態";
            // 
            // lb_time
            // 
            this.lb_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lb_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_time.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_time.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_time.Location = new System.Drawing.Point(264, 50);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(149, 40);
            this.lb_time.TabIndex = 6;
            this.lb_time.Text = "0分 : 0秒";
            this.lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbb_practice
            // 
            this.cbb_practice.BackColor = System.Drawing.Color.DimGray;
            this.cbb_practice.ForeColor = System.Drawing.SystemColors.Control;
            this.cbb_practice.FormattingEnabled = true;
            this.cbb_practice.Location = new System.Drawing.Point(37, 50);
            this.cbb_practice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_practice.Name = "cbb_practice";
            this.cbb_practice.Size = new System.Drawing.Size(148, 39);
            this.cbb_practice.TabIndex = 5;
            this.cbb_practice.Text = "修煉選單";
            this.cbb_practice.Click += new System.EventHandler(this.cbb_practice_Click);
            // 
            // btn_end
            // 
            this.btn_end.BackColor = System.Drawing.SystemColors.Control;
            this.btn_end.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_end.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_end.Image = global::final.Properties.Resources.wood_stop;
            this.btn_end.Location = new System.Drawing.Point(264, 408);
            this.btn_end.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(149, 49);
            this.btn_end.TabIndex = 4;
            this.btn_end.Text = "結束修煉";
            this.btn_end.UseVisualStyleBackColor = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(475, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(309, 476);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "角色狀態";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lb_superpower);
            this.panel2.Controls.Add(this.lb_strength);
            this.panel2.Controls.Add(this.lb_wit);
            this.panel2.Controls.Add(this.lb_bonus);
            this.panel2.Location = new System.Drawing.Point(21, 255);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 200);
            this.panel2.TabIndex = 9;
            // 
            // lb_superpower
            // 
            this.lb_superpower.BackColor = System.Drawing.Color.DarkOrchid;
            this.lb_superpower.Location = new System.Drawing.Point(27, 106);
            this.lb_superpower.Name = "lb_superpower";
            this.lb_superpower.Size = new System.Drawing.Size(193, 30);
            this.lb_superpower.TabIndex = 9;
            this.lb_superpower.Text = "超能力: 68";
            this.lb_superpower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_strength
            // 
            this.lb_strength.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lb_strength.Location = new System.Drawing.Point(27, 59);
            this.lb_strength.Name = "lb_strength";
            this.lb_strength.Size = new System.Drawing.Size(193, 30);
            this.lb_strength.TabIndex = 8;
            this.lb_strength.Text = "體力: 63";
            this.lb_strength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_wit
            // 
            this.lb_wit.BackColor = System.Drawing.Color.DodgerBlue;
            this.lb_wit.Location = new System.Drawing.Point(27, 12);
            this.lb_wit.Name = "lb_wit";
            this.lb_wit.Size = new System.Drawing.Size(193, 30);
            this.lb_wit.TabIndex = 7;
            this.lb_wit.Text = "智力: 65";
            this.lb_wit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_bonus
            // 
            this.lb_bonus.BackColor = System.Drawing.Color.DeepPink;
            this.lb_bonus.Location = new System.Drawing.Point(27, 150);
            this.lb_bonus.Name = "lb_bonus";
            this.lb_bonus.Size = new System.Drawing.Size(193, 30);
            this.lb_bonus.TabIndex = 4;
            this.lb_bonus.Text = "獎勵點數: 100";
            this.lb_bonus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lb_experience);
            this.panel1.Controls.Add(this.lb_hours);
            this.panel1.Controls.Add(this.lb_grade);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Location = new System.Drawing.Point(21, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 199);
            this.panel1.TabIndex = 8;
            // 
            // lb_experience
            // 
            this.lb_experience.BackColor = System.Drawing.Color.LimeGreen;
            this.lb_experience.Location = new System.Drawing.Point(27, 155);
            this.lb_experience.Name = "lb_experience";
            this.lb_experience.Size = new System.Drawing.Size(193, 30);
            this.lb_experience.TabIndex = 6;
            this.lb_experience.Text = "經驗值: 87/88";
            this.lb_experience.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_hours
            // 
            this.lb_hours.BackColor = System.Drawing.Color.Yellow;
            this.lb_hours.Location = new System.Drawing.Point(27, 108);
            this.lb_hours.Name = "lb_hours";
            this.lb_hours.Size = new System.Drawing.Size(193, 30);
            this.lb_hours.TabIndex = 4;
            this.lb_hours.Text = "時數: 84分鐘";
            this.lb_hours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_grade
            // 
            this.lb_grade.BackColor = System.Drawing.Color.Orange;
            this.lb_grade.Location = new System.Drawing.Point(27, 61);
            this.lb_grade.Name = "lb_grade";
            this.lb_grade.Size = new System.Drawing.Size(193, 30);
            this.lb_grade.TabIndex = 3;
            this.lb_grade.Text = "等級: 5";
            this.lb_grade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_name
            // 
            this.lb_name.BackColor = System.Drawing.Color.Coral;
            this.lb_name.Location = new System.Drawing.Point(27, 15);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(193, 30);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "名稱: 克西和夫";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbx_gif
            // 
            this.pbx_gif.BackColor = System.Drawing.SystemColors.Control;
            this.pbx_gif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbx_gif.Location = new System.Drawing.Point(37, 114);
            this.pbx_gif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbx_gif.Name = "pbx_gif";
            this.pbx_gif.Size = new System.Drawing.Size(375, 209);
            this.pbx_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_gif.TabIndex = 0;
            this.pbx_gif.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.Control;
            this.btn_start.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_start.Image = global::final.Properties.Resources.wood_start;
            this.btn_start.Location = new System.Drawing.Point(37, 408);
            this.btn_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(149, 49);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "開始修煉";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // practiceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(799, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "practiceForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.practiceForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_gif;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ProgressBar pgb_practice;
        private System.Windows.Forms.Timer timer_practice;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_bonus;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.ComboBox cbb_practice;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_hours;
        private System.Windows.Forms.Label lb_grade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_strength;
        private System.Windows.Forms.Label lb_wit;
        private System.Windows.Forms.Label lb_experience;
        private System.Windows.Forms.Label lb_superpower;
    }
}

