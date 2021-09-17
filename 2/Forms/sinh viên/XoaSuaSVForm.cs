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
    public partial class XoaSuaSVForm : Form
    {
        SACH sach = new SACH();
        SINHVIEN sinhvien = new SINHVIEN();
        public XoaSuaSVForm()
        {
            InitializeComponent();
        }
        private void XoaSuaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet1.std' table. You can move, or remove it, as needed.
         
            SqlCommand command = new SqlCommand("SELECT Masinhvien as 'Mã sinh viên',Hoten as 'Họ và Tên',Quequan as 'Quê quán',Gioitinh as 'Giới tính',Ngaysinh as 'Ngày sinh',Sluong as 'Số lượng' FROM SINHVIEN");
            dataGridViewSinhVien.ReadOnly = true;
            dataGridViewSinhVien.RowTemplate.Height = 80;
            dataGridViewSinhVien.DataSource = sinhvien.getSV(command);
            dataGridViewSinhVien.AllowUserToAddRows = false;
        }
        private void XoaSuaSVForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxHoTen.Text = dataGridViewSinhVien.CurrentRow.Cells[1].Value.ToString();
            textBoxQueQuan.Text = dataGridViewSinhVien.CurrentRow.Cells[2].Value.ToString();
            if ((dataGridViewSinhVien.CurrentRow.Cells[3].Value.ToString() == "Nu"))
            {
                radioButtonNu.Checked = true;
            }
            else
            {
               radioButtonNam.Checked = true;
            }
            textBoxMaSinhVien.Text = dataGridViewSinhVien.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridViewSinhVien.CurrentRow.Cells[4].Value.ToString();
            textBoxSLuong.Text = dataGridViewSinhVien.CurrentRow.Cells[5].Value.ToString();
            

        }
        private void buttonSua_Click(object sender, EventArgs e)
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

                    if (radioButtonNu.Checked)
                    {
                        gioitinh = "Nu";
                    }
                    int masinhvien = Convert.ToInt32(textBoxMaSinhVien.Text);
                    int sluong = Convert.ToInt32(textBoxSLuong.Text);

                    DateTime ngaysinh = dateTimePicker1.Value;
                    int born_year = dateTimePicker1.Value.Year;
                    int this_year = DateTime.Now.Year;


                    //ràng buộc dữ liệu về năm xuất bản(ko cho người dùng nhập sai)
                    //năm xuất bản < năm hiện tại
                    if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("Độ tuổi phải trong khoảng 18-100", "Thêm Sinh Viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //ràng buộc dữ liệu về năm xuất bản(ko cho người dùng nhập sai)
                    //năm xuất bản < năm hiện tại

                    else if(verif() == true)
                    {

                        if (sinhvien.updateSV(hoten, quequan, gioitinh, masinhvien,ngaysinh,sluong))
                        {
                            MessageBox.Show("Sửa thành công", "Sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        


        

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textBoxMaSinhVien.Text.Trim() == "")
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxMaSinhVien.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng Mã sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        int masinhvien = int.Parse(textBoxMaSinhVien.Text);
                        DialogResult result;
                        result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Xóa thành công", "Sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string chiSo = textBoxMaSinhVien.Text;
                            sinhvien.DeleteSV(chiSo);

                        }
                    }
                    catch
                    {
                        MessageBox.Show(this, "Không xóa được vì đang tồn tại dữ liệu trong bảng khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Masinhvien as 'Mã sinh viên',Hoten as 'Họ và Tên',Quequan as 'Quê quán',Gioitinh as 'Giới tính',Ngaysinh as 'Ngày sinh',Sluong as 'Số lượng' FROM SINHVIEN");
            dataGridViewSinhVien.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewSinhVien.RowTemplate.Height = 80;
            dataGridViewSinhVien.DataSource = sinhvien.getSV(command);
            dataGridViewSinhVien.AllowUserToAddRows = false;
        }
    }
    
}
