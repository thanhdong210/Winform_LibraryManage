
namespace _2
{
    partial class MuonSachForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewSach = new System.Windows.Forms.DataGridView();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.buttonMuonSach = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMaSach = new System.Windows.Forms.ComboBox();
            this.comboBoxMaSinhVien = new System.Windows.Forms.ComboBox();
            this.textBoxTenSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTenSV = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSach
            // 
            this.dataGridViewSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewSach.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSach.Location = new System.Drawing.Point(400, 39);
            this.dataGridViewSach.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.RowHeadersWidth = 51;
            this.dataGridViewSach.RowTemplate.Height = 24;
            this.dataGridViewSach.Size = new System.Drawing.Size(895, 287);
            this.dataGridViewSach.TabIndex = 0;
            this.dataGridViewSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SachtrongthuvienForm_CellClick);
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSinhVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(400, 388);
            this.dataGridViewSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.RowHeadersWidth = 51;
            this.dataGridViewSinhVien.RowTemplate.Height = 24;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(895, 288);
            this.dataGridViewSinhVien.TabIndex = 1;
            this.dataGridViewSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SinhVienForm_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(778, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sách trong thư viện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(814, 352);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(54, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(76, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã sách:";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(181, 352);
            this.textBoxSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(176, 23);
            this.textBoxSoLuong.TabIndex = 4;
            // 
            // buttonMuonSach
            // 
            this.buttonMuonSach.Image = global::_2.Properties.Resources.Box_Add;
            this.buttonMuonSach.Location = new System.Drawing.Point(34, 539);
            this.buttonMuonSach.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMuonSach.Name = "buttonMuonSach";
            this.buttonMuonSach.Size = new System.Drawing.Size(135, 52);
            this.buttonMuonSach.TabIndex = 7;
            this.buttonMuonSach.Text = "Mượn sách";
            this.buttonMuonSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMuonSach.UseVisualStyleBackColor = true;
            this.buttonMuonSach.Click += new System.EventHandler(this.buttonMuonSach_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(53, 508);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hạn phải trả:";
            // 
            // dateTimePickerNgayTra
            // 
            this.dateTimePickerNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayTra.Location = new System.Drawing.Point(184, 502);
            this.dateTimePickerNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            this.dateTimePickerNgayTra.Size = new System.Drawing.Size(179, 23);
            this.dateTimePickerNgayTra.TabIndex = 10;
            this.dateTimePickerNgayTra.ValueChanged += new System.EventHandler(this.dateTimePickerNgayTra_ValueChanged);
            // 
            // dateTimePickerNgayMuon
            // 
            this.dateTimePickerNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayMuon.Location = new System.Drawing.Point(184, 439);
            this.dateTimePickerNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerNgayMuon.Name = "dateTimePickerNgayMuon";
            this.dateTimePickerNgayMuon.Size = new System.Drawing.Size(179, 23);
            this.dateTimePickerNgayMuon.TabIndex = 10;
            this.dateTimePickerNgayMuon.ValueChanged += new System.EventHandler(this.dateTimePickerNgayTra_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(59, 444);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ngày mượn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(38, 359);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Số lượng mượn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(76, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên sách:";
            // 
            // comboBoxMaSach
            // 
            this.comboBoxMaSach.FormattingEnabled = true;
            this.comboBoxMaSach.Location = new System.Drawing.Point(184, 60);
            this.comboBoxMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaSach.Name = "comboBoxMaSach";
            this.comboBoxMaSach.Size = new System.Drawing.Size(179, 24);
            this.comboBoxMaSach.TabIndex = 15;
            this.comboBoxMaSach.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // comboBoxMaSinhVien
            // 
            this.comboBoxMaSinhVien.FormattingEnabled = true;
            this.comboBoxMaSinhVien.Location = new System.Drawing.Point(181, 206);
            this.comboBoxMaSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaSinhVien.Name = "comboBoxMaSinhVien";
            this.comboBoxMaSinhVien.Size = new System.Drawing.Size(179, 24);
            this.comboBoxMaSinhVien.TabIndex = 15;
            this.comboBoxMaSinhVien.SelectedValueChanged += new System.EventHandler(this.comboBoxMaSinhVien_SelectedValueChanged);
            // 
            // textBoxTenSach
            // 
            this.textBoxTenSach.Location = new System.Drawing.Point(184, 128);
            this.textBoxTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenSach.Name = "textBoxTenSach";
            this.textBoxTenSach.ReadOnly = true;
            this.textBoxTenSach.Size = new System.Drawing.Size(179, 23);
            this.textBoxTenSach.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(28, 284);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Họ tên sinh viên:";
            // 
            // textBoxTenSV
            // 
            this.textBoxTenSV.Location = new System.Drawing.Point(181, 284);
            this.textBoxTenSV.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenSV.Name = "textBoxTenSV";
            this.textBoxTenSV.ReadOnly = true;
            this.textBoxTenSV.Size = new System.Drawing.Size(179, 23);
            this.textBoxTenSV.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.buttonMuonSach);
            this.panel1.Controls.Add(this.buttonHuy);
            this.panel1.Location = new System.Drawing.Point(22, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 640);
            this.panel1.TabIndex = 19;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Image = global::_2.Properties.Resources.Stop1;
            this.buttonHuy.Location = new System.Drawing.Point(210, 539);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(125, 52);
            this.buttonHuy.TabIndex = 8;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // MuonSachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1307, 683);
            this.Controls.Add(this.textBoxTenSV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTenSach);
            this.Controls.Add(this.comboBoxMaSach);
            this.Controls.Add(this.comboBoxMaSinhVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerNgayMuon);
            this.Controls.Add(this.dateTimePickerNgayTra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSinhVien);
            this.Controls.Add(this.dataGridViewSach);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MuonSachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuonSachForm";
            this.Load += new System.EventHandler(this.MuonSachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSach;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMuonSach;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        public System.Windows.Forms.DateTimePicker dateTimePickerNgayMuon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTenSach;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxTenSV;
        public System.Windows.Forms.TextBox textBoxSoLuong;
        public System.Windows.Forms.ComboBox comboBoxMaSach;
        public System.Windows.Forms.ComboBox comboBoxMaSinhVien;
        private System.Windows.Forms.Panel panel1;
    }
}