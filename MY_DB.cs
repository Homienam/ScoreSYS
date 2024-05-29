using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_idk
{
     class MY_DB // tạo kết nối tới database
    {
        private MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=test"); //phần kết nối
        //tao hàm để có kết nối
        public MySqlConnection GetConnection()
        {
                return con;
        }
        //tạo hàm để mở kết nối 
        public void openConnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
