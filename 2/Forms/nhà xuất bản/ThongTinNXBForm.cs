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
    public partial class ThongTinNXBForm : Form
    {
        NXB nxb = new NXB();
        public ThongTinNXBForm()
        {
            InitializeComponent();
        }
        private void ThongtinNXB_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT Manxb as 'Mã NXB',TenNXB as 'Tên NXB',Diachi_NXB as 'Địa chỉ' FROM NHAXUATBAN");
            dataGridViewNXB.ReadOnly = true;


            dataGridViewNXB.RowTemplate.Height = 80;
            dataGridViewNXB.DataSource =nxb.getNXB(command);

            dataGridViewNXB.AllowUserToAddRows = false;


        }

        private void buttonRF_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Manxb as 'Mã NXB',TenNXB as 'Tên NXB',Diachi_NXB as 'Địa chỉ' FROM NHAXUATBAN");
            dataGridViewNXB.ReadOnly = true;
            
            dataGridViewNXB.RowTemplate.Height = 80;
            dataGridViewNXB.DataSource = nxb.getNXB(command);
            dataGridViewNXB.AllowUserToAddRows = false;
        }
    }
   
}
