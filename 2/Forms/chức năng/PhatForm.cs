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
    public partial class PhatForm : Form
    {
        SACH sach = new SACH();
        public PhatForm()
        {
            InitializeComponent();
        }
        private void PhatForm_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT Masinhvien as 'Mã sinh viên',Tensinhvien as 'Tên sinh viên',Mamuontra as 'Mã mượn trả',Dongphat as 'Tiền phạt',Ngaytra as 'Ngày trả quá hạn' FROM TTPHAT");
            dataGridViewPhat.ReadOnly = true;


            dataGridViewPhat.RowTemplate.Height = 80;
            dataGridViewPhat.DataSource = sach.getSach(command);

            dataGridViewPhat.AllowUserToAddRows = false;


        }

        private void buttonTraTien_Click(object sender, EventArgs e)
        {
            SINHVIEN sv = new SINHVIEN();
           
                int dong = dataGridViewPhat.CurrentRow.Index;
                string masv = (dataGridViewPhat.Rows[dong].Cells[0].Value.ToString());
                int mamuontra = Convert.ToInt32(dataGridViewPhat.Rows[dong].Cells[2].Value);
                DateTime ngaytra = Convert.ToDateTime(dataGridViewPhat.Rows[dong].Cells[4].Value);
                DialogResult result;
                result = MessageBox.Show("Xác nhận đã đóng phạt ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    sv.DeleteSVphat(masv, mamuontra, ngaytra);

                }
            
        }
    }
    
}
