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
    public partial class ThongKeLoaiSachForm : Form
    {
        SACH sach = new SACH();
        public ThongKeLoaiSachForm()
        {
            InitializeComponent();
        }
        private void ThongKeLoaiSachForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select Loaisach as 'Loại sách',sum(Soluong) AS 'Số lượng' from TTSACH group by Loaisach");
            dataGridViewLoaiSach.ReadOnly = true;
            dataGridViewLoaiSach.RowTemplate.Height = 80;
            dataGridViewLoaiSach.DataSource = sach.getSach(command);
            dataGridViewLoaiSach.AllowUserToAddRows = false;


            //
            //chartAVG.Series["ChartAVG"].Points.AddXY("thang 2", 1500);
            //chartAVG.Series["ChartAVG"].Points.AddXY("thang 3", 1400);
            //chartAVG.Series["ChartAVG"].Points.AddXY("thang 4", 1200);
            int RowCount = dataGridViewLoaiSach.Rows.Count; //hang`
            int ColumnCount = dataGridViewLoaiSach.Columns.Count; //cot
            int r;
            string ten_tam;
            int giatri;
            for (r = 0; r < RowCount; r++) //chay hang`
            {
                ten_tam = dataGridViewLoaiSach.Rows[r].Cells[0].Value.ToString();
                for (int c = 1; c < ColumnCount; c++)
                {
                    giatri = Convert.ToInt32(dataGridViewLoaiSach.Rows[r].Cells[c].Value);
                    chartLS.Series["ChartLS"].Points.AddXY(ten_tam, giatri);
                }
            }
        }
    }
}
