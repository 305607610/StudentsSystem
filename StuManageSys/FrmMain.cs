using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuManageSys
{
    public partial class FrmMain : Form
    {
        public static string user_id;
        public static string user_group;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelUser.Text = user_id;
            toolStripStatusLabelUser.Text = user_group;
         
          
                FrmMenu menu = new FrmMenu();
            menu.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
            dockPanel1.DockLeftPortion = 250;

            FrmHome home = new FrmHome();
            home.Show(dockPanel1);
        }

        private void ToolStripStatusLabelUser_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelUser.Text = user_id;
        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGradeAdd add = new FrmGradeAdd();
            add.Show(dockPanel1);
        }

        private void ToolStripMenuItemStuMan_Click(object sender, EventArgs e)
        {
            FrmStuAdd add = new FrmStuAdd();
            add.Show(dockPanel1);
        }

        private void ToolStripMenuItemSea_Click(object sender, EventArgs e)
        {
            FrmStuSearch stuSearch = new FrmStuSearch();
            stuSearch.Show(dockPanel1);
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGradeSearch search = new FrmGradeSearch();
            search.Show(dockPanel1);
        }

        private void DockPanel1_ActiveContentChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabelGroup_Click(object sender, EventArgs e)
        {

        }
    }
}
