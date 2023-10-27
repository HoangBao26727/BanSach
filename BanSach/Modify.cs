using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BanSach
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<TaiKhoan> TaiKhoan(String query)
        {
            List<TaiKhoan> taikhoan = new List<TaiKhoan>();
            using (SqlConnection sqlconnection = Connection.GetSqlConnection())
            {
                sqlconnection.Open();
                sqlCommand = new SqlCommand(query, sqlconnection);
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read()) { }
                {
                    taikhoan.Add (new TaiKhoan( dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlconnection.Close();
            }
            return taikhoan;
        }
    }
}
