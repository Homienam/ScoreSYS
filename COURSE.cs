using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Project_idk
{
    class COURSE
    {
        MY_DB mydb = new MY_DB();

        //tao ham de nhap khoa hoc
        public bool insertCourse (string courseName, int hoursNumber, string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `chuongtrinh`(`label`, `hours_number`, `description`) VALUES (@name,@hours,@dscr)", mydb.GetConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hours", MySqlDbType.Int32).Value = hoursNumber;
            command.Parameters.Add("@dscr", MySqlDbType.VarChar).Value = description;

            mydb.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //tao ra 1 ham de lay tat ca cac khoa hoc(courses)
        public DataTable getAllCourses()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `chuongtrinh`", mydb.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}
