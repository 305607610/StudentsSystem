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

namespace StuManageSys
{
    public partial class FrmStuSearch : DockContent
    {
        DataBase dataBase = new DataBase();
        public FrmStuSearch()
        {
            InitializeComponent();
        }

        private void FrmStuSearch_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT stu_no, stu_name, stu_major, stu_class, stu_sex, stu_age, stu_nat, stu_card FROM students";
            DataSet dataSet = dataBase.GetDS(strSQL, "students");
            DGViewStu.DataSource = dataSet.Tables["students"];
        }

        private void DGViewStu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
