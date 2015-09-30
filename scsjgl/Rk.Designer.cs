namespace scsjgl
{
    partial class Rk
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rk));
            this.tbBhdh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.备货单 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出货日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出货数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAllNum = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.btnDao = new System.Windows.Forms.Button();
            this.btnExSel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbtime2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBhdh
            // 
            this.tbBhdh.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbBhdh.Location = new System.Drawing.Point(119, 72);
            this.tbBhdh.Name = "tbBhdh";
            this.tbBhdh.Size = new System.Drawing.Size(118, 29);
            this.tbBhdh.TabIndex = 0;
            this.tbBhdh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "备货单号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "入库时间";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(119, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(165, 41);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "查  询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvShow);
            this.panel1.Location = new System.Drawing.Point(2, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 354);
            this.panel1.TabIndex = 10;
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AllowUserToOrderColumns = true;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.备货单,
            this.出货日期,
            this.出货数量});
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.Location = new System.Drawing.Point(0, 0);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.Size = new System.Drawing.Size(1043, 354);
            this.dgvShow.TabIndex = 0;
            // 
            // 备货单
            // 
            this.备货单.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.备货单.DataPropertyName = "备货单";
            this.备货单.HeaderText = "备货单";
            this.备货单.Name = "备货单";
            // 
            // 出货日期
            // 
            this.出货日期.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.出货日期.DataPropertyName = "出货日期";
            this.出货日期.HeaderText = "出货日期";
            this.出货日期.Name = "出货日期";
            // 
            // 出货数量
            // 
            this.出货数量.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.出货数量.DataPropertyName = "出货数量";
            this.出货数量.HeaderText = "出货数量";
            this.出货数量.Name = "出货数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "总数量";
            // 
            // tbAllNum
            // 
            this.tbAllNum.Enabled = false;
            this.tbAllNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAllNum.Location = new System.Drawing.Point(737, 74);
            this.tbAllNum.Name = "tbAllNum";
            this.tbAllNum.Size = new System.Drawing.Size(84, 26);
            this.tbAllNum.TabIndex = 11;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTime.Location = new System.Drawing.Point(328, 75);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(134, 26);
            this.tbTime.TabIndex = 13;
            this.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDao
            // 
            this.btnDao.Location = new System.Drawing.Point(837, 62);
            this.btnDao.Name = "btnDao";
            this.btnDao.Size = new System.Drawing.Size(100, 51);
            this.btnDao.TabIndex = 14;
            this.btnDao.Text = "EXCEL数据导出";
            this.btnDao.UseVisualStyleBackColor = true;
            this.btnDao.Click += new System.EventHandler(this.btnDao_Click);
            // 
            // btnExSel
            // 
            this.btnExSel.Enabled = false;
            this.btnExSel.Location = new System.Drawing.Point(943, 62);
            this.btnExSel.Name = "btnExSel";
            this.btnExSel.Size = new System.Drawing.Size(92, 51);
            this.btnExSel.TabIndex = 15;
            this.btnExSel.Text = "查看EXCEL";
            this.btnExSel.UseVisualStyleBackColor = true;
            this.btnExSel.Click += new System.EventHandler(this.btnExSel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "-";
            // 
            // tbtime2
            // 
            this.tbtime2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbtime2.Location = new System.Drawing.Point(489, 74);
            this.tbtime2.Name = "tbtime2";
            this.tbtime2.Size = new System.Drawing.Size(134, 26);
            this.tbtime2.TabIndex = 17;
            this.tbtime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1052, 500);
            this.Controls.Add(this.tbtime2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExSel);
            this.Controls.Add(this.btnDao);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAllNum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBhdh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入库";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBhdh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAllNum;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备货单;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出货日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出货数量;
        private System.Windows.Forms.Button btnDao;
        private System.Windows.Forms.Button btnExSel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbtime2;
    }
}

