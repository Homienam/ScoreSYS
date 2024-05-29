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
    public partial class RemoveScore : Form
    {
        public RemoveScore()
        {
            InitializeComponent();
        }
        Diem score = new Diem();
        private void RemoveScore_Load(object sender, EventArgs e)
        {
            //dien vao datagridview voi diem cua sinh vien 
            dataGridView1.DataSource = score.getdiemHS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // xoa khoa hoc tuong ung
            int studentid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseid = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            
            if(MessageBox.Show("ban muon xoa diem nay","Xoa diem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                if (score.deleteScore(studentid,courseid))
                {
                    MessageBox.Show("diem da xoa", "Xoa diem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("diem chua xoa", "Xoa diem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
