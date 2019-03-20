using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLCAFE_Model;

namespace QLCAFE_VM
{
    public class LoginVM
    {
        private string connectionString = "Data Source=DESKTOP-H75CAQB;Initial Catalog=QLCAFE;Integrated Security=True";

        public bool Login(string userName, string password)
        {
            bool result = false;
            string query = "SELECT * FROM NhanVien WHERE [TenDangNhap] = @TenDangNhap";
            Login login = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@TenDangNhap", userName);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader;
                        reader = command.ExecuteReader();
                        if (reader.HasRows == true)
                            while (reader.Read())
                                login = new Login(reader["MaNV"].ToString(), reader["HoTen"].ToString(),
                                    reader["TenDangNhap"].ToString(), reader["MatKhau"].ToString());
                    

                        if (login != null)
                        {
                            if (login.Password.Equals(password) && login.UserName.Equals(userName))
                                result = true;
                            else
                                result = false;
                        }
                        return result;

                    }
                    catch(Exception e)
                    {
                        connection.Close();
                        System.Console.WriteLine(e.Message);
                        return false;
                    }
                }
            } 
        }
    }
}
