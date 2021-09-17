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
    public partial class SachMuonForm : Form
    {
        SACH sach = new SACH();
        public SachMuonForm()
        {
            InitializeComponent();
           
        }

        private void SachMuonForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Masinhvien as 'Mã sinh viên',Hoten as 'Họ và tên',Soluongmuon as 'Số Lượng mượn',Ngaymuon as 'Ngày mượn',Hantra as 'Hạn trả' FROM SACHMUON");
            dataGridViewSachMuon.ReadOnly = true;

            dataGridViewSachMuon.RowTemplate.Height = 80;
            dataGridViewSachMuon.DataSource = sach.getSach(command);

            dataGridViewSachMuon.AllowUserToAddRows = false;
        }
        
    }
}
