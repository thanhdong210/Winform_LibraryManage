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
    public partial class ThemNXBForm : Form
    {
        NXB nxb = new NXB();
        public ThemNXBForm()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if ((textBoxMaNXB.Text.Trim() == "")|| (textBoxTenNXB.Text.Trim() == ""))
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaNXB.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng Mã nhà xuất bản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string diachi = textBoxDiaChiNXB.Text;
                    string tennxb = textBoxTenNXB.Text;

                    int manxb = Convert.ToInt32(textBoxMaNXB.Text);
                    if (verif() == true&&nxb.checkMaNXB(manxb)==false)
                    {
                        try
                        {
                            if (nxb.insertNXB(manxb, tennxb, diachi))
                            {
                                MessageBox.Show("Thêm thành công", "Nhà xuất bản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi", "Nhà xuất bản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Thông tin nhập bị trùng", "Nhà xuất bản", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empty Fields", "Them nha xuat ban", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
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

        private void textBoxTenNXB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
