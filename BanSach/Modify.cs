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
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                
                    sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read()) { }
                {
                    taikhoan.Add (new TaiKhoan( dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taikhoan;
        }
    }
}
