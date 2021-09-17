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
    public partial class TraSachForm : Form
    {
        SqlDataAdapter da;
        MY_DB mydb = new MY_DB();
        SACH sach = new SACH();

        public TraSachForm()
        {
            InitializeComponent();
        }
        private void TraSachForm_Load(object sender, EventArgs e)
        {
            //bang sach
            SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Mamuontra as 'Mã mượn trả',Masinhvien as 'Mã sinh viên',Hoten as 'Họ tên',Soluongmuon as 'Số lượng mượn',Ngaymuon as 'Ngày mượn',Hantra as 'Hạn trả' FROM SACHMUON");
            dataGridViewSachMuon.ReadOnly = true;
            dataGridViewSachMuon.RowTemplate.Height = 80;
            dataGridViewSachMuon.DataSource = sach.getSach(command);
            dataGridViewSachMuon.AllowUserToAddRows = false;
            //bang sinh vien
            SqlCommand command2 = new SqlCommand("SELECT  Masach as 'Mã sách',Tensach as 'Tên sách',Mamuontra as 'Mã mượn trả',Masinhvien as 'Mã sinh viên',Hoten as 'Họ tên',Soluongtra as 'Số lượng trả',Ngaytra as 'Ngày trả' FROM SACHTRA");
            dataGridViewSachTra.ReadOnly = true;
            dataGridViewSachTra.RowTemplate.Height = 80;
            dataGridViewSachTra.DataSource = sach.getSach(command2);
            dataGridViewSachTra.AllowUserToAddRows = false;
            //combobox
            ShowComboboxMaSach();
            ShowComboboxMaSinhVien();

        }
        public void ShowComboboxMaSach()
        {
            SqlCommand command = new SqlCommand("SELECT Masach,Tensach,Mamuontra FROM SACHMUON", mydb.getConnection);
            mydb.openConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            comboBoxMaSach.DataSource = table;
            comboBoxMaSach.DisplayMember = "Masach";
            comboBoxMaSach.ValueMember = "Tensach";
            comboBoxMaSach.ValueMember = "Mamuontra";



        }
        private void SachdangduocmuonForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            comboBoxMaSach.Text = dataGridViewSachMuon.CurrentRow.Cells[0].Value.ToString();
            textBoxTenSach.Text = dataGridViewSachMuon.CurrentRow.Cells[1].Value.ToString();
            textBoxMaMuonTra.Text = dataGridViewSachMuon.CurrentRow.Cells[2].Value.ToString();
            comboBoxMaSinhVien.Text = dataGridViewSachMuon.CurrentRow.Cells[3].Value.ToString();




        }

        public void ShowComboboxMaSinhVien()
        {
            SqlCommand command = new SqlCommand("SELECT Masinhvien,Hoten FROM dbo.SINHVIEN", mydb.getConnection);
            mydb.openConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            comboBoxMaSinhVien.DataSource = table;
            comboBoxMaSinhVien.DisplayMember = "Masinhvien";
            comboBoxMaSinhVien.ValueMember = "Hoten";

        }
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxMaSach.Text.Trim() == "")
            {
                return;
            }
            else
            {
                try
                {
                    string MSSach = comboBoxMaSach.SelectedValue.ToString();
                    textBoxTenSach.Text = MSSach;
                    string mamuontra = comboBoxMaSach.SelectedValue.ToString();
                    textBoxMaMuonTra.Text = mamuontra;
                }
                catch
                {

                    textBoxTenSach.Text = "";
                    textBoxMaMuonTra.Text = "";
                }
            }
            //textBoxTenSach.Text = comboBoxMaSach.SelectedValue.ToString();


        }
        private void comboBoxMaSinhVien_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string a = comboBoxMaSinhVien.SelectedValue.ToString();
                textBoxTenSV.Text = a;
            }
            catch
            {
                textBoxTenSV.Text = "";
            }
            //textBoxTenSach.Text = comboBoxMaSach.SelectedValue.ToString();


        }

        private void buttonTraSach_Click(object sender, EventArgs e)
        {
            if ((textBoxSoLuong.Text.Trim() == ""))
            {
                MessageBox.Show("Nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;

            }
            else
            {
                decimal check;
                if (decimal.TryParse(textBoxSoLuong.Text, out check) == false)
                {
                    MessageBox.Show("nhập đúng định dạng số lượng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    SACH sach = new SACH();
                    TRASACH trasach = new TRASACH();
                    int masach = Convert.ToInt32(comboBoxMaSach.Text);
                    int mamuontra = Convert.ToInt32(textBoxMaMuonTra.Text);
                    string tensach = textBoxTenSach.Text;
                    int masinhvien = Convert.ToInt32(comboBoxMaSinhVien.Text);
                    string hoten = textBoxTenSV.Text;
                    int soluong = Convert.ToInt32(textBoxSoLuong.Text);
                    DateTime ngaytra = dateTimePickerNgayTra.Value;

                    //check thỏa điều kiện mượn trả 

                    //ràng buộc dữ liệu về năm xuất bản(ko cho người dùng nhập sai)
                    //năm xuất bản < năm hiện tại


                    if (verif())
                    {
                        try
                        {
                            if (trasach.insertSachTra(masach, mamuontra, tensach, masinhvien, hoten, soluong, ngaytra))
                            {
                                int dong = dataGridViewSachMuon.CurrentRow.Index;
                                DateTime ngayhen = Convert.ToDateTime(dataGridViewSachMuon.Rows[dong].Cells[7].Value);
                                if (ngaytra > ngayhen)
                                {
                                    MessageBox.Show("Trả quá hạn kiểm tra bảng phạt", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Trả sách thành công", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không trả được sách", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Nhập sai số lượng", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
    }
        bool verif()
        {
            if ((textBoxMaMuonTra.Text.Trim() == "") || (textBoxSoLuong.Text.Trim() == ""))
            {


                MessageBox.Show("Vui lòng nhập đúng định dạng", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
            {
                return true;
            }
        }
       

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}