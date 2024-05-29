using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_idk
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aDDSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSinhvien_Form addstdf = new AddSinhvien_Form();
            addstdf.Show(this);
        }

        private void aDDCOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCrse = new AddCourseForm();
            addCrse.Show(this);
        }

        private void aDDSCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adddiem addscore = new adddiem();
            addscore.Show(this);
        }

        private void rEMOVESCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScore rmv = new RemoveScore();
            rmv.Show(this);
        }

        private void mANAGESCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScore mng = new ManageScore();
            mng.Show(this);
        }

        private void aVERAGESCOREBYCOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diemTBtheokhoahoc avgsc = new diemTBtheokhoahoc();
            avgsc.Show(this);
        }

        private void sCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
