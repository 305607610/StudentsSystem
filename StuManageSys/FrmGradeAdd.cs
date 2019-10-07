using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Data;
using System.Data.SqlClient;

namespace StuManageSys
{
    public partial class FrmGradeAdd : DockContent
    {
        Student student = new Student();
        DataBase dataBase = new DataBase();
        public FrmGradeAdd()
        {
            InitializeComponent();
        }

        private void FrmGradeAdd_Load(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            string strSQL = @"INSERT INTO [dbo].[grade]
                           ([stu_no]
                           ,[exam_no]
                           ,[subject]
                           ,[grade])
                     VALUES
                           ( '" + txtStuNo.Text.Trim() + @"'
                           , '" + txtStuChangci.Text.Trim() + @"'
                           , '" + txtStuKemu.Text.Trim() + @"'
                           , '" + txtStuGrade.Text.Trim() + "')";
            int r = dataBase.RunSql(strSQL);
            if (r == 1)
            {
                MessageBox.Show("添加成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("添加失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtStuNo_Click(object sender, EventArgs e)
        {

        }

        private void TxtStuNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {

                String strSQL = "SELECT * FROM [dbo].[students] WHERE stu_no = '" + txtStuNo.Text.Trim() + "'";
                SqlDataReader rd = dataBase.GetDR(strSQL);
                rd.Read();

                if (txtStuNo.Text.Trim() != rd["stu_no"].ToString())
                {
                    MessageBox.Show("学号信息不存在", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    student.stu_no = txtStuNo.Text.Trim();

                    txtSTuName.Text = rd["stu_name"].ToString();
                    txtStuMajor.Text = rd["stu_major"].ToString();
                    txtStuClass.Text = rd["stu_class"].ToString();
                    rd.Close();
                }

            }
        }

        private void BtnGai_Click(object sender, EventArgs e)
        {

        }
    }
}
