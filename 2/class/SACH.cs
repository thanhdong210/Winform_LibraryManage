using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class SACH
    {
        MY_DB mydb = new MY_DB();
        public bool insertSach(int masach, string tensach, string loaisach,string tentacgia, DateTime namxb, int soluong,int manxb)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TTSACH (Masach,Tensach,Loaisach, Tentacgia,Namxb,Soluong,Manxb)" + "VALUES (@ms, @ts, @ls, @ttg, @namxb, @sl, @manxb)", mydb.getConnection);
            command.Parameters.Add("@ms", SqlDbType.Int).Value = masach;
            command.Parameters.Add("@ts", SqlDbType.VarChar).Value = tensach;
            command.Parameters.Add("@ls", SqlDbType.VarChar).Value = loaisach;
            command.Parameters.Add("@ttg", SqlDbType.VarChar).Value = tentacgia;
            command.Parameters.Add("@namxb", SqlDbType.DateTime).Value = namxb;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@manxb", SqlDbType.Int).Value = manxb;
          

            mydb.openConnection();

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
        public bool DeleteSach(string masach)
        {

            SqlCommand command = new SqlCommand("DELETE FROM TTSACH where Masach='" + masach + "'", mydb.getConnection);
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
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
        public bool updateSach(int masach, string tensach, string loaisach, string tentacgia, DateTime namxb, int soluong, int manxb)
        {

            SqlCommand command = new SqlCommand("UPDATE TTSACH SET Tensach=@ts,Loaisach=@ls,Tentacgia=@ttg,Namxb=@namxb,Soluong=@sl,Manxb=@manxb WHERE Masach=@ms", mydb.getConnection);
          
            command.Parameters.Add("@ms", SqlDbType.Int).Value = masach;
            command.Parameters.Add("@ts", SqlDbType.VarChar).Value = tensach;
            command.Parameters.Add("@ls", SqlDbType.VarChar).Value = loaisach;
            command.Parameters.Add("@ttg", SqlDbType.VarChar).Value = tentacgia;
            command.Parameters.Add("@namxb", SqlDbType.DateTime).Value = namxb;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@manxb", SqlDbType.Int).Value = manxb;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
        public Int32 totalSach()
        {
            Int32 count = 0;
            SqlCommand command = new SqlCommand("SELECT SUM(Soluong) FROM TTSACH", mydb.getConnection);
            mydb.openConnection();
            count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return count;
        }
        public double totalSachMuon()
        {
            double count = 0;
            SqlCommand command = new SqlCommand("SELECT COUNT(DISTINCT m.Tensach) FROM dbo.TTSACH AS t,dbo.SACHMUON AS m WHERE t.Masach=m.Masach", mydb.getConnection);
            mydb.openConnection();
            count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return count;
        }
        

        public Int32 totalSoLuongSachMuon()
        {
            Int32 count = 0;
            SqlCommand command = new SqlCommand("SELECT SUM(Soluongmuon) FROM dbo.SACHMUON", mydb.getConnection);
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                count = (Int32)command.ExecuteScalar();
                mydb.closeConnection();
                return count;
            }
            else
            {
                
                mydb.closeConnection();
                return count;
            }
        }
        public double totalSachSoLuongSachTra()
        {
            double count = 0;
            SqlCommand command = new SqlCommand("SELECT SUM(Soluongtra) FROM dbo.SACHTRA", mydb.getConnection);
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                count = (Int32)command.ExecuteScalar();
                mydb.closeConnection();
                return count;
            }
            else
            {

                mydb.closeConnection();
                return count;
            }
        }
    }
}
