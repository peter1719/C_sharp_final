namespace final
{
    partial class subMainQuest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_quest_name = new System.Windows.Forms.Label();
            this.btn_train = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_engage_time = new System.Windows.Forms.Label();
            this.panel_indicator = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_exe = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "任務: ";
            // 
            // label_quest_name
            // 
            this.label_quest_name.AutoSize = true;
            this.label_quest_name.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quest_name.Location = new System.Drawing.Point(213, 24);
            this.label_quest_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_quest_name.Name = "label_quest_name";
            this.label_quest_name.Size = new System.Drawing.Size(205, 30);
            this.label_quest_name.TabIndex = 1;
            this.label_quest_name.Text = "克西和夫電壓定理";
            this.label_quest_name.DoubleClick += new System.EventHandler(this.label_quest_name_DoubleClick);
            // 
            // btn_train
            // 
            this.btn_train.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_train.Location = new System.Drawing.Point(451, 68);
            this.btn_train.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_train.Name = "btn_train";
            this.btn_train.Size = new System.Drawing.Size(83, 31);
            this.btn_train.TabIndex = 2;
            this.btn_train.Text = "修煉";
            this.btn_train.UseVisualStyleBackColor = true;
            this.btn_train.Click += new System.EventHandler(this.btn_train_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "進度:";
            // 
            // label_engage_time
            // 
            this.label_engage_time.AutoSize = true;
            this.label_engage_time.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_engage_time.Location = new System.Drawing.Point(217, 70);
            this.label_engage_time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_engage_time.Name = "label_engage_time";
            this.label_engage_time.Size = new System.Drawing.Size(201, 30);
            this.label_engage_time.TabIndex = 6;
            this.label_engage_time.Text = "稍微知道(50分鐘)";
            this.label_engage_time.DoubleClick += new System.EventHandler(this.label_engage_time_DoubleClick);
            // 
            // panel_indicator
            // 
            this.panel_indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_indicator.Location = new System.Drawing.Point(546, 0);
            this.panel_indicator.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel_indicator.Name = "panel_indicator";
            this.panel_indicator.Size = new System.Drawing.Size(32, 125);
            this.panel_indicator.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::final.Properties.Resources.sample2;
            this.pictureBox1.Location = new System.Drawing.Point(4, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_exe
            // 
            this.panel_exe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_exe.Location = new System.Drawing.Point(0, 109);
            this.panel_exe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel_exe.Name = "panel_exe";
            this.panel_exe.Size = new System.Drawing.Size(466, 16);
            this.panel_exe.TabIndex = 9;
            // 
            // subMainQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_exe);
            this.Controls.Add(this.panel_indicator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_engage_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_train);
            this.Controls.Add(this.label_quest_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "subMainQuest";
            this.Size = new System.Drawing.Size(578, 123);
            this.Load += new System.EventHandler(this.subMainQuest_Load);
            this.Click += new System.EventHandler(this.subMainQuest_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_quest_name;
        private System.Windows.Forms.Button btn_train;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_engage_time;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_indicator;
        private System.Windows.Forms.Panel panel_exe;
    }
}
