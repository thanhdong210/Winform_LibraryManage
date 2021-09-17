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
    public partial class ThongtinsachsForm : Form
    {
        SACH sach = new SACH();
        public ThongtinsachsForm()
        {
            InitializeComponent();
            //ketnoicsdl();
        }

        private void dataGridViewSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Loaisach as 'Loại sách',Tentacgia as 'Tên tác giả',Namxb as 'Năm xuất bản',Soluong as 'Số lượng',Manxb as 'Mã nhà xuất bản' FROM TTSACH");
            dataGridViewSach.ReadOnly = true;
            dataGridViewSach.DataSource = sach.getSach(command);
            dataGridViewSach.AllowUserToAddRows = false;
        }

        private void chỉnhSửaThôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaSuaSachForm xoasua = new XoaSuaSachForm();
            xoasua.Show();
        }

        private void ThongtinsachsForm_Load(object sender, EventArgs e)
        {
          
            SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Loaisach as 'Loại sách',Tentacgia as 'Tên tác giả',Namxb as 'Năm xuất bản',Soluong as 'Số lượng',Manxb as 'Mã nhà xuất bản' FROM TTSACH");
            dataGridViewSach.ReadOnly = true;

            
            dataGridViewSach.RowTemplate.Height = 80;
            dataGridViewSach.DataSource = sach.getSach(command);
            
            dataGridViewSach.AllowUserToAddRows = false;


        }
       
    }
}
