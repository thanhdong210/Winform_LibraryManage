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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void giớiTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeGioiTinhForm tk = new ThongKeGioiTinhForm();
            tk.Show();
        }

        private void thôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongtinsachsForm thongtinsach = new ThongtinsachsForm();
            thongtinsach.Show();
        }

        private void sáchMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SachMuonForm sachmuon = new SachMuonForm();
            sachmuon.Show();
        }

        private void sáchTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SachTraForm sachtra = new SachTraForm();
            sachtra.Show();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void sáchMượnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKeSachMuonForm thongke = new ThongKeSachMuonForm();
            thongke.Show();
        }

        private void sáchTrảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKeSachTraForm sachtra = new ThongKeSachTraForm();
            sachtra.Show();
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemSVForm themsv = new ThemSVForm();
            themsv.Show();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinSVForm thongtinsv = new ThongTinSVForm();
            thongtinsv.Show();
        }

        private void xóasửaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaSuaSVForm xoasua = new XoaSuaSVForm();
            xoasua.Show();
        }

        private void thêmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemsachForm themsach = new ThemsachForm();
            themsach.Show();
        }

        private void xóasửaSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaSuaSachForm xoasua = new XoaSuaSachForm();
            xoasua.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuonSachForm muon = new MuonSachForm();
            muon.Show();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraSachForm tra = new TraSachForm();
            tra.Show();
        }

        private void độcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        


        private void thôngTinNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinNXBForm nxb = new ThongTinNXBForm();
            nxb.Show();
        }

        private void thêmNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNXBForm themnxb = new ThemNXBForm();
            themnxb.Show();
        }

        private void xóasửaNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaSuaNXBForm xoasuanxb = new XoaSuaNXBForm();
            xoasuanxb.Show();
        }

        private void phạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhatForm phat = new PhatForm();
            phat.Show();
        }

      

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void loạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeLoaiSachForm ls = new ThongKeLoaiSachForm();
            ls.Show();
        }

       
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemSVForm sv = new TimKiemSVForm();
            sv.Show();
        }

        private void sáchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TimKiemSachForm tk = new TimKiemSachForm();
            tk.Show();
        }

        private void sáchTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timKiemSachMuonTheoNgay tks = new timKiemSachMuonTheoNgay();
            tks.Show();
        }

       

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        Random random = new Random();
        int x = 21, y = 594, a = 1;

        private void sáchTrảTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timKiemSachTraTheoNgay tksttn = new timKiemSachTraTheoNgay();
            tksttn.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                labelTitle.Location = new Point(x, y);
                if (x > 628)
                {
                    a = -1;
                    labelTitle.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
                if (x < 21)
                {
                    a = 1;
                    labelTitle.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }

            }
            catch (Exception ex)
            { }
        }
    }
}
