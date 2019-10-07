using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace StuManageSys
{
    public partial class FrmRes : Form
    {
        DataBase dataBase = new DataBase();
        public FrmRes()
        {
            InitializeComponent();
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            string user_id = txtUser.Text.Trim();
            string user_pwd = txtPwd.Text;
            
            string strSQL = @"INSERT INTO [dbo].[userinfo]
                            ([user_id]
                            ,[user_pwd]) 
                        VALUES
                            ('" + user_id + @"'
                            , '" + user_pwd + @"')";
            
                int r = dataBase.RunSql(strSQL);
 
            if(r == 1)
            {
                MessageBox.Show("注册成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("注册失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
