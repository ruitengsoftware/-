namespace 积分赛算分系统
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.dgv_score = new Sunny.UI.UIDataGridView();
            this.rena = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.renb = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bifen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_result = new Sunny.UI.UIDataGridView();
            this.xuhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xingming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chushijifen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dagnqianjifen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.btn_clear = new Sunny.UI.UIButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(319, 3);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(94, 34);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 3;
            this.uiButton1.Text = "开始计算";
            this.uiButton1.Click += new System.EventHandler(this.btn_jisuan_Click);
            // 
            // dgv_score
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_score.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_score.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_score.BackgroundColor = System.Drawing.Color.White;
            this.dgv_score.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_score.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_score.ColumnHeadersHeight = 32;
            this.dgv_score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_score.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rena,
            this.renb,
            this.bifen});
            this.dgv_score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_score.EnableHeadersVisualStyles = false;
            this.dgv_score.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_score.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_score.Location = new System.Drawing.Point(0, 0);
            this.dgv_score.Name = "dgv_score";
            this.dgv_score.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgv_score.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_score.RowTemplate.Height = 29;
            this.dgv_score.SelectedIndex = -1;
            this.dgv_score.ShowGridLine = true;
            this.dgv_score.Size = new System.Drawing.Size(309, 591);
            this.dgv_score.Style = Sunny.UI.UIStyle.Custom;
            this.dgv_score.TabIndex = 4;
            // 
            // rena
            // 
            this.rena.HeaderText = "人A";
            this.rena.Name = "rena";
            this.rena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // renb
            // 
            this.renb.HeaderText = "人B";
            this.renb.Name = "renb";
            // 
            // bifen
            // 
            this.bifen.HeaderText = "比分";
            this.bifen.Name = "bifen";
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_result.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_result.BackgroundColor = System.Drawing.Color.White;
            this.dgv_result.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_result.ColumnHeadersHeight = 32;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xuhao,
            this.xingming,
            this.chushijifen,
            this.dagnqianjifen});
            this.dgv_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_result.EnableHeadersVisualStyles = false;
            this.dgv_result.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_result.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_result.Location = new System.Drawing.Point(0, 0);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgv_result.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_result.RowTemplate.Height = 29;
            this.dgv_result.SelectedIndex = -1;
            this.dgv_result.ShowGridLine = true;
            this.dgv_result.Size = new System.Drawing.Size(614, 591);
            this.dgv_result.Style = Sunny.UI.UIStyle.Custom;
            this.dgv_result.TabIndex = 4;
            // 
            // xuhao
            // 
            this.xuhao.HeaderText = "序号";
            this.xuhao.Name = "xuhao";
            // 
            // xingming
            // 
            this.xingming.HeaderText = "姓名";
            this.xingming.Name = "xingming";
            // 
            // chushijifen
            // 
            this.chushijifen.HeaderText = "初始积分";
            this.chushijifen.Name = "chushijifen";
            // 
            // dagnqianjifen
            // 
            this.dagnqianjifen.HeaderText = "当前积分";
            this.dagnqianjifen.Name = "dagnqianjifen";
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(519, 3);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(94, 34);
            this.uiButton2.TabIndex = 5;
            this.uiButton2.Text = "导出结果表";
            this.uiButton2.Click += new System.EventHandler(this.btn_daochu_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_clear.Location = new System.Drawing.Point(419, 3);
            this.btn_clear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 34);
            this.btn_clear.Style = Sunny.UI.UIStyle.Custom;
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "清空成绩";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 43);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv_score);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_result);
            this.splitContainer1.Size = new System.Drawing.Size(927, 591);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 637);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.uiButton1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiButton2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_clear, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(933, 40);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 637);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "积分赛分数计算助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIDataGridView dgv_score;
        private System.Windows.Forms.DataGridViewComboBoxColumn rena;
        private System.Windows.Forms.DataGridViewComboBoxColumn renb;
        private System.Windows.Forms.DataGridViewTextBoxColumn bifen;
        private Sunny.UI.UIDataGridView dgv_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn xingming;
        private System.Windows.Forms.DataGridViewTextBoxColumn chushijifen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dagnqianjifen;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton btn_clear;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

