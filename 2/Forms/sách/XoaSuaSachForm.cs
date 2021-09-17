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
    public partial class XoaSuaSachForm : Form
    {
        SACH sach = new SACH();
        public XoaSuaSachForm()
        {
            InitializeComponent();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textBoxMaSach.Text.Trim() == "")
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaSach.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng Mã sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {

                        int masach = int.Parse(textBoxMaSach.Text);
                        DialogResult result;
                        result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            //MessageBox.Show("Da xoa thanh cong", "Sua Sach", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string chiSo = textBoxMaSach.Text;
                            sach.DeleteSach(chiSo);

                        }
                    }
                    catch
                    {
                        MessageBox.Show(this, "Không xóa được vì đang tồn tại dữ liệu trong bảng khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }   
        private void XoaSuaSachForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet1.std' table. You can move, or remove it, as needed.

            SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Loaisach as 'Loại sách',Tentacgia as 'Tên tác giả',Namxb as 'Năm xuất bản',Soluong as 'Số lượng',Manxb as 'Mã nhà xuất bản' FROM TTSACH");
            dataGridViewXoaSua.ReadOnly = true;

            dataGridViewXoaSua.RowTemplate.Height = 80;
            dataGridViewXoaSua.DataSource = sach.getSach(command);

            dataGridViewXoaSua.AllowUserToAddRows = false;
        }
        private void XoaSuaSachForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxMaSach.Text = dataGridViewXoaSua.CurrentRow.Cells[0].Value.ToString();
            textBoxTenSach.Text = dataGridViewXoaSua.CurrentRow.Cells[1].Value.ToString();
            textBoxLoaiSach.Text = dataGridViewXoaSua.CurrentRow.Cells[2].Value.ToString();
            textBoxTenTacGia.Text = dataGridViewXoaSua.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerNamxb.Value = (DateTime)dataGridViewXoaSua.CurrentRow.Cells[4].Value;
            textBoxSoLuong.Text = dataGridViewXoaSua.CurrentRow.Cells[5].Value.ToString();
            textBoxManxb.Text = dataGridViewXoaSua.CurrentRow.Cells[6].Value.ToString();
            


        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxManxb.Text, out check) == false || decimal.TryParse(textBoxMaSach.Text, out check) == false || decimal.TryParse(textBoxSoLuong.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng(Mã sách/Mã NXB/Số lượng)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int masach;
                    string tensach = textBoxTenSach.Text;
                    string loaisach = textBoxLoaiSach.Text;
                    string tentacgia = textBoxTenTacGia.Text;
                    DateTime namxb = dateTimePickerNamxb.Value;

                    int soluong = Convert.ToInt32(textBoxSoLuong.Text);
                    int manxb = Convert.ToInt32(textBoxManxb.Text);


                    int namsanxuat = dateTimePickerNamxb.Value.Year;
                    int namhientai = DateTime.Now.Year;

                    //ràng buộc dữ liệu về thoiwf gian
                    //năm xuất bản phải nhỏ hơn năm hiện tại
                    if (namsanxuat > namhientai)
                    {
                        MessageBox.Show("Nhập sai năm xuất bản", "Nhập sai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (verif())
                    {
                        masach = Convert.ToInt32(textBoxMaSach.Text);
                        if (sach.updateSach(masach, tensach, loaisach, tentacgia, namxb, soluong, manxb))
                        {
                            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("LỖI", "Lưu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empty Fields", "Lưu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
                    bool verif()
                    {
                        if ((textBoxMaSach.Text.Trim() == "") || (textBoxTenSach.Text.Trim() == "") || (textBoxLoaiSach.Text.Trim() == "") || (textBoxTenTacGia.Text.Trim() == "") || (textBoxSoLuong.Text.Trim() == "") || (textBoxSoLuong.Text.Trim() == "") || (textBoxManxb.Text.Trim() == ""))
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Loaisach as 'Loại sách',Tentacgia as 'Tên tác giả',Namxb as 'Năm xuất bản',Soluong as 'Số lượng',Manxb as 'Mã nhà xuất bản' FROM TTSACH");
            dataGridViewXoaSua.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewXoaSua.RowTemplate.Height = 80;
            dataGridViewXoaSua.DataSource = sach.getSach(command);
            dataGridViewXoaSua.AllowUserToAddRows = false;
        }
    }
}
