namespace StuManageSys
{
    partial class FrmMenu
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
            this.lalGradeSea = new System.Windows.Forms.Label();
            this.lalGradeAdd = new System.Windows.Forms.Label();
            this.lalStuSea = new System.Windows.Forms.Label();
            this.lalStuMan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lalGradeSea
            // 
            this.lalGradeSea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lalGradeSea.Image = global::StuManageSys.Properties.Resources.ooopic_15703403551;
            this.lalGradeSea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lalGradeSea.Location = new System.Drawing.Point(117, 133);
            this.lalGradeSea.Name = "lalGradeSea";
            this.lalGradeSea.Size = new System.Drawing.Size(60, 55);
            this.lalGradeSea.TabIndex = 3;
            this.lalGradeSea.Text = "成绩查询";
            this.lalGradeSea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lalGradeSea.Click += new System.EventHandler(this.LalGradeSea_Click);
            // 
            // lalGradeAdd
            // 
            this.lalGradeAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lalGradeAdd.Image = global::StuManageSys.Properties.Resources.ooopic_15703403053;
            this.lalGradeAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lalGradeAdd.Location = new System.Drawing.Point(34, 133);
            this.lalGradeAdd.Name = "lalGradeAdd";
            this.lalGradeAdd.Size = new System.Drawing.Size(60, 55);
            this.lalGradeAdd.TabIndex = 2;
            this.lalGradeAdd.Text = "成绩管理";
            this.lalGradeAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lalGradeAdd.Click += new System.EventHandler(this.LalGradeAdd_Click);
            // 
            // lalStuSea
            // 
            this.lalStuSea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lalStuSea.Image = global::StuManageSys.Properties.Resources.ooopic_15703404671;
            this.lalStuSea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lalStuSea.Location = new System.Drawing.Point(117, 40);
            this.lalStuSea.Name = "lalStuSea";
            this.lalStuSea.Size = new System.Drawing.Size(60, 55);
            this.lalStuSea.TabIndex = 1;
            this.lalStuSea.Text = "学员查询";
            this.lalStuSea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lalStuSea.Click += new System.EventHandler(this.LalStuSea_Click);
            // 
            // lalStuMan
            // 
            this.lalStuMan.BackColor = System.Drawing.SystemColors.Control;
            this.lalStuMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lalStuMan.Image = global::StuManageSys.Properties.Resources.ooopic_15703404351;
            this.lalStuMan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lalStuMan.Location = new System.Drawing.Point(34, 40);
            this.lalStuMan.Name = "lalStuMan";
            this.lalStuMan.Size = new System.Drawing.Size(60, 55);
            this.lalStuMan.TabIndex = 0;
            this.lalStuMan.Text = "学员管理";
            this.lalStuMan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lalStuMan.Click += new System.EventHandler(this.LalStuMan_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 590);
            this.Controls.Add(this.lalGradeSea);
            this.Controls.Add(this.lalGradeAdd);
            this.Controls.Add(this.lalStuSea);
            this.Controls.Add(this.lalStuMan);
            this.Name = "FrmMenu";
            this.TabText = "菜单栏";
            this.Text = "菜单栏";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lalStuMan;
        private System.Windows.Forms.Label lalStuSea;
        private System.Windows.Forms.Label lalGradeAdd;
        private System.Windows.Forms.Label lalGradeSea;
    }
}