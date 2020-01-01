namespace final
{
    partial class shop
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
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.label_reward = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.Dock = System.Windows.Forms.DockStyle.Top;
            this.flp.Location = new System.Drawing.Point(0, 0);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(879, 390);
            this.flp.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(154, 405);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 33);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "新建";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(281, 405);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(103, 33);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "刪除";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.White;
            this.btn_buy.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.Location = new System.Drawing.Point(25, 405);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(103, 33);
            this.btn_buy.TabIndex = 5;
            this.btn_buy.Text = "購買";
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // label_reward
            // 
            this.label_reward.AutoSize = true;
            this.label_reward.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_reward.Location = new System.Drawing.Point(415, 409);
            this.label_reward.Name = "label_reward";
            this.label_reward.Size = new System.Drawing.Size(57, 24);
            this.label_reward.TabIndex = 6;
            this.label_reward.Text = "獎勵: ";
            // 
            // shop
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.label_reward);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.flp);
            this.Name = "shop";
            this.Size = new System.Drawing.Size(879, 451);
            this.Load += new System.EventHandler(this.shop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label label_reward;
    }
}
