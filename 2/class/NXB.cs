using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class NXB
    {
        MY_DB mydb = new MY_DB();
        public bool insertNXB(int manxb, string tennxb, string diachi_nxb)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NHAXUATBAN (Manxb,TenNXB,Diachi_NXB)" + "VALUES (@mnxb, @tnxb, @dc)", mydb.getConnection);
            command.Parameters.Add("@mnxb", SqlDbType.Int).Value = manxb;
            command.Parameters.Add("@tnxb", SqlDbType.VarChar).Value = tennxb;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = diachi_nxb;
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
        public bool checkMaNXB(int manxb)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM NHAXUATBAN WHERE Manxb=" + manxb, mydb.getConnection);
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

        public DataTable getNXB(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool DeleteNXB(string manxb)
        {

            SqlCommand command = new SqlCommand("DELETE FROM NHAXUATBAN where Manxb='" + manxb + "'", mydb.getConnection);
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
        public bool updateNXB(int manxb, string tennxb, string diachi_nxb)
        {

            SqlCommand command = new SqlCommand("UPDATE NHAXUATBAN SET TenNXB=@tnxb,Diachi_NXB=@dc  WHERE Manxb=@mnxb", mydb.getConnection);
            command.Parameters.Add("@mnxb", SqlDbType.Int).Value = manxb;
            command.Parameters.Add("@tnxb", SqlDbType.VarChar).Value = tennxb;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = diachi_nxb;


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
