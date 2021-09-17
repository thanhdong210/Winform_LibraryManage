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
    public partial class ThemsachForm : Form
    {
        public ThemsachForm()
        {
            InitializeComponent();
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
                if (decimal.TryParse(textBoxMaNXB.Text, out check) == false|| decimal.TryParse(textBoxMaSach.Text, out check) == false|| decimal.TryParse(textBoxSoLuong.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng(Mã sách/Mã NXB/Số lượng)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    SACH sach = new SACH();
                    int masach = Convert.ToInt32(textBoxMaSach.Text);
                    string tensach = textBoxTenSach.Text;
                    string loaisach = textBoxLoaiSach.Text;
                    DateTime namxb = dateTimePickerNamxb.Value;
                    string tentacgia = textBoxTenTacGia.Text;
                    int soluong = Convert.ToInt32(textBoxSoLuong.Text);
                    int manxb = Convert.ToInt32(textBoxMaNXB.Text);

                    int namsanxuat = dateTimePickerNamxb.Value.Year;
                    int namhientai = DateTime.Now.Year;

                    //ràng buộc dữ liệu về năm xuất bản(ko cho người dùng nhập sai)
                    //năm xuất bản < năm hiện tại
                    if (namsanxuat > namhientai)
                    {
                        MessageBox.Show("Nhập sai năm xuất bản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (verif())
                    {
                        try
                        {
                            if (sach.insertSach(masach, tensach, loaisach, tentacgia, namxb, soluong, manxb))
                            {
                                MessageBox.Show("Thêm sách thành công", "Thêm sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi", "Thêm sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Trùng thông tin", "Thêm Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Empty Fields", "Thêm sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        bool verif()
        {
            if ((textBoxMaSach.Text.Trim() == "") || (textBoxTenSach.Text.Trim() == "") || (textBoxLoaiSach.Text.Trim() == "") || (textBoxTenTacGia.Text.Trim() == "") || (textBoxSoLuong.Text.Trim()=="")||(textBoxSoLuong.Text.Trim()=="")||(textBoxMaNXB.Text.Trim()==""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
