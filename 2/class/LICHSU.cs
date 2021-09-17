using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class LICHSU
    {
        MY_DB mydb = new MY_DB();
        public bool insertLichSuMuonSach(int masach, string tensach, int masinhvien, string hoten, int soluong, DateTime ngaymuon, DateTime ngaytra)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LICH_SU_MUON_SACH (Masach,Tensach,Masinhvien,Hoten,Soluongmuon,Ngaymuon,Hantra)" + "VALUES (@ms,@ts,@msv,@hten,@slm,@nm,@ht)", mydb.getConnection);
            command.Parameters.Add("@ms", SqlDbType.Int).Value = masach;
            command.Parameters.Add("@ts", SqlDbType.VarChar).Value = tensach;
            command.Parameters.Add("@msv", SqlDbType.Int).Value = masinhvien;
            command.Parameters.Add("@hten", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@slm", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@nm", SqlDbType.DateTime).Value = ngaymuon;
            command.Parameters.Add("@ht", SqlDbType.DateTime).Value = ngaytra;
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
    }
}
