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
    public partial class LichSuForm : Form
    {
        SACH sach = new SACH();
        private int ma;
        private string ten;
        public LichSuForm()
        {
            InitializeComponent();

        }
        public LichSuForm(int ma, string ten)
        {
            InitializeComponent();
            this.ma = ma;
            this.ten = ten;
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LichSuForm_Load(object sender, EventArgs e)
        {
            textBoxMaSV.Text = ma.ToString();
           
            textBoxTenSV.Text = ten;
            int masv = Convert.ToInt32(textBoxMaSV.Text);

            //bang muon
            SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Mamuontra as 'Mã mượn trả',Soluongmuon as 'Số lượng mượn',Ngaymuon as 'Ngày mượn',Hantra as 'Hạn trả' FROM LICH_SU_MUON_SACH WHERE Masinhvien=" + masv);
            dataGridViewMuonSach.ReadOnly = true;
            dataGridViewMuonSach.RowTemplate.Height = 80;
            dataGridViewMuonSach.DataSource = sach.getSach(command);

            dataGridViewMuonSach.AllowUserToAddRows = false;

            //bang tra
            SqlCommand command2 = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Mamuontra as 'Mã mượn trả',Soluongtra as 'Só lượng trả',Ngaytra as 'Ngày trả' FROM dbo.SACHTRA WHERE Masinhvien=" + masv);
            dataGridViewTraSach.ReadOnly = true;
            dataGridViewTraSach.RowTemplate.Height = 80;
            dataGridViewTraSach.DataSource = sach.getSach(command2);

            dataGridViewTraSach.AllowUserToAddRows = false;


        }
    }
}
