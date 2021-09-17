using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class TRASACH
    {
        MY_DB mydb = new MY_DB();
        public bool insertSachTra(int masach, int mamuontra, string tensach, int masinhvien, string hoten, int soluong, DateTime ngaytra)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SACHTRA (Masach,Mamuontra,Tensach,Masinhvien,Hoten,Soluongtra,Ngaytra)" + "VALUES (@ms,@mmt,@ts,@msv,@ht,@slt,@nt)", mydb.getConnection);
            command.Parameters.Add("@ms", SqlDbType.Int).Value = masach;
            command.Parameters.Add("@mmt", SqlDbType.Int).Value = mamuontra;
            command.Parameters.Add("@ts", SqlDbType.VarChar).Value = tensach;
            command.Parameters.Add("@msv", SqlDbType.Int).Value = masinhvien;
            command.Parameters.Add("@ht", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@slt", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@nt", SqlDbType.DateTime).Value = ngaytra;
            mydb.openConnection();
            //()
            if ((command.ExecuteNonQuery() == -1))
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

        public DataTable getSach(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;

        }
    }
}