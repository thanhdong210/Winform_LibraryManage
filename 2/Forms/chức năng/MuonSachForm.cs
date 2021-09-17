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
    
    public partial class MuonSachForm : Form
    {
        SqlDataAdapter da;
        MY_DB mydb = new MY_DB();
        SACH sach = new SACH();
        public MuonSachForm()
        {
            InitializeComponent();
           
        }

        private void dateTimePickerNgayTra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MuonSachForm_Load(object sender, EventArgs e)
        {
            //bang sach
            SqlCommand command = new SqlCommand("SELECT Masach as 'Mã sách',Tensach as 'Tên sách',Loaisach as 'Loại sách',Tentacgia as 'Tên tác giả',Namxb as 'Năm xuất bản',Soluong as 'Số lượng',Manxb as 'Mã nhà xuất bản' FROM TTSACH");
            dataGridViewSach.ReadOnly = true;
            dataGridViewSach.RowTemplate.Height = 80;
            dataGridViewSach.DataSource = sach.getSach(command);
            dataGridViewSach.AllowUserToAddRows = false;
            //bang sinh vien
            SqlCommand command2= new SqlCommand("SELECT Masinhvien as 'Mã sinh viên',Hoten as 'Họ và Tên',Quequan as 'Quê quán',Gioitinh as 'Giới tính',Ngaysinh as 'Ngày sinh',Sluong as 'Số lượng' FROM SINHVIEN");
            dataGridViewSinhVien.ReadOnly = true;
            dataGridViewSinhVien.RowTemplate.Height = 80;
            dataGridViewSinhVien.DataSource = sach.getSach(command2);
            dataGridViewSach.AllowUserToAddRows = false;
            //combobox
            ShowComboboxMaSach();
            
            ShowComboboxMaSinhVien();

        }
        

       
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string MSSach = comboBoxMaSach.SelectedValue.ToString();
                textBoxTenSach.Text = MSSach;
            }
            catch
            {
                textBoxTenSach.Text = "";
            }
            //textBoxTenSach.Text = comboBoxMaSach.SelectedValue.ToString();
           

        }
        private void comboBoxMaSinhVien_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string a= comboBoxMaSinhVien.SelectedValue.ToString();
                textBoxTenSV.Text = a;
            }
            catch
            {
                textBoxTenSV.Text = "";
            }
            //textBoxTenSach.Text = comboBoxMaSach.SelectedValue.ToString();


        }
        public void ShowComboboxMaSach()
        {
            SqlCommand command = new SqlCommand("SELECT Masach,Tensach FROM TTSACH", mydb.getConnection);
            mydb.openConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            comboBoxMaSach.DataSource = table;
            comboBoxMaSach.DisplayMember = "Masach";
            comboBoxMaSach.ValueMember = "Tensach";
           

            
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

        private void SachtrongthuvienForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            comboBoxMaSach.Text = dataGridViewSach.CurrentRow.Cells[0].Value.ToString();
            textBoxTenSach.Text = dataGridViewSach.CurrentRow.Cells[1].Value.ToString();

        }
        private void SinhVienForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            comboBoxMaSinhVien.Text = dataGridViewSinhVien.CurrentRow.Cells[0].Value.ToString();
            textBoxTenSV.Text = dataGridViewSinhVien.CurrentRow.Cells[1].Value.ToString();

        }

        private void buttonMuonSach_Click(object sender, EventArgs e)
        {
            LICHSU ls = new LICHSU();
            if ( (textBoxSoLuong.Text.Trim() == ""))
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
                    MUONSACH muonsach = new MUONSACH();
                    int masach = Convert.ToInt32(comboBoxMaSach.Text);

                    string tensach = textBoxTenSach.Text;
                    int masinhvien = Convert.ToInt32(comboBoxMaSinhVien.Text);
                    string hoten = textBoxTenSV.Text;
                    int soluong = Convert.ToInt32(textBoxSoLuong.Text);


                    DateTime ngaymuon = dateTimePickerNgayMuon.Value;
                    DateTime ngaytra = dateTimePickerNgayTra.Value;

                    //check thỏa điều kiện mượn trả 

                    //ràng buộc dữ liệu về năm xuất bản(ko cho người dùng nhập sai)
                    //năm xuất bản < năm hiện tại

                    if (verif() && kiemtrangaymuontra())
                    {


                        if (muonsach.insertSachMuon(masach, tensach, masinhvien, hoten, soluong, ngaymuon, ngaytra))
                        {
                            if (ls.insertLichSuMuonSach(masach, tensach, masinhvien, hoten, soluong, ngaymuon, ngaytra))
                            {
                                MessageBox.Show("Mượn sách thành công", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            //MessageBox.Show("kiem tra bang phat", "Tra sach", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            MessageBox.Show("Chưa mượn được sách", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {

                        MessageBox.Show("LỖI", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
        }
        bool verif()
        {
            if ((textBoxSoLuong.Text.Trim() == "") )
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }
            else
            {
                return true;
            }
        }
        bool kiemtrangaymuontra()
        {
            int daymuon = dateTimePickerNgayMuon.Value.Day;
            int daytra = dateTimePickerNgayTra.Value.Day;
            int thangmuon = dateTimePickerNgayMuon.Value.Month;
            int thangtra = dateTimePickerNgayTra.Value.Month;
            int nammuon = dateTimePickerNgayMuon.Value.Year;
            int namtra = dateTimePickerNgayTra.Value.Year;
            if(nammuon==namtra)
            {
                if(thangmuon==thangtra)
                {
                    if(daymuon>daytra)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }    
                }
                else if(thangmuon<thangtra)
                {
                    return true;
                }    
                else
                {
                    return false;
                }    
                
            }
            else if(nammuon<namtra)
            {
                return true;
            }    
            else 
            {
                return false;
            }
            

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
