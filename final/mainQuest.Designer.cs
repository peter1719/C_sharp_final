namespace final
{
    partial class mainQuest
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
            this.flp_left = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_right = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_delete_sub = new System.Windows.Forms.Button();
            this.btn_add_sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_left
            // 
            this.flp_left.AutoScroll = true;
            this.flp_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flp_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flp_left.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flp_left.Location = new System.Drawing.Point(0, 0);
            this.flp_left.Margin = new System.Windows.Forms.Padding(0);
            this.flp_left.Name = "flp_left";
            this.flp_left.Size = new System.Drawing.Size(262, 403);
            this.flp_left.TabIndex = 1;
            // 
            // flp_right
            // 
            this.flp_right.AutoScroll = true;
            this.flp_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flp_right.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flp_right.Location = new System.Drawing.Point(265, -1);
            this.flp_right.Name = "flp_right";
            this.flp_right.Size = new System.Drawing.Size(614, 404);
            this.flp_right.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(22, 406);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 33);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "新建";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(140, 406);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(103, 33);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "刪除";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_delete_sub
            // 
            this.btn_delete_sub.BackColor = System.Drawing.Color.White;
            this.btn_delete_sub.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_sub.Location = new System.Drawing.Point(599, 409);
            this.btn_delete_sub.Name = "btn_delete_sub";
            this.btn_delete_sub.Size = new System.Drawing.Size(103, 33);
            this.btn_delete_sub.TabIndex = 5;
            this.btn_delete_sub.Text = "刪除";
            this.btn_delete_sub.UseVisualStyleBackColor = false;
            this.btn_delete_sub.Click += new System.EventHandler(this.btn_delete_sub_Click);
            // 
            // btn_add_sub
            // 
            this.btn_add_sub.BackColor = System.Drawing.Color.White;
            this.btn_add_sub.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_sub.Location = new System.Drawing.Point(405, 409);
            this.btn_add_sub.Name = "btn_add_sub";
            this.btn_add_sub.Size = new System.Drawing.Size(103, 33);
            this.btn_add_sub.TabIndex = 4;
            this.btn_add_sub.Text = "新建";
            this.btn_add_sub.UseVisualStyleBackColor = false;
            this.btn_add_sub.Click += new System.EventHandler(this.btn_add_sub_Click);
            // 
            // mainQuest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btn_delete_sub);
            this.Controls.Add(this.btn_add_sub);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.flp_left);
            this.Controls.Add(this.flp_right);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "mainQuest";
            this.Size = new System.Drawing.Size(879, 451);
            this.Load += new System.EventHandler(this.mainQuest_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flp_left;
        private System.Windows.Forms.FlowLayoutPanel flp_right;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_delete_sub;
        private System.Windows.Forms.Button btn_add_sub;
    }
}
