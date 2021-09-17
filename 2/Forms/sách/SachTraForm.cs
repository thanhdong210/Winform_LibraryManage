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
    public partial class SachTraForm : Form
    {
        SACH sach = new SACH();
        public SachTraForm()
        {
            InitializeComponent();
           // ketnoicsdl();
        }

        private void SachTraForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Masinhvien as 'Mã sinh viên',Hoten as 'Họ và tên',Soluongtra as 'Số Lượng trả',Ngaytra as 'Ngày trả' FROM SACHTRA");
            dataGridViewSachTra.ReadOnly = true;

            dataGridViewSachTra.RowTemplate.Height = 80;
            dataGridViewSachTra.DataSource = sach.getSach(command);

            dataGridViewSachTra.AllowUserToAddRows = false;
        }
       
    }
}
