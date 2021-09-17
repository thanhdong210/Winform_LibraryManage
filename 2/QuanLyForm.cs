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
    public partial class QuanLyForm : Form
    {
        NHANVIEN nv = new NHANVIEN();
        public QuanLyForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabelLoaiSach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThongKeLoaiSachForm loaisach = new ThongKeLoaiSachForm();
            loaisach.Show();
        }

        private void linkLabelSachMuon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThongKeSachMuonForm sachmuon = new ThongKeSachMuonForm();
            sachmuon.Show();
        }

        private void linkLabelSachTra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThongKeSachTraForm sachtra = new ThongKeSachTraForm();
            sachtra.Show();
        }

        private void linkLabelGioiTinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThongKeGioiTinhForm gioitinh = new ThongKeGioiTinhForm();
            gioitinh.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaNhanVien.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng Mã nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        int msnv = Convert.ToInt32(textBoxMaNhanVien.Text);
                        DialogResult result;
                        result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Da xoa thanh cong", "Sua Sinh Vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            nv.DeleteNV(msnv);


                        }
                    }
                    catch
                    {
                        MessageBox.Show(this, "Không xóa được vì đang tồn tại dữ liệu trong bảng khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonShowFull_Click(object sender, EventArgs e)
        {
            DanhSachNVForm ds = new DanhSachNVForm();
            ds.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddNVForm addnv = new AddNVForm();
            addnv.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditNVForm editnv = new EditNVForm();
            editnv.Show();
        }
    }
}
