namespace final
{
    partial class mQuestInfo
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
            this.label_quest = new System.Windows.Forms.Label();
            this.btn_easy = new System.Windows.Forms.Button();
            this.btn_normall = new System.Windows.Forms.Button();
            this.btn_master = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_quest
            // 
            this.label_quest.AutoSize = true;
            this.label_quest.Location = new System.Drawing.Point(100, 15);
            this.label_quest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_quest.Name = "label_quest";
            this.label_quest.Size = new System.Drawing.Size(17, 20);
            this.label_quest.TabIndex = 0;
            this.label_quest.Text = "x";
            this.label_quest.Click += new System.EventHandler(this.mQuestInfo_Click);
            this.label_quest.DoubleClick += new System.EventHandler(this.label_quest_DoubleClick);
            // 
            // btn_easy
            // 
            this.btn_easy.BackColor = System.Drawing.Color.White;
            this.btn_easy.ForeColor = System.Drawing.Color.Black;
            this.btn_easy.Location = new System.Drawing.Point(17, 66);
            this.btn_easy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(63, 29);
            this.btn_easy.TabIndex = 1;
            this.btn_easy.Text = "簡單";
            this.btn_easy.UseVisualStyleBackColor = false;
            this.btn_easy.Click += new System.EventHandler(this.btn_easy_Click);
            // 
            // btn_normall
            // 
            this.btn_normall.Location = new System.Drawing.Point(88, 66);
            this.btn_normall.Margin = new System.Windows.Forms.Padding(4);
            this.btn_normall.Name = "btn_normall";
            this.btn_normall.Size = new System.Drawing.Size(51, 29);
            this.btn_normall.TabIndex = 2;
            this.btn_normall.Text = "普通";
            this.btn_normall.UseVisualStyleBackColor = true;
            this.btn_normall.Click += new System.EventHandler(this.btn_normall_Click);
            // 
            // btn_master
            // 
            this.btn_master.Location = new System.Drawing.Point(147, 66);
            this.btn_master.Margin = new System.Windows.Forms.Padding(4);
            this.btn_master.Name = "btn_master";
            this.btn_master.Size = new System.Drawing.Size(58, 29);
            this.btn_master.TabIndex = 3;
            this.btn_master.Text = "大師";
            this.btn_master.UseVisualStyleBackColor = true;
            this.btn_master.Click += new System.EventHandler(this.btn_master_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 15);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "任務名稱:";
            this.label1.Click += new System.EventHandler(this.mQuestInfo_Click);
            // 
            // mQuestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_master);
            this.Controls.Add(this.btn_normall);
            this.Controls.Add(this.btn_easy);
            this.Controls.Add(this.label_quest);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mQuestInfo";
            this.Size = new System.Drawing.Size(225, 110);
            this.Load += new System.EventHandler(this.mQuestInfo_Load);
            this.Click += new System.EventHandler(this.mQuestInfo_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_quest;
        private System.Windows.Forms.Button btn_easy;
        private System.Windows.Forms.Button btn_normall;
        private System.Windows.Forms.Button btn_master;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
