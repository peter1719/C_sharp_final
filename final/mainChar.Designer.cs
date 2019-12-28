namespace final
{
    partial class mainChar
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent ()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.label_exe = new System.Windows.Forms.Label();
            this.label_reward = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_ESP = new System.Windows.Forms.Label();
            this.label_energy = new System.Windows.Forms.Label();
            this.label_wisdom = new System.Windows.Forms.Label();
            this.panel_ability = new System.Windows.Forms.Panel();
            this.panel_name = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_ability.SuspendLayout();
            this.panel_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.Image = global::final.Properties.Resources._char;
            this.pictureBox1.Location = new System.Drawing.Point(73, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.edit_set);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "名稱:";
            this.label1.Click += new System.EventHandler(this.edit_set);
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_level.Location = new System.Drawing.Point(12, 60);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(87, 30);
            this.label_level.TabIndex = 3;
            this.label_level.Text = "等級: 5";
            this.label_level.Click += new System.EventHandler(this.edit_set);
            // 
            // label_exe
            // 
            this.label_exe.AutoSize = true;
            this.label_exe.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exe.Location = new System.Drawing.Point(12, 160);
            this.label_exe.Name = "label_exe";
            this.label_exe.Size = new System.Drawing.Size(163, 30);
            this.label_exe.TabIndex = 4;
            this.label_exe.Text = "經驗值: 87/88";
            this.label_exe.Click += new System.EventHandler(this.edit_set);
            // 
            // label_reward
            // 
            this.label_reward.AutoSize = true;
            this.label_reward.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reward.Location = new System.Drawing.Point(16, 160);
            this.label_reward.Name = "label_reward";
            this.label_reward.Size = new System.Drawing.Size(163, 30);
            this.label_reward.TabIndex = 6;
            this.label_reward.Text = "獎勵點數: 100";
            this.label_reward.Click += new System.EventHandler(this.edit_set);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(12, 110);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(149, 30);
            this.label_time.TabIndex = 7;
            this.label_time.Text = "時數: 87分鐘";
            this.label_time.Click += new System.EventHandler(this.edit_set);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(66, 10);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(109, 30);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "克西和夫";
            this.label_name.DoubleClick += new System.EventHandler(this.label_name_DoubleClick);
            // 
            // label_ESP
            // 
            this.label_ESP.AutoSize = true;
            this.label_ESP.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ESP.Location = new System.Drawing.Point(16, 110);
            this.label_ESP.Name = "label_ESP";
            this.label_ESP.Size = new System.Drawing.Size(139, 30);
            this.label_ESP.TabIndex = 9;
            this.label_ESP.Text = "超能力: 100";
            this.label_ESP.Click += new System.EventHandler(this.edit_set);
            // 
            // label_energy
            // 
            this.label_energy.AutoSize = true;
            this.label_energy.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_energy.Location = new System.Drawing.Point(16, 60);
            this.label_energy.Name = "label_energy";
            this.label_energy.Size = new System.Drawing.Size(121, 30);
            this.label_energy.TabIndex = 10;
            this.label_energy.Text = "體力: 100 ";
            this.label_energy.Click += new System.EventHandler(this.edit_set);
            // 
            // label_wisdom
            // 
            this.label_wisdom.AutoSize = true;
            this.label_wisdom.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wisdom.Location = new System.Drawing.Point(16, 10);
            this.label_wisdom.Name = "label_wisdom";
            this.label_wisdom.Size = new System.Drawing.Size(115, 30);
            this.label_wisdom.TabIndex = 11;
            this.label_wisdom.Text = "智力: 100";
            this.label_wisdom.Click += new System.EventHandler(this.edit_set);
            // 
            // panel_ability
            // 
            this.panel_ability.Controls.Add(this.label_wisdom);
            this.panel_ability.Controls.Add(this.label_reward);
            this.panel_ability.Controls.Add(this.label_energy);
            this.panel_ability.Controls.Add(this.label_ESP);
            this.panel_ability.Location = new System.Drawing.Point(527, 47);
            this.panel_ability.Name = "panel_ability";
            this.panel_ability.Size = new System.Drawing.Size(191, 200);
            this.panel_ability.TabIndex = 12;
            // 
            // panel_name
            // 
            this.panel_name.Controls.Add(this.label1);
            this.panel_name.Controls.Add(this.label_level);
            this.panel_name.Controls.Add(this.label_name);
            this.panel_name.Controls.Add(this.label_exe);
            this.panel_name.Controls.Add(this.label_time);
            this.panel_name.Location = new System.Drawing.Point(303, 47);
            this.panel_name.Name = "panel_name";
            this.panel_name.Size = new System.Drawing.Size(191, 200);
            this.panel_name.TabIndex = 13;
            // 
            // mainChar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.panel_name);
            this.Controls.Add(this.panel_ability);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "mainChar";
            this.Size = new System.Drawing.Size(879, 451);
            this.Load += new System.EventHandler(this.mainChar_Load);
            this.Click += new System.EventHandler(this.edit_set);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_ability.ResumeLayout(false);
            this.panel_ability.PerformLayout();
            this.panel_name.ResumeLayout(false);
            this.panel_name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label_exe;
        private System.Windows.Forms.Label label_reward;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_ESP;
        private System.Windows.Forms.Label label_energy;
        private System.Windows.Forms.Label label_wisdom;
        private System.Windows.Forms.Panel panel_ability;
        private System.Windows.Forms.Panel panel_name;
    }
}
