namespace StuManageSys
{
    partial class FrmGradeAdd
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lalStuNo = new System.Windows.Forms.Label();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.lalStuName = new System.Windows.Forms.Label();
            this.lalStuMajor = new System.Windows.Forms.Label();
            this.lalStuClass = new System.Windows.Forms.Label();
            this.lalStuChangci = new System.Windows.Forms.Label();
            this.lalStuKemu = new System.Windows.Forms.Label();
            this.txtSTuName = new System.Windows.Forms.TextBox();
            this.txtStuMajor = new System.Windows.Forms.TextBox();
            this.txtStuClass = new System.Windows.Forms.TextBox();
            this.txtStuChangci = new System.Windows.Forms.TextBox();
            this.txtStuKemu = new System.Windows.Forms.TextBox();
            this.lalStuGrade = new System.Windows.Forms.Label();
            this.txtStuGrade = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lalStuNo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtStuNo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lalStuName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lalStuMajor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lalStuClass, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lalStuChangci, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lalStuKemu, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtSTuName, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtStuMajor, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtStuClass, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtStuChangci, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtStuKemu, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lalStuGrade, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtStuGrade, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 2, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // lalStuNo
            // 
            this.lalStuNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lalStuNo.AutoSize = true;
            this.lalStuNo.Location = new System.Drawing.Point(88, 25);
            this.lalStuNo.Name = "lalStuNo";
            this.lalStuNo.Size = new System.Drawing.Size(29, 12);
            this.lalStuNo.TabIndex = 0;
            this.lalStuNo.Text = "学号";
            // 
            // txtStuNo
            // 
            this.txtStuNo.Location = new System.Drawing.Point(120, 20);
            this.txtStuNo.Margin = new System.Windows.Forms.Padding(0);
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.Size = new System.Drawing.Size(250, 21);
            this.txtStuNo.TabIndex = 1;
            this.txtStuNo.Click += new System.EventHandler(this.TxtStuNo_Click);
            this.txtStuNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtStuNo_KeyDown);
            // 
            // lalStuName
            // 
            this.lalStuName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lalStuName.AutoSize = true;
            this.lalStuName.Location = new System.Drawing.Point(88, 48);
            this.lalStuName.Name = "lalStuName";
            this.lalStuName.Size = new System.Drawing.Size(29, 12);
            this.lalStuName.TabIndex = 2;
            this.lalStuName.Text = "姓名";
            // 
            // lalStuMajor
            // 
            this.lalStuMajor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lalStuMajor.AutoSize = true;
            this.lalStuMajor.Location = new System.Drawing.Point(88, 72);
            this.lalStuMajor.Name = "lalStuMajor";
            this.lalStuMajor.Size = new System.Drawing.Size(29, 12);
            this.lalStuMajor.TabIndex = 4;
            this.lalStuMajor.Text = "专业";
            // 
            // lalStuClass
            // 
            this.lalStuClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lalStuClass.AutoSize = true;
            this.lalStuClass.Location = new System.Drawing.Point(88, 94);
            this.lalStuClass.Name = "lalStuClass";
            this.lalStuClass.Size = new System.Drawing.Size(29, 12);
            this.lalStuClass.TabIndex = 3;
            this.lalStuClass.Text = "班级";
            // 
            // lalStuChangci
            // 
            this.lalStuChangci.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lalStuChangci.AutoSize = true;
            this.lalStuChangci.Location = new System.Drawing.Point(64, 117);
            this.lalStuChangci.Name = "lalStuChangci";
            this.lalStuChangci.Size = new System.Drawing.Size(53, 12);
            this.lalStuChangci.TabIndex = 5;
            this.lalStuChangci.Text = "考试场次";
            // 
            // lalStuKemu
            // 
            this.lalStuKemu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lalStuKemu.AutoSize = true;
            this.lalStuKemu.Location = new System.Drawing.Point(64, 140);
            this.lalStuKemu.Name = "lalStuKemu";
            this.lalStuKemu.Size = new System.Drawing.Size(53, 12);
            this.lalStuKemu.TabIndex = 6;
            this.lalStuKemu.Text = "考试科目";
            // 
            // txtSTuName
            // 
            this.txtSTuName.Location = new System.Drawing.Point(120, 42);
            this.txtSTuName.Margin = new System.Windows.Forms.Padding(0);
            this.txtSTuName.Name = "txtSTuName";
            this.txtSTuName.Size = new System.Drawing.Size(250, 21);
            this.txtSTuName.TabIndex = 7;
            // 
            // txtStuMajor
            // 
            this.txtStuMajor.Location = new System.Drawing.Point(120, 67);
            this.txtStuMajor.Margin = new System.Windows.Forms.Padding(0);
            this.txtStuMajor.Name = "txtStuMajor";
            this.txtStuMajor.Size = new System.Drawing.Size(250, 21);
            this.txtStuMajor.TabIndex = 8;
            // 
            // txtStuClass
            // 
            this.txtStuClass.Location = new System.Drawing.Point(120, 89);
            this.txtStuClass.Margin = new System.Windows.Forms.Padding(0);
            this.txtStuClass.Name = "txtStuClass";
            this.txtStuClass.Size = new System.Drawing.Size(250, 21);
            this.txtStuClass.TabIndex = 9;
            // 
            // txtStuChangci
            // 
            this.txtStuChangci.Location = new System.Drawing.Point(120, 112);
            this.txtStuChangci.Margin = new System.Windows.Forms.Padding(0);
            this.txtStuChangci.Name = "txtStuChangci";
            this.txtStuChangci.Size = new System.Drawing.Size(250, 21);
            this.txtStuChangci.TabIndex = 10;
            // 
            // txtStuKemu
            // 
            this.txtStuKemu.Location = new System.Drawing.Point(120, 135);
            this.txtStuKemu.Margin = new System.Windows.Forms.Padding(0);
            this.txtStuKemu.Name = "txtStuKemu";
            this.txtStuKemu.Size = new System.Drawing.Size(250, 21);
            this.txtStuKemu.TabIndex = 11;
            // 
            // lalStuGrade
            // 
            this.lalStuGrade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lalStuGrade.AutoSize = true;
            this.lalStuGrade.Location = new System.Drawing.Point(64, 163);
            this.lalStuGrade.Name = "lalStuGrade";
            this.lalStuGrade.Size = new System.Drawing.Size(53, 12);
            this.lalStuGrade.TabIndex = 12;
            this.lalStuGrade.Text = "考试成绩";
            // 
            // txtStuGrade
            // 
            this.txtStuGrade.Location = new System.Drawing.Point(120, 158);
            this.txtStuGrade.Margin = new System.Windows.Forms.Padding(0);
            this.txtStuGrade.Name = "txtStuGrade";
            this.txtStuGrade.Size = new System.Drawing.Size(250, 21);
            this.txtStuGrade.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(120, 181);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FrmGradeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmGradeAdd";
            this.TabText = "成绩管理";
            this.Text = "成绩管理";
            this.Load += new System.EventHandler(this.FrmGradeAdd_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lalStuNo;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.Label lalStuName;
        private System.Windows.Forms.Label lalStuMajor;
        private System.Windows.Forms.Label lalStuClass;
        private System.Windows.Forms.Label lalStuChangci;
        private System.Windows.Forms.Label lalStuKemu;
        private System.Windows.Forms.TextBox txtSTuName;
        private System.Windows.Forms.TextBox txtStuMajor;
        private System.Windows.Forms.TextBox txtStuClass;
        private System.Windows.Forms.TextBox txtStuChangci;
        private System.Windows.Forms.TextBox txtStuKemu;
        private System.Windows.Forms.Label lalStuGrade;
        private System.Windows.Forms.TextBox txtStuGrade;
        private System.Windows.Forms.Button btnAdd;
    }
}