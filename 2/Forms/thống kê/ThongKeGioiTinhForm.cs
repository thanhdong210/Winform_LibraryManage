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
    public partial class ThongKeGioiTinhForm : Form
    {
        public ThongKeGioiTinhForm()
        {
            InitializeComponent();
        }
        private void ThongKeGioiTinhForm_Load(object sender, EventArgs e)
        {

            //hiển thị giá trị
            SINHVIEN sinhvien = new SINHVIEN();
            double total = Convert.ToDouble(sinhvien.totalSV());
            double totalnam = Convert.ToDouble(sinhvien.totalNam());
            double totalnu = Convert.ToDouble(sinhvien.totalNu());
            //tính % 
            //(tổng student*100)/(total students)
           
           


            double nuPercentage = (totalnu * (100 / total));
            double namPercentage = (totalnam * (100 / total));
            labelTotalSV.Text = ("Tổng số Sinh Viên: " + total.ToString());
            labelNam.Text = ("Nam: " + (namPercentage.ToString("0.00") + "%"));

            labelNu.Text = ("Nữ: " + (nuPercentage.ToString("0.00") + "%"));
        }
    }
}
