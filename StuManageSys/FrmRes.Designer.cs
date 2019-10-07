namespace StuManageSys
{
    partial class FrmRes
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.lalPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.laluser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(99, 178);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(57, 23);
            this.btnRes.TabIndex = 4;
            this.btnRes.Text = "注册";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.BtnRes_Click);
            this.btnRes.Enter += new System.EventHandler(this.BtnRes_Click);
            // 
            // lalPwd
            // 
            this.lalPwd.AutoSize = true;
            this.lalPwd.Location = new System.Drawing.Point(44, 97);
            this.lalPwd.Name = "lalPwd";
            this.lalPwd.Size = new System.Drawing.Size(41, 12);
            this.lalPwd.TabIndex = 8;
            this.lalPwd.Text = "密  码";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(99, 94);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(141, 21);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(99, 40);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(141, 21);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // laluser
            // 
            this.laluser.AutoSize = true;
            this.laluser.Location = new System.Drawing.Point(44, 43);
            this.laluser.Name = "laluser";
            this.laluser.Size = new System.Drawing.Size(41, 12);
            this.laluser.TabIndex = 22;
            this.laluser.Text = "用户名";
            // 
            // FrmRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.laluser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lalPwd);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FrmRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label lalPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label laluser;
    }
}