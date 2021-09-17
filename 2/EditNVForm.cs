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
    public partial class EditNVForm : Form
    {
        NHANVIEN nv = new NHANVIEN();
        public EditNVForm()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaNV.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng Mã nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        int manv = Convert.ToInt32(textBoxMaNV.Text);
                        DialogResult result;
                        result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Xóa thành công", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            nv.DeleteNV(manv);

                        }
                    }
                    catch
                    {
                        MessageBox.Show(this, "Không xóa được vì đang tồn tại dữ liệu trong bảng khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaNV.Text, out check) == false || decimal.TryParse(textBoxSDT.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng Mã nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string user = textBoxUser.Text;
                    string pass = textBoxPass.Text;
                    int msnv = Convert.ToInt32(textBoxMaNV.Text);
                    string hoten = textBoxHoTen.Text;
                    string gioitinh = "Nam";
                    if (radioButtonNu.Checked)
                    {
                        gioitinh = "Nu";
                    }
                    DateTime ngaysinh = dateTimePickerNgaySinh.Value;
                    string diachi = textBoxDiaChi.Text;
                    string sdt = textBoxSDT.Text;
                    int born_year = dateTimePickerNgaySinh.Value.Year;
                    int this_year = DateTime.Now.Year;
                    //ràng buộc dữ liệu về độ tuổi(ko cho người dùng nhập sai)
                    //svv từ 10-100

                    if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("Độ tuổi phải trong khoảng 18-100", "Sửa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (verif())
                    {
                        if (nv.updateNV(user, pass, msnv, hoten, gioitinh, ngaysinh, diachi, sdt))
                        {
                            MessageBox.Show("Đã thêm thành công", "Sửa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Sửa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empty Fields", "Sửa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        bool verif()
        {
            if ((textBoxUser.Text.Trim() == "") || (textBoxPass.Text.Trim() == "") || (textBoxSDT.Text.Trim() == "") || (textBoxHoTen.Text.Trim() == "") || (textBoxMaNV.Text.Trim() == "") || (textBoxDiaChi.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBoxMaNV.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM nhanvien WHERE msnv = " + id);
            DataTable table = nv.getNV(command);
            if (table.Rows.Count > 0)
            {
                textBoxUser.Text = table.Rows[0]["username"].ToString();
                textBoxPass.Text = table.Rows[0]["password"].ToString();
                textBoxHoTen.Text = table.Rows[0]["hoten"].ToString();

                dateTimePickerNgaySinh.Value = (DateTime)table.Rows[0]["ngaysinh"];

                if (table.Rows[0]["gioitinh"].ToString() == "Nam")
                {
                    radioButtonNam.Checked = true;
                    radioButtonNu.Checked = false;
                }
                else
                {
                    radioButtonNu.Checked = true;
                    radioButtonNam.Checked = false;
                }
                textBoxSDT.Text = table.Rows[0]["sdt"].ToString();
                textBoxDiaChi.Text = table.Rows[0]["diachi"].ToString();
            }
            else
            {
                MessageBox.Show("Không có nhân viên này", "Tìm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
    
}
