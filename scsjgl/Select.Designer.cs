namespace scsjgl
{
    partial class Select
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.btnExSel = new System.Windows.Forms.Button();
            this.btnDao = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAllNum = new System.Windows.Forms.TextBox();
            this.tbtime2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.序列号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.随工单 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备货单 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成品编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liv_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbBhdh = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "-";
            // 
            // btnExSel
            // 
            this.btnExSel.Enabled = false;
            this.btnExSel.Location = new System.Drawing.Point(953, 16);
            this.btnExSel.Name = "btnExSel";
            this.btnExSel.Size = new System.Drawing.Size(79, 63);
            this.btnExSel.TabIndex = 27;
            this.btnExSel.Text = "查看EXCEL";
            this.btnExSel.UseVisualStyleBackColor = true;
            // 
            // btnDao
            // 
            this.btnDao.Location = new System.Drawing.Point(869, 16);
            this.btnDao.Name = "btnDao";
            this.btnDao.Size = new System.Drawing.Size(78, 63);
            this.btnDao.TabIndex = 26;
            this.btnDao.Text = "数据导出";
            this.btnDao.UseVisualStyleBackColor = true;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTime.Location = new System.Drawing.Point(391, 38);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(99, 26);
            this.tbTime.TabIndex = 25;
            this.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "总数量";
            // 
            // tbAllNum
            // 
            this.tbAllNum.Enabled = false;
            this.tbAllNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAllNum.Location = new System.Drawing.Point(679, 36);
            this.tbAllNum.Name = "tbAllNum";
            this.tbAllNum.Size = new System.Drawing.Size(84, 26);
            this.tbAllNum.TabIndex = 23;
            // 
            // tbtime2
            // 
            this.tbtime2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbtime2.Location = new System.Drawing.Point(512, 36);
            this.tbtime2.Name = "tbtime2";
            this.tbtime2.Size = new System.Drawing.Size(101, 26);
            this.tbtime2.TabIndex = 29;
            this.tbtime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvShow);
            this.panel1.Location = new System.Drawing.Point(2, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 468);
            this.panel1.TabIndex = 22;
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AllowUserToOrderColumns = true;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序列号,
            this.型号,
            this.随工单,
            this.备货单,
            this.成品编码,
            this.Liv_time});
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.Location = new System.Drawing.Point(0, 0);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.Size = new System.Drawing.Size(1040, 468);
            this.dgvShow.TabIndex = 0;
            // 
            // 序列号
            // 
            this.序列号.DataPropertyName = "序列号";
            this.序列号.HeaderText = "序列号";
            this.序列号.Name = "序列号";
            this.序列号.Width = 200;
            // 
            // 型号
            // 
            this.型号.DataPropertyName = "型号";
            this.型号.HeaderText = "型号";
            this.型号.Name = "型号";
            this.型号.Width = 150;
            // 
            // 随工单
            // 
            this.随工单.DataPropertyName = "随工单";
            this.随工单.HeaderText = "随工单";
            this.随工单.Name = "随工单";
            this.随工单.Width = 150;
            // 
            // 备货单
            // 
            this.备货单.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.备货单.DataPropertyName = "备货单";
            this.备货单.HeaderText = "备货单";
            this.备货单.Name = "备货单";
            // 
            // 成品编码
            // 
            this.成品编码.DataPropertyName = "成品编码";
            this.成品编码.HeaderText = "成品编码";
            this.成品编码.Name = "成品编码";
            this.成品编码.Width = 200;
            // 
            // Liv_time
            // 
            this.Liv_time.DataPropertyName = "Liv_time";
            this.Liv_time.HeaderText = "Liv_time";
            this.Liv_time.Name = "Liv_time";
            this.Liv_time.Width = 150;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(778, 16);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(76, 63);
            this.btnSelect.TabIndex = 21;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "查询条件";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(328, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "时间";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbBhdh
            // 
            this.tbBhdh.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbBhdh.FormattingEnabled = true;
            this.tbBhdh.Location = new System.Drawing.Point(182, 42);
            this.tbBhdh.Name = "tbBhdh";
            this.tbBhdh.Size = new System.Drawing.Size(120, 21);
            this.tbBhdh.TabIndex = 33;
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 567);
            this.Controls.Add(this.tbBhdh);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExSel);
            this.Controls.Add(this.btnDao);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAllNum);
            this.Controls.Add(this.tbtime2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelect);
            this.Name = "Select";
            this.Text = "条件查询";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExSel;
        private System.Windows.Forms.Button btnDao;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAllNum;
        private System.Windows.Forms.TextBox tbtime2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox tbBhdh;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序列号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 随工单;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备货单;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成品编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liv_time;
    }
}