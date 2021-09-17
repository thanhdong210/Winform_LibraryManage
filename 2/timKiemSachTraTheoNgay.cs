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
    public partial class timKiemSachTraTheoNgay : Form
    {
        public timKiemSachTraTheoNgay()
        {
            InitializeComponent();
        }

        TRASACH trasach = new TRASACH();

        private void timKiemSachTraTheoNgay_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string From = dateTimePickerFrom.Value.ToString();
            string To = dateTimePickerTo.Value.ToString();

            SqlCommand command = new SqlCommand("exec sachTraTrongKhoangThoiGian @from, @to");
            command.Parameters.Add("@from", SqlDbType.DateTime).Value = From;
            command.Parameters.Add("@to", SqlDbType.DateTime).Value = To;
            dataGridViewTimSachTra.DataSource = trasach.getSach(command);
        }
    }
}
