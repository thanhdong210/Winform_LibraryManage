namespace _2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    
    public partial class AddNVForm : Form
    {
       NHANVIEN nv = new NHANVIEN();

      
        public AddNVForm()
        {
            InitializeComponent();
        }

        
        private void label6_Click(object sender, EventArgs e)
        {
        }

       
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

       
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaNV.Text, out check) == false|| decimal.TryParse(textBoxSDT.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng Mã sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    if (nv.checkMaNV(msnv) == false)
                    {
                        MessageBox.Show("Trùng mã nhân viên", "Thêm Nhân Viên ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("Độ tuổi phải trong khoảng 18-100", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (verif())
                    {
                        if (nv.insertNV(user, pass, msnv, hoten, gioitinh, ngaysinh, diachi, sdt))
                        {
                            MessageBox.Show("Dẫ thêm thành công", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empty Fields", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

       bool verif()
        {
            if ((textBoxUser.Text.Trim() == "") || (textBoxPass.Text.Trim() == "") || (textBoxSDT.Text.Trim() == "")|| (textBoxHoTen.Text.Trim() == "")|| (textBoxMaNV.Text.Trim() == "")|| (textBoxDiaChi.Text.Trim() == ""))
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
