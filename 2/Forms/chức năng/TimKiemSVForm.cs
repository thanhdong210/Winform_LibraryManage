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
    public partial class TimKiemSVForm : Form
    {
        SINHVIEN sv = new SINHVIEN();
        public TimKiemSVForm()
        {
            InitializeComponent();
        }
        private void TimKiemSVForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Masinhvien as 'Mã sinh viên',Hoten as 'Họ và Tên',Quequan as 'Quê quán',Gioitinh as 'Giới tính',Ngaysinh as 'Ngày sinh',Sluong as 'Số lượng' FROM SINHVIEN");
            dataGridViewTimKiem.ReadOnly = true;

            dataGridViewTimKiem.RowTemplate.Height = 80;
            dataGridViewTimKiem.DataSource =sv.getSV(command);

            dataGridViewTimKiem.AllowUserToAddRows = false;
        }


        private void buttonCheck_Click_1(object sender, EventArgs e)
        {
            if (radioButtonMaSach.Checked)
            {
                if ((textBoxCheck.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT Masinhvien as 'Mã sinh viên',Hoten as 'Họ và Tên',Quequan as 'Quê quán',Gioitinh as 'Giới tính',Ngaysinh as 'Ngày sinh',Sluong as 'Số lượng' FROM SINHVIEN");
                    dataGridViewTimKiem.DataSource = sv.getSV(command);
                }
                else
                {

                    try
                    {
                        int id = int.Parse(textBoxCheck.Text);
                        SqlCommand command = new SqlCommand("SELECT Masinhvien as 'Mã sinh viên',Hoten as 'Họ và Tên',Quequan as 'Quê quán',Gioitinh as 'Giới tính',Ngaysinh as 'Ngày sinh',Sluong as 'Số lượng' FROM SINHVIEN WHERE Masinhvien = " + id);
                        dataGridViewTimKiem.DataSource = sv.getSV(command);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                if ((textBoxCheck.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT Masinhvien as 'Mã sinh viên',Hoten as 'Họ và Tên',Quequan as 'Quê quán',Gioitinh as 'Giới tính',Ngaysinh as 'Ngày sinh',Sluong as 'Số lượng' FROM SINHVIEN");
                    dataGridViewTimKiem.DataSource = sv.getSV(command);
                }
                else
                {
                    string ten = textBoxCheck.Text;
                    SqlCommand command = new SqlCommand("SELECT Masinhvien as 'Mã sinh viên',Hoten as 'Họ và Tên',Quequan as 'Quê quán',Gioitinh as 'Giới tính',Ngaysinh as 'Ngày sinh',Sluong as 'Số lượng' FROM SINHVIEN WHERE Hoten LIKE '%" + ten + "%'");
                    dataGridViewTimKiem.DataSource = sv.getSV(command);
                }

            }
        }
    }
}
