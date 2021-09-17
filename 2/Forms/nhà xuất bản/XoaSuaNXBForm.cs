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
    public partial class XoaSuaNXBForm : Form
    {
        NXB nxb = new NXB();
        public XoaSuaNXBForm()
        {
            InitializeComponent();
        }
      
        private void XoaSuaNXBForm_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT Manxb as 'Mã NXB',TenNXB as 'Tên NXB',Diachi_NXB as 'Địa chỉ' FROM NHAXUATBAN");
            dataGridViewNXB.ReadOnly = true;


            dataGridViewNXB.RowTemplate.Height = 80;
            dataGridViewNXB.DataSource = nxb.getNXB(command);

            dataGridViewNXB.AllowUserToAddRows = false;


        }

        private void buttonRF_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Manxb as 'Mã NXB',TenNXB as 'Tên NXB',Diachi_NXB as 'Địa chỉ' FROM NHAXUATBAN");
            dataGridViewNXB.ReadOnly = true;

            dataGridViewNXB.RowTemplate.Height = 80;
            dataGridViewNXB.DataSource = nxb.getNXB(command);
            dataGridViewNXB.AllowUserToAddRows = false;
        }
        private void XoaSuaNXBForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxMaNXB.Text = dataGridViewNXB.CurrentRow.Cells[0].Value.ToString();
            textBoxTenNXB.Text = dataGridViewNXB.CurrentRow.Cells[1].Value.ToString();
            textBoxDiaChiNXB.Text = dataGridViewNXB.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int manxb = int.Parse(textBoxMaNXB.Text);
                DialogResult result;
                result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    //MessageBox.Show("Da xoa thanh cong", "Sua Sinh Vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string chiSo = textBoxMaNXB.Text;
                    nxb.DeleteNXB(chiSo);
                    

                }
            }
            catch
            {
                MessageBox.Show(this, "Không xóa được vì đang tồn tại dữ liệu trong bảng khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            int manxb = Convert.ToInt32(textBoxMaNXB.Text);
            string tennxb = textBoxTenNXB.Text;
            string diachi = textBoxDiaChiNXB.Text;
            if (verif() == true)
            {

                if (nxb.updateNXB(manxb,tennxb,diachi))
                {
                    MessageBox.Show("Sửa thành công", "Nhà xuất bản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi", "Nhà xuất bản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Nhà xuất bản", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        bool verif()
        {
            if ((textBoxMaNXB.Text.Trim() == "") || (textBoxTenNXB.Text.Trim() == "") || (textBoxDiaChiNXB.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }   
}
