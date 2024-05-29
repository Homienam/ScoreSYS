using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_idk
{
     class STUDENT
    {
        MY_DB db = new MY_DB();
        //tạo hàm để thêm sinh viên vào cơ sở dữ liệu
        public bool insertStudent(string name, DateTime bdate, string gender, string course, string major, string address, string sdt)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`Name`, `Ngày sinh`, `Gioi tinh`, `Khóa`, `Ngành`, `Địa chỉ`, `sdt`) VALUES (@n,@bd,@gdr,@c,@m,@a,@num)", db.GetConnection());

            //@n,@bd,@gdr,@c,@m,@a,@num
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@c", MySqlDbType.VarChar).Value = course;
            command.Parameters.Add("@m", MySqlDbType.VarChar).Value = major;
            command.Parameters.Add("@a", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = sdt;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
            public DataTable getStudents()
            {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
            }
        
      
    }
}
