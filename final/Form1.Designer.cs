namespace final
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && ( components != null ))
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
        private void InitializeComponent ()
        {
            this.panelcontainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_other = new System.Windows.Forms.Button();
            this.btn_branch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_main = new System.Windows.Forms.Button();
            this.btn_char = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontainer
            // 
            this.panelcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontainer.Location = new System.Drawing.Point(0, 77);
            this.panelcontainer.Name = "panelcontainer";
            this.panelcontainer.Size = new System.Drawing.Size(879, 451);
            this.panelcontainer.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btn_other);
            this.panel1.Controls.Add(this.btn_branch);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_main);
            this.panel1.Controls.Add(this.btn_char);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 77);
            this.panel1.TabIndex = 0;
            // 
            // btn_other
            // 
            this.btn_other.BackColor = System.Drawing.SystemColors.Control;
            this.btn_other.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_other.Location = new System.Drawing.Point(620, 27);
            this.btn_other.Name = "btn_other";
            this.btn_other.Size = new System.Drawing.Size(150, 32);
            this.btn_other.TabIndex = 5;
            this.btn_other.Text = "其他";
            this.btn_other.UseVisualStyleBackColor = false;
            // 
            // btn_branch
            // 
            this.btn_branch.BackColor = System.Drawing.SystemColors.Control;
            this.btn_branch.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_branch.Location = new System.Drawing.Point(435, 27);
            this.btn_branch.Name = "btn_branch";
            this.btn_branch.Size = new System.Drawing.Size(150, 32);
            this.btn_branch.TabIndex = 4;
            this.btn_branch.Text = "支線任務";
            this.btn_branch.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(879, 10);
            this.panel3.TabIndex = 3;
            // 
            // btn_main
            // 
            this.btn_main.BackColor = System.Drawing.SystemColors.Control;
            this.btn_main.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main.Location = new System.Drawing.Point(257, 27);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(150, 32);
            this.btn_main.TabIndex = 1;
            this.btn_main.Text = "主線任務";
            this.btn_main.UseVisualStyleBackColor = false;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // btn_char
            // 
            this.btn_char.BackColor = System.Drawing.SystemColors.Control;
            this.btn_char.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_char.Location = new System.Drawing.Point(75, 27);
            this.btn_char.Name = "btn_char";
            this.btn_char.Size = new System.Drawing.Size(150, 32);
            this.btn_char.TabIndex = 0;
            this.btn_char.Text = "角色";
            this.btn_char.UseVisualStyleBackColor = false;
            this.btn_char.Click += new System.EventHandler(this.btn_char_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(879, 528);
            this.Controls.Add(this.panelcontainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_other;
        private System.Windows.Forms.Button btn_branch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Button btn_char;
        private System.Windows.Forms.Panel panelcontainer;
    }
}

