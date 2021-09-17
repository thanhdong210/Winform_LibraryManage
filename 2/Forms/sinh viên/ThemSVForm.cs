using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class ThemSVForm : Form
    {
        SACH sach = new SACH();
        SINHVIEN sinhvien = new SINHVIEN();
        public ThemSVForm()
        {
            InitializeComponent();
        }

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaSinhVien.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng Mã sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string hoten = textBoxHoTen.Text;
                    string quequan = textBoxQueQuan.Text;
                    string gioitinh = "Nam";
                    DateTime ngaysinh = dateTimePicker1.Value;
                    if (radioButtonNu.Checked)
                    {
                        gioitinh = "Nu";
                    }

                    int masinhvien = Convert.ToInt32(textBoxMaSinhVien.Text);
                    int sluong = 0;
                    int born_year = dateTimePicker1.Value.Year;
                    int this_year = DateTime.Now.Year;


                    //ràng buộc dữ liệu về năm xuất bản(ko cho người dùng nhập sai)
                    //năm xuất bản < năm hiện tại
                    if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("Độ tuổi phải trong khoảng 18-100", "Thêm Sinh Viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (verif() == true&&sinhvien.checkMaSV(masinhvien)==false)
                    {
                        try
                        {
                            if (sinhvien.insertSV(hoten, quequan, gioitinh, masinhvien,ngaysinh ,sluong))
                            {
                                MessageBox.Show("Thêm thành công", "Sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi", "Sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Trùng thông tin", "Sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empty Fields", "Sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }
        bool verif()
        {
            if ((textBoxHoTen.Text.Trim() == "") || (textBoxQueQuan.Text.Trim() == "") || (textBoxSLuong.Text.Trim() == ""))
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
