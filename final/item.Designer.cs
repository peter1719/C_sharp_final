namespace final
{
    partial class item
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
            this.panel_index = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_num = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_index
            // 
            this.panel_index.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_index.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_index.Location = new System.Drawing.Point(0, 111);
            this.panel_index.Name = "panel_index";
            this.panel_index.Size = new System.Drawing.Size(361, 23);
            this.panel_index.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(129, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "商品:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_name.Location = new System.Drawing.Point(183, 14);
            this.label_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(17, 20);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "x";
            this.label_name.DoubleClick += new System.EventHandler(this.label_name_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(129, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "價錢:";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_price.Location = new System.Drawing.Point(183, 40);
            this.label_price.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(17, 20);
            this.label_price.TabIndex = 8;
            this.label_price.Text = "x";
            this.label_price.DoubleClick += new System.EventHandler(this.label_price_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(129, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "已購買數量:";
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_num.Location = new System.Drawing.Point(231, 77);
            this.label_num.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(17, 20);
            this.label_num.TabIndex = 11;
            this.label_num.Text = "x";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::final.Properties.Resources.roadroller;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // item
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.panel_index);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "item";
            this.Size = new System.Drawing.Size(361, 134);
            this.Load += new System.EventHandler(this.item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
