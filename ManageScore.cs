using MySql.Data.MySqlClient;
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
    public partial class ManageScore : Form
    {
        public ManageScore()
        {
            InitializeComponent();
        }
        Diem score = new Diem();
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        string data = "score";
        private void ManageScore_Load(object sender, EventArgs e)
        {
            //fill combobox voi khoa hoc
            cbBcourse2.DataSource = course.getAllCourses();
            cbBcourse2.DisplayMember = "label";
            cbBcourse2.ValueMember = "id";

            cbBcourse2.SelectedItem = null;

            cbBid2.DataSource = student.getStudents();
            cbBid2.DisplayMember = "id";
            cbBid2.ValueMember = "id";

            cbBid2.SelectedItem = null;
            //fill datagridview voi diem sinh vien
            dataGridView2.DataSource = score.getdiemHS();

        }
        //hien du lieu hoc sinh tren datagridview
        private void buttonShowSV_Click(object sender, EventArgs e)
        {
            data = "student";
            //MySqlCommand command = new MySqlCommand("SELECT `id`, `Name`, `Ngày sinh`, `Gioi tinh` FROM `student`");
            dataGridView2.DataSource = student.getStudents(); //command
        }

        private void buttonShowScore_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridView2.DataSource = score.getdiemHS();
        }
        //lay data tu datagridview
        private void dataGridView2_Click(object sender, EventArgs e)
        {
            getdatafromDatagridview();
        }
        public void getdatafromDatagridview()
        {   
            //neu nguoi dung chon chi hien du lieu sinh vien thi ta chi hien 1 minh studentid
            if(data == "student")
            {
                cbBid2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            }
            //neu nguoi dung chon chi hien du lieu sinh vien thi ta hien studentid*
            //*chon khochoc tu combobox cbB2
            else if (data == "score")
            {
                cbBid2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                cbBcourse2.SelectedValue = dataGridView2.CurrentRow.Cells[2].Value;
            }
         
          

        }
        //nut them diem
        private void buttonAddDiem2_Click(object sender, EventArgs e)
        {
            try
            {
                int studentid = Convert.ToInt32(cbBid2.Text);
                int courseid = Convert.ToInt32(cbBcourse2.SelectedValue);
                double scoreValue = Convert.ToDouble(txtScore2.Text);
                string description = txtBio2.Text;

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
                MessageBox.Show("ko hop le/chua dien", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //nut xoa diem
        private void buttonXoaDiem_Click(object sender, EventArgs e)
        {
            // xoa khoa hoc tuong ung
            try
            {
                int studentid = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                int courseid = int.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());

                if (MessageBox.Show("ban muon xoa diem nay", "Xoa diem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(studentid, courseid))
                    {
                        MessageBox.Show("diem da xoa", "Xoa diem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("diem chua xoa", "Xoa diem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ko hop le/chua dien", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //nut diem tb
        private void buttonDiemTB_Click(object sender, EventArgs e)
        {
            diemTBtheokhoahoc avscre = new diemTBtheokhoahoc();
            avscre.Show(this);
        }

        private void txtScore2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore2.Text, out int score) && (score < 0 || score > 10))
            {
                MessageBox.Show("Giá trị không hợp lệ", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtScore2.Text = ""; // Đặt lại giá trị của txtScore.Text về rỗng
            }
            else
            {
                // Giá trị nhập vào hợp lệ
            }
        }
    }
}
