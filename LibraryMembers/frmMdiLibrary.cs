using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryMembers
{
    public partial class frmMdiLibrary : Form
    {
        private int childFormNumber = 0;

        public frmMdiLibrary()
        {
            InitializeComponent();
        }

        private void registerNwMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form boks = new frmBooks();
            boks.MdiParent = this;
            boks.Show();
        }

        private void regMember1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmReg = new frmRegister();
            frmReg.MdiParent = this;
            frmReg.Show();
        }

        private void dlMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLagv = new frmLaghveoviiat();
            frmLagv.MdiParent = this;
            frmLagv.Show();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void karnarenjadidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmKarbar = new frmKarbarejadid();
            frmKarbar.MdiParent = this;
            frmKarbar.Show();
        }

        private void edtkarbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmTaviz = new frmTavizepassword();
            frmTaviz.MdiParent = this;
            frmTaviz.Show();
        }

        private void tahvilKotobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmTahvil = new frmTahvileketab();
            frmTahvil.MdiParent = this;
            frmTahvil.Show();
        }

        private void baGashteketabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBazgasht = new frmBazgashteketab();
            frmBazgasht.MdiParent = this;
            frmBazgasht.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("سیستم نرم افزاری کتابخانه" + "\n" + "زبان برنامه نویسی : سی شارپ " + "\n" + "پایگاه داده: SQL SERVER");
        }

        private void sbJectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSS = new frmSbj();
            frmSS.MdiParent = this;
            frmSS.Show();
        }


        private void mojazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTedadeMojazeTahvil frm = new frmTedadeMojazeTahvil();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bedehiPardakhtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBedehiPardakht frm = new frmBedehiPardakht();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tamdid2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTamdideozviiat frm = new frmTamdideozviiat();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
