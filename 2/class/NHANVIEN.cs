using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class NHANVIEN
    {
        MY_DB mydb = new MY_DB();
        SACH sach = new SACH();
        public bool insertNV(string username,string password,int msnv,string hoten,string gioitinh,DateTime ngaysinh,string diachi,string sdt)
        {
            SqlCommand command = new SqlCommand("INSERT INTO nhanvien (username,password,msnv,hoten,gioitinh,ngaysinh,diachi,sdt)" + "VALUES (@user, @pass,@msnv,@hoten, @gt,@ns,@dc,@sdt)", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@ht", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
           


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
        public bool checkMaNV(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nhanvien WHERE msnv=" + id, mydb.getConnection);
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


        public DataTable getNV(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table; 

        }
        public bool DeleteNV(int manv)
        {

            SqlCommand command = new SqlCommand("DELETE FROM nhanvien where msnv=" + manv, mydb.getConnection);
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
       
        public bool updateNV(string username, string password, int msnv, string hoten, string gioitinh, DateTime ngaysinh, string diachi, string sdt)
        {

            SqlCommand command = new SqlCommand("UPDATE nhanvien SET username=@user,password=@pass,hoten=@ht,gioitinh=@gt,ngaysinh=@ns,diachi=@dc,sdt=@sdt WHERE msnv=@msnv", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            command.Parameters.Add("@ht", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;

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
    }
}
