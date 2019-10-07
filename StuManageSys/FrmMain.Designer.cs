namespace StuManageSys
{
    partial class FrmMain
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripStatusLabelGroup = new System.Windows.Forms.ToolStripStatusLabel();
            this.lalTop = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUser,
            this.toolStripStatusLabelGroup});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(828, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "用户信息";
            // 
            // toolStripStatusLabelUser
            // 
            this.toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            this.toolStripStatusLabelUser.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabelUser.Text = "用户信息";
            this.toolStripStatusLabelUser.Click += new System.EventHandler(this.ToolStripStatusLabelUser_Click);
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.ShowDocumentIcon = true;
            this.dockPanel1.Size = new System.Drawing.Size(828, 428);
            this.dockPanel1.TabIndex = 5;
            this.dockPanel1.ActiveContentChanged += new System.EventHandler(this.DockPanel1_ActiveContentChanged);
            // 
            // toolStripStatusLabelGroup
            // 
            this.toolStripStatusLabelGroup.Name = "toolStripStatusLabelGroup";
            this.toolStripStatusLabelGroup.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabelGroup.Click += new System.EventHandler(this.ToolStripStatusLabelGroup_Click);
            // 
            // lalTop
            // 
            this.lalTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lalTop.Font = new System.Drawing.Font("华文行楷", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalTop.Location = new System.Drawing.Point(0, 0);
            this.lalTop.Margin = new System.Windows.Forms.Padding(8);
            this.lalTop.Name = "lalTop";
            this.lalTop.Size = new System.Drawing.Size(828, 37);
            this.lalTop.TabIndex = 8;
            this.lalTop.Text = "学生成绩管理系统";
            this.lalTop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.lalTop);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGroup;
        private System.Windows.Forms.Label lalTop;
    }
}