namespace StuManageSys
{
    partial class FrmLogin
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
            this.lalUser = new System.Windows.Forms.Label();
            this.lalPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lalRes = new System.Windows.Forms.LinkLabel();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.labelChoose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lalUser
            // 
            this.lalUser.AutoSize = true;
            this.lalUser.Location = new System.Drawing.Point(44, 60);
            this.lalUser.Name = "lalUser";
            this.lalUser.Size = new System.Drawing.Size(41, 12);
            this.lalUser.TabIndex = 0;
            this.lalUser.Text = "用户名";
            // 
            // lalPwd
            // 
            this.lalPwd.AutoSize = true;
            this.lalPwd.Location = new System.Drawing.Point(44, 101);
            this.lalPwd.Name = "lalPwd";
            this.lalPwd.Size = new System.Drawing.Size(41, 12);
            this.lalPwd.TabIndex = 1;
            this.lalPwd.Text = "密  码";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(99, 98);
            this.txtPwd.MaxLength = 12;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(141, 21);
            this.txtPwd.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(99, 57);
            this.txtUser.MaxLength = 12;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(141, 21);
            this.txtUser.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(99, 194);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(57, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "登录";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            this.btnEnter.Enter += new System.EventHandler(this.FrmLogin_Load);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lalRes
            // 
            this.lalRes.AutoSize = true;
            this.lalRes.Location = new System.Drawing.Point(44, 199);
            this.lalRes.Name = "lalRes";
            this.lalRes.Size = new System.Drawing.Size(29, 12);
            this.lalRes.TabIndex = 3;
            this.lalRes.TabStop = true;
            this.lalRes.Text = "注册";
            this.lalRes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LalRes_LinkClicked);
            // 
            // CBType
            // 
            this.CBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBType.FormattingEnabled = true;
            this.CBType.Items.AddRange(new object[] {
            "管理员",
            "学生"});
            this.CBType.Location = new System.Drawing.Point(99, 140);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(141, 20);
            this.CBType.TabIndex = 6;
            this.CBType.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Location = new System.Drawing.Point(44, 143);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(41, 12);
            this.labelChoose.TabIndex = 7;
            this.labelChoose.Text = "请选择";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.CBType);
            this.Controls.Add(this.lalRes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lalPwd);
            this.Controls.Add(this.lalUser);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalUser;
        private System.Windows.Forms.Label lalPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lalRes;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.Label labelChoose;
    }
}