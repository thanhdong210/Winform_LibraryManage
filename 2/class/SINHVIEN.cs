using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class SINHVIEN
    {
        MY_DB mydb = new MY_DB();
        SACH sach = new SACH();
        public bool insertSV(string hoten, string quequan,string gioitinh,int masinhvien,DateTime ngaysinh,int sluong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SINHVIEN (Hoten,Quequan,Gioitinh,Masinhvien,Ngaysinh,Sluong)" + "VALUES (@ht, @qq,@gt,@msv,@ns,@sl)", mydb.getConnection);
          
            command.Parameters.Add("@ht", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@qq", SqlDbType.VarChar).Value = quequan;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@msv", SqlDbType.Int).Value = masinhvien;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = sluong;
          

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

        public bool checkMaSV(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN WHERE Masinhvien=" + id, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getSV(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool DeleteSV(string masinhvien)
        {

            SqlCommand command = new SqlCommand("DELETE FROM SINHVIEN where Masinhvien='" + masinhvien + "'", mydb.getConnection);
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
        public bool DeleteSVphat(string masinhvien,int mamuontra,DateTime ngaytra)
        {

            SqlCommand command = new SqlCommand("DELETE FROM TTPHAT where Masinhvien='" + masinhvien + "' AND Mamuontra='"+mamuontra+"' AND Ngaytra='"+ngaytra+"'", mydb.getConnection);
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
        public bool updateSV(string hoten, string quequan,string gioitinh,int masinhvien,DateTime ngaysinh, int sluong)
        {

            SqlCommand command = new SqlCommand("UPDATE SINHVIEN SET Hoten=@ht,Quequan=@qq,Gioitinh=@gt,Ngaysinh=@ns,Sluong=@sl WHERE Masinhvien=@msv", mydb.getConnection);
            command.Parameters.Add("@ht", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@qq", SqlDbType.VarChar).Value = quequan;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@msv", SqlDbType.Int).Value = masinhvien;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = sluong;
            
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
        public Int32 totalSV()
        {
            Int32 count = 0;
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM SINHVIEN", mydb.getConnection);
            mydb.openConnection();
            count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return count;
        }
        public double totalNam()
        {
            double count = 0;
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM dbo.SINHVIEN WHERE Gioitinh='Nam'", mydb.getConnection);
            mydb.openConnection();
            count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return count;
        }
        public double totalNu()
        {
            double count = 0;
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM dbo.SINHVIEN WHERE Gioitinh='Nu'", mydb.getConnection);
            mydb.openConnection();
            count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return count;
        }

    }
}
