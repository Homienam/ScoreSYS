using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_idk
{
     class Diem
    {
        MY_DB mydb = new MY_DB();
        //tao ham de dien diem so moi
        public bool insertdiem(int studentid,int courseid, double score, string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`studentid`, `courseid`, `score`, `description`) VALUES (@sid,@cid,@scre,@des)", mydb.GetConnection());

            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentid;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseid;
            command.Parameters.Add("@scre", MySqlDbType.Double).Value = score;
            command.Parameters.Add("@des", MySqlDbType.VarChar).Value = description;

            mydb.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //tao ra 1 ham de kiem tra xem co 1 diem cua 1 hoc sinh trong khoa hoc co bi trung voi thong tin co trong database hay khong
        public bool diemHSexists(int studentid,int courseid)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `studentid` =@sid AND `courseid` = @cid",mydb.GetConnection());

            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentid;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseid;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            { 
               return true;
            }

        }
        //tao ra ham de them diem hoc sinh
        public DataTable getdiemHS()
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = mydb.GetConnection();

            command.CommandText = ("SELECT score.studentid,student.name,score.courseid,chuongtrinh.label,score.score FROM student INNER JOIN score ON student.id = score.studentid INNER JOIN chuongtrinh ON score.courseid = chuongtrinh.id");
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        //ham de xoa diem cua sinh vien
        public bool deleteScore(int studentid,int courseid)
        {

            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `studentid`=@sid AND `courseid` =@cid",mydb.GetConnection());

            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentid;
            command.Parameters.Add("cid", MySqlDbType.Int32).Value = courseid;

            mydb.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //tao ra ham de lay diem trung binh theo khoa
        public DataTable avgscorebycourse()
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = mydb.GetConnection();

            command.CommandText = ("SELECT chuongtrinh.label, avg(score.score) as 'Average Score' FROM chuongtrinh, score WHERE chuongtrinh.id = score.courseid GROUP BY chuongtrinh.label");
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

    }
}
