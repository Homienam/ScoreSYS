using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_idk
{
    public partial class adddiem : Form
    {
        public adddiem()
        {
            InitializeComponent();
        }
        Diem score = new Diem();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        
        // bat su kien load cua form
        private void adddiem_Load(object sender, EventArgs e)
        {
            cbBcourse.DataSource = course.getAllCourses();
            cbBcourse.DisplayMember = "label";
            cbBcourse.ValueMember = "id";

            cbBcourse.SelectedItem = null;

            cbBid.DataSource = student.getStudents();
            cbBid.DisplayMember = "id";
            cbBid.ValueMember = "id";
            // hien thi o datagridview voi du lieu tu database sinhvien(name,ngaysinh,gioitinh)
            MySqlCommand command = new MySqlCommand("SELECT `id`,`Name`, `Ngày sinh`, `Gioi tinh` FROM `student`");
            dataGridView1.DataSource = student.getStudents();
        }

        private void cbBcourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonAddDiem_Click(object sender, EventArgs e)
        {
            //them diem moi
            try
            {
                int studentid = Convert.ToInt32(cbBid.Text);
                int courseid = Convert.ToInt32(cbBcourse.SelectedValue);
                double scoreValue = Convert.ToDouble(txtScore.Text);
                string description = txtBio.Text;

                if (!score.diemHSexists(studentid, courseid))
                {
                    if (score.insertdiem(studentid, courseid, scoreValue, description))
                    {
                        MessageBox.Show("diem da duoc them", "them diem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("diem chua duoc them vao", "them diem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("diem nay da co trong database", "them diem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("ko hop le/chua dien",ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore.Text, out int score) && (score < 0 || score > 10))
            {
                MessageBox.Show("Giá trị không hợp lệ", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtScore.Text = ""; // Đặt lại giá trị của txtScore.Text về rỗng
            }
            else
            {
                // Giá trị nhập vào hợp lệ
            }
        }
    }
}
