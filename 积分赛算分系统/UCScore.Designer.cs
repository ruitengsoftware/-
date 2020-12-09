namespace 积分赛算分系统
{
    partial class UCScore
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbb_a = new System.Windows.Forms.ComboBox();
            this.cbb_b = new System.Windows.Forms.ComboBox();
            this.cbb_score = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Controls.Add(this.cbb_a, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbb_b, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbb_score, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 31);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbb_a
            // 
            this.cbb_a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_a.FormattingEnabled = true;
            this.cbb_a.Location = new System.Drawing.Point(3, 3);
            this.cbb_a.Name = "cbb_a";
            this.cbb_a.Size = new System.Drawing.Size(137, 25);
            this.cbb_a.TabIndex = 0;
            this.cbb_a.TextUpdate += new System.EventHandler(this.cbb_a_TextUpdate);
            // 
            // cbb_b
            // 
            this.cbb_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_b.FormattingEnabled = true;
            this.cbb_b.Location = new System.Drawing.Point(146, 3);
            this.cbb_b.Name = "cbb_b";
            this.cbb_b.Size = new System.Drawing.Size(137, 25);
            this.cbb_b.TabIndex = 0;
            this.cbb_b.TextUpdate += new System.EventHandler(this.cbb_a_TextUpdate);
            // 
            // cbb_score
            // 
            this.cbb_score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_score.FormattingEnabled = true;
            this.cbb_score.Items.AddRange(new object[] {
            "0:2",
            "0:3",
            "0:4",
            "1:2",
            "1:3",
            "1:4",
            "2:1",
            "2:3",
            "2:4",
            "3:1",
            "3:2",
            "3:4",
            "4:1",
            "4:2",
            "4:3"});
            this.cbb_score.Location = new System.Drawing.Point(289, 3);
            this.cbb_score.Name = "cbb_score";
            this.cbb_score.Size = new System.Drawing.Size(54, 25);
            this.cbb_score.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::积分赛算分系统.Properties.Resources.delete3;
            this.pictureBox1.Location = new System.Drawing.Point(349, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UCScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCScore";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(380, 33);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ComboBox cbb_a;
        public System.Windows.Forms.ComboBox cbb_b;
        public System.Windows.Forms.ComboBox cbb_score;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
