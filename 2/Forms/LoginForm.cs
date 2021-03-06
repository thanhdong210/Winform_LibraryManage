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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            if (radioButtonNhanVien.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM nhanvien WHERE username = @User AND password = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonQuanLy.Checked)
            {
                //form bên human resource
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM quanly WHERE username = @User AND password = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {

                    //this.DialogResult = DialogResult.OK;
                    this.Hide();
                    QuanLyForm hrf = new QuanLyForm();

                    hrf.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
