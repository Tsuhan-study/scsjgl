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
            this.btnOKUpdate = new System.Windows.Forms.Button();
            this.btnDeng = new System.Windows.Forms.Button();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtQRNewPwd = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserName.Location = new System.Drawing.Point(120, 59);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(116, 30);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "生产信息管理系统";
            // 
            // btnOKUpdate
            // 
            this.btnOKUpdate.Enabled = false;
            this.btnOKUpdate.Location = new System.Drawing.Point(273, 201);
            this.btnOKUpdate.Name = "btnOKUpdate";
            this.btnOKUpdate.Size = new System.Drawing.Size(103, 38);
            this.btnOKUpdate.TabIndex = 19;
            this.btnOKUpdate.Text = "确认修改密码";
            this.btnOKUpdate.UseVisualStyleBackColor = true;
            this.btnOKUpdate.Click += new System.EventHandler(this.btnOKUpdate_Click);
            // 
            // btnDeng
            // 
            this.btnDeng.Location = new System.Drawing.Point(273, 55);
            this.btnDeng.Name = "btnDeng";
            this.btnDeng.Size = new System.Drawing.Size(105, 41);
            this.btnDeng.TabIndex = 18;
            this.btnDeng.Text = "登录";
            this.btnDeng.UseVisualStyleBackColor = true;
            this.btnDeng.Click += new System.EventHandler(this.btnDeng_Click);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(48, 111);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(65, 12);
            this.lblPwd.TabIndex = 17;
            this.lblPwd.Text = "登录密码：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(72, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "工号：";
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserPwd.Location = new System.Drawing.Point(120, 111);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.PasswordChar = '*';
            this.txtUserPwd.Size = new System.Drawing.Size(116, 30);
            this.txtUserPwd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(71, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "成 都 储 翰 科 技 有 限 公 司";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Enabled = false;
            this.txtNewPwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewPwd.Location = new System.Drawing.Point(120, 157);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(116, 30);
            this.txtNewPwd.TabIndex = 21;
            // 
            // txtQRNewPwd
            // 
            this.txtQRNewPwd.Enabled = false;
            this.txtQRNewPwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQRNewPwd.Location = new System.Drawing.Point(120, 209);
            this.txtQRNewPwd.Name = "txtQRNewPwd";
            this.txtQRNewPwd.PasswordChar = '*';
            this.txtQRNewPwd.Size = new System.Drawing.Size(116, 30);
            this.txtQRNewPwd.TabIndex = 22;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(271, 126);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 41);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "修改密码";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "新密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "确认新密码：";
            // 
            // Login
            // 
            this.AcceptButton = this.btnDeng;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 307);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtQRNewPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOKUpdate);
            this.Controls.Add(this.btnDeng);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtUserPwd);
            this.Controls.Add(this.lblName);
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
        private System.Windows.Forms.Button btnOKUpdate;
        private System.Windows.Forms.Button btnDeng;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUserPwd;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtQRNewPwd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}