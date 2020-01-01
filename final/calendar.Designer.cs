namespace final
{
    partial class Calendar
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calendarGrid = new System.Windows.Forms.TableLayoutPanel();
            this.title_month = new System.Windows.Forms.Label();
            this.toolbar = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.weekGrid = new System.Windows.Forms.TableLayoutPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.titlebar = new System.Windows.Forms.Panel();
            this.title_year = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolbar.SuspendLayout();
            this.weekGrid.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "⧉";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(3, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "✔";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "星期日";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1116, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "星期六";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(937, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "星期五";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "星期一";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(761, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "星期四";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "星期二";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "星期三";
            // 
            // calendarGrid
            // 
            this.calendarGrid.ColumnCount = 7;
            this.calendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarGrid.Location = new System.Drawing.Point(0, 96);
            this.calendarGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calendarGrid.Name = "calendarGrid";
            this.calendarGrid.RowCount = 4;
            this.calendarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.calendarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.calendarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.calendarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.calendarGrid.Size = new System.Drawing.Size(1267, 676);
            this.calendarGrid.TabIndex = 14;
            // 
            // title_month
            // 
            this.title_month.AutoSize = true;
            this.title_month.Location = new System.Drawing.Point(120, 12);
            this.title_month.Name = "title_month";
            this.title_month.Size = new System.Drawing.Size(30, 22);
            this.title_month.TabIndex = 15;
            this.title_month.Text = "10";
            // 
            // toolbar
            // 
            this.toolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbar.ColumnCount = 4;
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.toolbar.Controls.Add(this.button2, 0, 0);
            this.toolbar.Controls.Add(this.button3, 3, 0);
            this.toolbar.Controls.Add(this.button4, 2, 0);
            this.toolbar.Controls.Add(this.button1, 1, 0);
            this.toolbar.Location = new System.Drawing.Point(1014, 4);
            this.toolbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolbar.Name = "toolbar";
            this.toolbar.RowCount = 1;
            this.toolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbar.Size = new System.Drawing.Size(227, 54);
            this.toolbar.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::final.Properties.Resources.next;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(171, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 46);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::final.Properties.Resources.previous;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(115, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 46);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // weekGrid
            // 
            this.weekGrid.ColumnCount = 7;
            this.weekGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekGrid.Controls.Add(this.label3, 2, 0);
            this.weekGrid.Controls.Add(this.label2, 1, 0);
            this.weekGrid.Controls.Add(this.label7, 6, 0);
            this.weekGrid.Controls.Add(this.label6, 5, 0);
            this.weekGrid.Controls.Add(this.label5, 4, 0);
            this.weekGrid.Controls.Add(this.label4, 3, 0);
            this.weekGrid.Controls.Add(this.label1, 0, 0);
            this.weekGrid.Location = new System.Drawing.Point(14, 63);
            this.weekGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.weekGrid.Name = "weekGrid";
            this.weekGrid.RowCount = 1;
            this.weekGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.weekGrid.Size = new System.Drawing.Size(1237, 35);
            this.weekGrid.TabIndex = 17;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 76);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItem2.Text = "主畫面";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItem3.Text = "贊助我們";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // titlebar
            // 
            this.titlebar.Controls.Add(this.title_year);
            this.titlebar.Controls.Add(this.label10);
            this.titlebar.Controls.Add(this.label9);
            this.titlebar.Controls.Add(this.toolbar);
            this.titlebar.Controls.Add(this.title_month);
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(1257, 67);
            this.titlebar.TabIndex = 18;
            // 
            // title_year
            // 
            this.title_year.AutoSize = true;
            this.title_year.Location = new System.Drawing.Point(27, 12);
            this.title_year.Name = "title_year";
            this.title_year.Size = new System.Drawing.Size(50, 22);
            this.title_year.TabIndex = 19;
            this.title_year.Text = "2020";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "年";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "月";
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1267, 770);
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.weekGrid);
            this.Controls.Add(this.calendarGrid);
            this.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Calendar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Click += new System.EventHandler(this.FinishEdit);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolbar.ResumeLayout(false);
            this.weekGrid.ResumeLayout(false);
            this.weekGrid.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel calendarGrid;
        private System.Windows.Forms.Label title_month;
        private System.Windows.Forms.TableLayoutPanel toolbar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel weekGrid;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label title_year;
        private System.Windows.Forms.Label label10;
    }
}

