using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class ThongKeSachMuonForm : Form
    {
        MY_DB mydb = new MY_DB();
        public ThongKeSachMuonForm()
        {
            InitializeComponent();
        }

        private void ThongKeFormSachMuon_Load(object sender, EventArgs e)
        {

            //hiển thị giá trị
            SACH sach = new SACH();
            double total = Convert.ToDouble(sach.totalSach());
            double totalsachmuon = Convert.ToDouble(sach.totalSoLuongSachMuon());
            double totalsachconlai = total - totalsachmuon;

            //tính % 
        
            //(tổng student*100)/(total students)
            double sachmuonSachPercentage = (totalsachmuon * (100 / total));
            double sachconlaiSachPercentage = total-totalsachmuon;
            labelTotalSach.Text = ("Tổng số cuốn sách trong thư viện: " + total.ToString());
            labelSachMuon.Text = ("Số lượng cuốn sách đang được mượn: " + (sachmuonSachPercentage.ToString()));

            labelSachConLai.Text = ("Số lượng cuốn sách chưa được mượn: " + (sachconlaiSachPercentage.ToString())) ;
        }
       
    }
}
