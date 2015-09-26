namespace scsjgl
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCance = new System.Windows.Forms.Button();
            this.btnDeng = new System.Windows.Forms.Button();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserName.Location = new System.Drawing.Point(196, 113);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(161, 30);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "生产信息管理系统";
            // 
            // btnCance
            // 
            this.btnCance.Location = new System.Drawing.Point(271, 225);
            this.btnCance.Name = "btnCance";
            this.btnCance.Size = new System.Drawing.Size(103, 32);
            this.btnCance.TabIndex = 19;
            this.btnCance.Text = "取消";
            this.btnCance.UseVisualStyleBackColor = true;
            this.btnCance.Click += new System.EventHandler(this.btnCance_Click);
            // 
            // btnDeng
            // 
            this.btnDeng.Location = new System.Drawing.Point(99, 225);
            this.btnDeng.Name = "btnDeng";
            this.btnDeng.Size = new System.Drawing.Size(105, 32);
            this.btnDeng.TabIndex = 18;
            this.btnDeng.Text = "登录";
            this.btnDeng.UseVisualStyleBackColor = true;
            this.btnDeng.Click += new System.EventHandler(this.btnDeng_Click);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(96, 165);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(94, 20);
            this.lblPwd.TabIndex = 17;
            this.lblPwd.Text = "密  码：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(97, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 20);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "工  号：";
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserPwd.Location = new System.Drawing.Point(196, 165);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.PasswordChar = '*';
            this.txtUserPwd.Size = new System.Drawing.Size(161, 30);
            this.txtUserPwd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(117, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "成 都 储 翰 科 技 有 限 公 司";
            // 
            // Login
            // 
            this.AcceptButton = this.btnDeng;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCance);
            this.Controls.Add(this.btnDeng);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtUserPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登  录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCance;
        private System.Windows.Forms.Button btnDeng;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUserPwd;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
    }
}