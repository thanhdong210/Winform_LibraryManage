using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class ThongKeSachTraForm : Form
    {
        public ThongKeSachTraForm()
        {
            InitializeComponent();
        }
        private void ThongKeFormSachTra_Load(object sender, EventArgs e)
        {

            //hiển thị giá trị
            SACH sach = new SACH();
            double totalsachmuon = Convert.ToDouble(sach.totalSoLuongSachMuon());
            double totalsachtra = Convert.ToDouble(sach.totalSachSoLuongSachTra());
           
            //tính % 
            //(tổng student*100)/(total students)
            double sachSachPercentage = totalsachmuon;
            double sachtraSachPercentage = totalsachtra;
            double sachconlaiSachPercentage = totalsachmuon - totalsachtra;
            labelTotalSachMuon.Text = ("Tổng số lượng sách được mượn: " + totalsachmuon.ToString());
            labelSachDaTra.Text = ("Sô lượng sách đã trả: " + (sachtraSachPercentage.ToString()));

            labelSachConLai.Text = ("Số lượng sách chưa trả: " + (sachconlaiSachPercentage.ToString()));
        }
    }
    
}
