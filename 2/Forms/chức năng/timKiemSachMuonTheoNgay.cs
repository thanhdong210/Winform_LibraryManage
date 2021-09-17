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
    public partial class timKiemSachMuonTheoNgay : Form
    {
        public timKiemSachMuonTheoNgay()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timKiemSachMuonTheoNgay_Load(object sender, EventArgs e)
        {

        }

        MUONSACH muonsach = new MUONSACH();
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string From = dateTimePickerFrom.Value.ToString();
            string To = dateTimePickerTo.Value.ToString();

            SqlCommand command = new SqlCommand("select * from dbo.sachMuonTrongKhoangThoiGian (@from, @to)");
            command.Parameters.Add("@from", SqlDbType.DateTime).Value = From;
            command.Parameters.Add("@to", SqlDbType.DateTime).Value = To;
            dataGridViewResult.DataSource = muonsach.getSach(command);
        }
    }
}
