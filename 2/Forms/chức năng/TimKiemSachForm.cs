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
    public partial class TimKiemSachForm : Form
    {
        SACH sach = new SACH();
        public TimKiemSachForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimKiemSachForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Loaisach as 'Loại sách',Tentacgia as 'Tên tác giả',Namxb as 'Năm xuất bản',Soluong as 'Số lượng',Manxb as 'Mã nhà xuất bản' FROM TTSACH");
            dataGridViewTimKiem.ReadOnly = true;

            dataGridViewTimKiem.RowTemplate.Height = 80;
            dataGridViewTimKiem.DataSource = sach.getSach(command);
            dataGridViewTimKiem.AllowUserToAddRows = false;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if(radioButtonMaSach.Checked)
            {
                if ((textBoxCheck.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Loaisach as 'Loại sách',Tentacgia as 'Tên tác giả',Namxb as 'Năm xuất bản',Soluong as 'Số lượng',Manxb as 'Mã nhà xuất bản' FROM TTSACH");
                    dataGridViewTimKiem.DataSource = sach.getSach(command);
                }
                else
                {

                    try
                    {
                        int id = int.Parse(textBoxCheck.Text);
                        SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Loaisach as 'Loại sách',Tentacgia as 'Tên tác giả',Namxb as 'Năm xuất bản',Soluong as 'Số lượng',Manxb as 'Mã nhà xuất bản' FROM TTSACH WHERE Masach = " + id);
                        dataGridViewTimKiem.DataSource = sach.getSach(command);
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
                    SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Loaisach as 'Loại sách',Tentacgia as 'Tên tác giả',Namxb as 'Năm xuất bản',Soluong as 'Số lượng',Manxb as 'Mã nhà xuất bản' FROM TTSACH");
                    dataGridViewTimKiem.DataSource = sach.getSach(command);
                }
                else
                {
                    string ten = textBoxCheck.Text;
                    SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Loaisach as 'Loại sách',Tentacgia as 'Tên tác giả',Namxb as 'Năm xuất bản',Soluong as 'Số lượng',Manxb as 'Mã nhà xuất bản' FROM TTSACH WHERE Tensach LIKE '%" + ten + "%'");
                    dataGridViewTimKiem.DataSource = sach.getSach(command);
                }
                
            }
            
        }
    }
}
