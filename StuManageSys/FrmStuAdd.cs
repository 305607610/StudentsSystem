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
    public partial class FrmStuAdd : DockContent
    {
        DataBase dataBase = new DataBase();
        Student student = new Student();

        SqlDataReader rd;
        public FrmStuAdd()
        {
            InitializeComponent();
        }

        private void FrmStuAdd_Load(object sender, EventArgs e)
        {

        }

        private void BtnStuAdd_Click(object sender, EventArgs e)
        {
            student.stu_no = txtStuNo.Text.Trim();
            student.stu_name = txtStuName.Text.Trim();
            student.stu_major = txtStuMajor.Text.Trim();
            student.stu_class = txtStuClass.Text.Trim();
            student.stu_sex = txtStuSex.Text.Trim();
            student.stu_age = int.Parse(txtStuAge.Text.Trim());
            student.stu_nat = txtStuNat.Text.Trim();
            student.stu_card = txtStuCard.Text.Trim();
            student.stu_pwd = student.stu_card.Substring(12, 6);
            
            string strSQL = @"INSERT INTO [dbo].[students]
                           ([stu_no]
                           ,[stu_name]
                           ,[stu_major]
                           ,[stu_class]
                           ,[stu_sex]
                           ,[stu_age]
                           ,[stu_nat]
                           ,[stu_card]
                           ,[stu_pwd])
                     VALUES
                           ( '" + student.stu_no + @"'
                           , '" + student.stu_name + @"'
                           , '" + student.stu_major + @"'
                           , '" + student.stu_class + @"'
                           , '" + student.stu_sex + @"'
                           , '" + student.stu_age + @"'
                           , '" + student.stu_nat + @"'
                           , '" + student.stu_card + @"'
                           , '" + student.stu_pwd + "')";
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

        private void BtnGai_Click(object sender, EventArgs e)
        {
            student.stu_no = txtStuNo.Text.Trim();
            student.stu_name = txtStuName.Text.Trim();
            student.stu_major = txtStuMajor.Text.Trim();
            student.stu_class = txtStuClass.Text.Trim();
            student.stu_sex = txtStuSex.Text.Trim();
            student.stu_age = int.Parse(txtStuAge.Text.Trim());
            student.stu_nat = txtStuNat.Text.Trim();
            student.stu_card = txtStuCard.Text.Trim();
            student.stu_pwd = txtStuPwd.Text;
            String strSQL = "SELECT * FROM [dbo].[students] WHERE stu_no = '" + txtStuNo.Text.Trim() + "'";
            rd = dataBase.GetDR(strSQL);
            if (rd.Read())
            {
                string strSQL2 = @"UPDATE [dbo].[students] SET
                           
                            [stu_name] = '" + student.stu_name + @"'
                           ,[stu_major] =  '" + student.stu_major + @"'
                           ,[stu_class] = '" + student.stu_class + @"'
                           ,[stu_sex] = '" + student.stu_sex + @"'
                           ,[stu_age] = '" + student.stu_age + @"'
                           ,[stu_nat] = '" + student.stu_nat + @"'
                           ,[stu_card] = '" + student.stu_card + @"'
                           ,[stu_pwd] = '" + student.stu_pwd + @"'
                    WHERE  [stu_no] = '" + student.stu_no + "'";
                int r = dataBase.RunSql(strSQL2);
                if (r == 1)
                {
                    MessageBox.Show("修改成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("修改失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void TxtStuNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
               
                String strSQL = "SELECT * FROM [dbo].[students] WHERE stu_no = '" + txtStuNo.Text.Trim() + "'";
                rd = dataBase.GetDR(strSQL);
                rd.Read();

                if (txtStuNo.Text.Trim() != rd["stu_no"].ToString())
                {
                    MessageBox.Show("学号信息不存在", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    student.stu_no = txtStuNo.Text.Trim();

                    txtStuName.Text = rd["stu_name"].ToString();
                    txtStuMajor.Text = rd["stu_major"].ToString();
                    txtStuClass.Text = rd["stu_class"].ToString();
                    txtStuSex.Text = rd["stu_sex"].ToString();
                    txtStuAge.Text = rd["stu_age"].ToString();
                    txtStuNat.Text = rd["stu_nat"].ToString();
                    txtStuCard.Text = rd["stu_card"].ToString();
                    txtStuPwd.Text = rd["stu_pwd"].ToString();
                    rd.Close();
                }
                
            }
            
        }

        private void Btndel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确认要删除" + txtStuNo.Text.Trim() + "的信息吗？","信息提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int r = dataBase.RunSql("DELETE students WHERE [stu_no] = '" + txtStuNo.Text.Trim() + "'");
                if (r == 1)
                {
                    MessageBox.Show("删除成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }

        private void TxtStuNo_Click(object sender, EventArgs e)
        {

        }
    }
}
