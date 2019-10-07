namespace StuManageSys
{
    partial class FrmStuSearch
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
            this.DGViewStu = new System.Windows.Forms.DataGridView();
            this.stu_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_nat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewStu)).BeginInit();
            this.SuspendLayout();
            // 
            // DGViewStu
            // 
            this.DGViewStu.AllowUserToAddRows = false;
            this.DGViewStu.AllowUserToDeleteRows = false;
            this.DGViewStu.BackgroundColor = System.Drawing.Color.White;
            this.DGViewStu.ColumnHeadersHeight = 30;
            this.DGViewStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stu_no,
            this.stu_name,
            this.stu_major,
            this.stu_class,
            this.stu_sex,
            this.stu_age,
            this.stu_nat,
            this.stu_card});
            this.DGViewStu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGViewStu.Location = new System.Drawing.Point(0, 0);
            this.DGViewStu.Name = "DGViewStu";
            this.DGViewStu.ReadOnly = true;
            this.DGViewStu.RowTemplate.Height = 23;
            this.DGViewStu.Size = new System.Drawing.Size(800, 450);
            this.DGViewStu.TabIndex = 0;
            this.DGViewStu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGViewStu_CellContentClick);
            // 
            // stu_no
            // 
            this.stu_no.DataPropertyName = "stu_no";
            this.stu_no.HeaderText = "学号";
            this.stu_no.Name = "stu_no";
            this.stu_no.ReadOnly = true;
            // 
            // stu_name
            // 
            this.stu_name.DataPropertyName = "stu_name";
            this.stu_name.HeaderText = "姓名";
            this.stu_name.Name = "stu_name";
            this.stu_name.ReadOnly = true;
            // 
            // stu_major
            // 
            this.stu_major.DataPropertyName = "stu_major";
            this.stu_major.HeaderText = "专业";
            this.stu_major.Name = "stu_major";
            this.stu_major.ReadOnly = true;
            // 
            // stu_class
            // 
            this.stu_class.DataPropertyName = "stu_class";
            this.stu_class.HeaderText = "班级";
            this.stu_class.Name = "stu_class";
            this.stu_class.ReadOnly = true;
            // 
            // stu_sex
            // 
            this.stu_sex.DataPropertyName = "stu_sex";
            this.stu_sex.HeaderText = "性别";
            this.stu_sex.Name = "stu_sex";
            this.stu_sex.ReadOnly = true;
            // 
            // stu_age
            // 
            this.stu_age.DataPropertyName = "stu_age";
            this.stu_age.HeaderText = "年龄";
            this.stu_age.Name = "stu_age";
            this.stu_age.ReadOnly = true;
            // 
            // stu_nat
            // 
            this.stu_nat.DataPropertyName = "stu_nat";
            this.stu_nat.HeaderText = "籍贯";
            this.stu_nat.Name = "stu_nat";
            this.stu_nat.ReadOnly = true;
            // 
            // stu_card
            // 
            this.stu_card.DataPropertyName = "stu_card";
            this.stu_card.HeaderText = "身份证号";
            this.stu_card.Name = "stu_card";
            this.stu_card.ReadOnly = true;
            // 
            // FrmStuSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StuManageSys.Properties.Resources.wallhaven_770049;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGViewStu);
            this.Name = "FrmStuSearch";
            this.TabText = "学员查询";
            this.Text = "学员查询";
            this.Load += new System.EventHandler(this.FrmStuSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewStu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGViewStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_major;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_nat;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_card;
    }
}