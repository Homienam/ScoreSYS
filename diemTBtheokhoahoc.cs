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
    public partial class diemTBtheokhoahoc : Form
    {
        public diemTBtheokhoahoc()
        {
            InitializeComponent();
        }

        private void diemTBtheokhoahoc_Load(object sender, EventArgs e)
        {
            //fill datagridview voi diem tb theo khoa hoc
            Diem score = new Diem();
            dataGridView3.DataSource = score.avgscorebycourse();
        }
    }
}
