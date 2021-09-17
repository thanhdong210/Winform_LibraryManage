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
    public partial class DanhSachNVForm : Form
    {
        NHANVIEN nv = new NHANVIEN();
        public DanhSachNVForm()
        {
            InitializeComponent();
        }

        private void DanhSachNVForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT msnv as'mã số nhân viên',hoten as 'Họ và tên',gioitinh 'Giới tính',ngaysinh as'Ngày sinh',diachi as'Địa chỉ',sdt as 'Số điện thoại' FROM nhanvien_view");
            dataGridView1.ReadOnly = true;

            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = nv.getNV(command);

            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
