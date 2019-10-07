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
    public partial class FrmMenu : DockContent
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void LalStuMan_Click(object sender, EventArgs e)
        {
            FrmStuAdd add = new FrmStuAdd();
            //FrmMain main = (FrmMain)this.Parent.Parent.Parent.Parent;
            //main.IsMdiContainer = true;
            //add.MdiParent = main;
            //add.DockHandler.Show(main.dockPanel1);
            OpenForm(add);
        }

        private void LalGradeAdd_Click(object sender, EventArgs e)
        {
            FrmGradeAdd add = new FrmGradeAdd();
            //FrmMain main = (FrmMain)this.Parent.Parent.Parent.Parent;
            //main.IsMdiContainer = true;
            //add.MdiParent = main;
            //add.DockHandler.Show(main.dockPanel1);
            OpenForm(add);
        }

        private void LalStuSea_Click(object sender, EventArgs e)
        {
            FrmStuSearch frmStuSearch = new FrmStuSearch();
            //FrmMain main = (FrmMain)this.Parent.Parent.Parent.Parent;
            //main.IsMdiContainer = true;
            //frmStuSearch.MdiParent = main;
            //frmStuSearch.DockHandler.Show(main.dockPanel1);
            OpenForm(frmStuSearch);
        }

        private void LalGradeSea_Click(object sender, EventArgs e)
        {
            FrmGradeSearch search = new FrmGradeSearch();
            //FrmMain main = (FrmMain)this.Parent.Parent.Parent.Parent;
            //main.IsMdiContainer = true;
            //search.MdiParent = main;
            //search.DockHandler.Show(main.dockPanel1);
            OpenForm(search);
        }
        private void OpenForm(DockContent frm)
        {
            FrmMain main = (FrmMain)this.Parent.Parent.Parent.Parent;
            string name = frm.Name;
            foreach(Form item in main.MdiChildren)
            {
                if(item.Name == name)
                {
                    item.Activate();
                    return;
                }
            }
            frm.MdiParent = main;
            frm.DockHandler.Show(main.dockPanel1);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            string user_group = FrmMain.user_group;
            if(user_group == "B")
            {
                lalStuMan.Enabled = false;
                lalStuSea.Enabled = false;
                lalGradeAdd.Enabled = false;
                
            }

        }
    }
}
