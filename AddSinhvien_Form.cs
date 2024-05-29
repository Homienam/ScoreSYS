using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_idk
{
    public partial class AddSinhvien_Form : Form
    {
        public AddSinhvien_Form()
        {
            InitializeComponent();
        }

        private void buttonAddSinhvien_Click(object sender, EventArgs e)
        {
            //add new student
            STUDENT student = new STUDENT();
            string name = txbName.Text.Trim();
            DateTime bdate = dtpdate.Value;
            string gender = txbGender.Text.Trim();
            string course = txbKhoa.Text.Trim();
            string major = txtNganh.Text.Trim();
            string address = txbDiachi.Text.Trim();
            string sdt = txbSdt.Text.Trim();

            if (student.insertStudent(name, bdate, gender, course, major, address, sdt))
            {
                MessageBox.Show("hien ra", "confirm", MessageBoxButtons.OK);
            }
        } 
    }
}
