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
using Microsoft.Win32;
using System.Net;
using System.Net.Sockets;

namespace StuManageSys
{
    public partial class FrmLogin : Form
    {
        DataBase dataBase = new DataBase();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
         
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string user_id = txtUser.Text.Trim();
            string user_pwd = txtPwd.Text;
            
            if(CBType.SelectedIndex == 0)
            {
                SqlDataReader sdr = dataBase.GetDR("SELECT * FROM userinfo WHERE user_id = '" + user_id + "'");
                while (sdr.Read())
                {
                    if (sdr["user_id"].ToString() == user_id && sdr["user_pwd"].ToString() == user_pwd)
                    {
                        //MessageBox.Show("登陆成功","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        FrmMain.user_id = user_id;
                        FrmMain.user_group = "A";
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("登录失败，用户名或密码错误", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUser.Text = "";
                        txtPwd.Text = "";
                    }
                }

            }
            else if(CBType.SelectedIndex == 1)
            {
                SqlDataReader sdr = dataBase.GetDR("SELECT * FROM students WHERE stu_no = '" + user_id + "'");
                while (sdr.Read())
                {
                    if (sdr["stu_no"].ToString() == user_id && sdr["stu_pwd"].ToString() == user_pwd)
                    {
                        //MessageBox.Show("登陆成功","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        FrmMain.user_id = user_id;
                        FrmMain.user_group = "B";
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("登录失败，用户名或密码错误", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUser.Text = "";
                        txtPwd.Text = "";
                    }
                }
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LalRes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRes frmRes = new FrmRes();
            frmRes.ShowDialog();
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
