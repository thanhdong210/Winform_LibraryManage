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
    public partial class ThongTinSVForm : Form
    {
        SINHVIEN sinhvien = new SINHVIEN();
        public ThongTinSVForm()
        {
            InitializeComponent();
            //ketnoicsdl();
        }

        private void ThongTinSVForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Masinhvien as 'Mã sinh viên',Hoten as 'Họ và Tên',Quequan as 'Quê quán',Gioitinh as 'Giới tính',Ngaysinh as 'Ngày sinh',Sluong as 'Số lượng' FROM SINHVIEN");
            dataGridViewSinhVien.ReadOnly = true;
            dataGridViewSinhVien.RowTemplate.Height = 80;
            dataGridViewSinhVien.DataSource = sinhvien.getSV(command);
            dataGridViewSinhVien.AllowUserToAddRows = false;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ThemSVForm themSV = new ThemSVForm();
            themSV.Show();
        }

        private void buttonRF_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Masinhvien as 'Mã sinh viên',Hoten as 'Họ và Tên',Quequan as 'Quê quán',Gioitinh as 'Giới tính',Ngaysinh as 'Ngày sinh',Sluong as 'Số lượng' FROM SINHVIEN");
            dataGridViewSinhVien.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewSinhVien.RowTemplate.Height = 80;
            dataGridViewSinhVien.DataSource = sinhvien.getSV(command);
            dataGridViewSinhVien.AllowUserToAddRows = false;
        }

        private void lịchSửMượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int dong = dataGridViewSinhVien.CurrentRow.Index;
            string tensv = dataGridViewSinhVien.Rows[dong].Cells[1].Value.ToString();
            string masv = dataGridViewSinhVien.Rows[dong].Cells[0].Value.ToString();
            int quydoi = Convert.ToInt32(masv);

            LichSuForm ls = new LichSuForm(quydoi, tensv);
            ls.Show();
        }
    }
}
