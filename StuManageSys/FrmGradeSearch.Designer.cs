namespace StuManageSys
{
    partial class FrmGradeSearch
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
            this.DVGradeSea = new System.Windows.Forms.DataGridView();
            this.stu_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chinese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DVGradeSea)).BeginInit();
            this.SuspendLayout();
            // 
            // DVGradeSea
            // 
            this.DVGradeSea.BackgroundColor = System.Drawing.Color.White;
            this.DVGradeSea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGradeSea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stu_no,
            this.stu_name,
            this.stu_major,
            this.stu_class,
            this.exam_no,
            this.chinese,
            this.math,
            this.english});
            this.DVGradeSea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVGradeSea.Location = new System.Drawing.Point(0, 0);
            this.DVGradeSea.Name = "DVGradeSea";
            this.DVGradeSea.RowTemplate.Height = 23;
            this.DVGradeSea.Size = new System.Drawing.Size(800, 450);
            this.DVGradeSea.TabIndex = 0;
            this.DVGradeSea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVGradeSea_CellContentClick);
            // 
            // stu_no
            // 
            this.stu_no.DataPropertyName = "stu_no";
            this.stu_no.HeaderText = "学号";
            this.stu_no.Name = "stu_no";
            // 
            // stu_name
            // 
            this.stu_name.DataPropertyName = "stu_name";
            this.stu_name.HeaderText = "姓名";
            this.stu_name.Name = "stu_name";
            // 
            // stu_major
            // 
            this.stu_major.DataPropertyName = "stu_major";
            this.stu_major.HeaderText = "专业";
            this.stu_major.Name = "stu_major";
            // 
            // stu_class
            // 
            this.stu_class.DataPropertyName = "stu_class";
            this.stu_class.HeaderText = "班级";
            this.stu_class.Name = "stu_class";
            // 
            // exam_no
            // 
            this.exam_no.DataPropertyName = "exam_no";
            this.exam_no.HeaderText = "场次";
            this.exam_no.Name = "exam_no";
            // 
            // chinese
            // 
            this.chinese.DataPropertyName = "chinese";
            this.chinese.HeaderText = "语文";
            this.chinese.Name = "chinese";
            // 
            // math
            // 
            this.math.DataPropertyName = "math";
            this.math.HeaderText = "数学";
            this.math.Name = "math";
            // 
            // english
            // 
            this.english.DataPropertyName = "english";
            this.english.HeaderText = "外语";
            this.english.Name = "english";
            // 
            // FrmGradeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DVGradeSea);
            this.Name = "FrmGradeSearch";
            this.TabText = "成绩查询";
            this.Text = "成绩查询";
            this.Load += new System.EventHandler(this.FrmGradeSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVGradeSea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DVGradeSea;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_major;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn chinese;
        private System.Windows.Forms.DataGridViewTextBoxColumn math;
        private System.Windows.Forms.DataGridViewTextBoxColumn english;
    }
}