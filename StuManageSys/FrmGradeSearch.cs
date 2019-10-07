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
    public partial class FrmGradeSearch : DockContent
    {
        DataBase dataBase = new DataBase();
        public FrmGradeSearch()
        {
            InitializeComponent();
        }

        private void FrmGradeSearch_Load(object sender, EventArgs e)
        {
            string user_group = FrmMain.user_group;
            string stu_no = FrmMain.user_id;
            if (user_group == "A")
            {
                string strSQL = @"select  a.stu_no,
                                    a.stu_name,
		                            a.stu_major,
		                            a.stu_class,
                                    b.exam_no,
		                            sum(case when b.subject = '语文' then b.grade else null end) as chinese, 
		                            sum(case when b.subject = '数学' then b.grade else null end) as math, 
		                            sum(case when b.subject = '外语' then b.grade else null end) as english 
                            from students AS a
                            Left join grade b ON a.stu_no = b.stu_no

                            group by a.stu_no,
				                    a.stu_name,
				                    a.stu_major,
				                    a.stu_class,
                                    b.exam_no";
                DataSet ds = dataBase.GetDS(strSQL, "grade");
                DVGradeSea.DataSource = ds.Tables["grade"];
            }
            else
            {
                string strSQL = @"select  a.stu_no,
                                    a.stu_name,
		                            a.stu_major,
		                            a.stu_class,
                                    b.exam_no,
		                            sum(case when b.subject = '语文' then b.grade else null end) as chinese, 
		                            sum(case when b.subject = '数学' then b.grade else null end) as math, 
		                            sum(case when b.subject = '外语' then b.grade else null end) as english 
                            from students AS a
                            Left join grade b ON a.stu_no = b.stu_no
                            where a.stu_no = '" + stu_no + @"'
                            group by a.stu_no,
				                    a.stu_name,
				                    a.stu_major,
				                    a.stu_class,
                                    b.exam_no";
                DataSet ds = dataBase.GetDS(strSQL, "grade");
                DVGradeSea.DataSource = ds.Tables["grade"];
            }

        }

        private void DVGradeSea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
