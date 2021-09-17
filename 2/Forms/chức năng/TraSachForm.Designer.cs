
namespace _2
{
    partial class TraSachForm
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
            this.textBoxTenSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTenSach = new System.Windows.Forms.TextBox();
            this.comboBoxMaSach = new System.Windows.Forms.ComboBox();
            this.comboBoxMaSinhVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonTraSach = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaMuonTra = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.dataGridViewSachTra = new System.Windows.Forms.DataGridView();
            this.dataGridViewSachMuon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSachTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTenSV
            // 
            this.textBoxTenSV.Location = new System.Drawing.Point(218, 369);
            this.textBoxTenSV.Name = "textBoxTenSV";
            this.textBoxTenSV.ReadOnly = true;
            this.textBoxTenSV.Size = new System.Drawing.Size(178, 23);
            this.textBoxTenSV.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(22, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Họ tên sinh viên:";
            // 
            // textBoxTenSach
            // 
            this.textBoxTenSach.Location = new System.Drawing.Point(218, 145);
            this.textBoxTenSach.Name = "textBoxTenSach";
            this.textBoxTenSach.ReadOnly = true;
            this.textBoxTenSach.Size = new System.Drawing.Size(178, 23);
            this.textBoxTenSach.TabIndex = 54;
            // 
            // comboBoxMaSach
            // 
            this.comboBoxMaSach.FormattingEnabled = true;
            this.comboBoxMaSach.Location = new System.Drawing.Point(218, 74);
            this.comboBoxMaSach.Name = "comboBoxMaSach";
            this.comboBoxMaSach.Size = new System.Drawing.Size(178, 24);
            this.comboBoxMaSach.TabIndex = 53;
            this.comboBoxMaSach.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // comboBoxMaSinhVien
            // 
            this.comboBoxMaSinhVien.FormattingEnabled = true;
            this.comboBoxMaSinhVien.Location = new System.Drawing.Point(218, 298);
            this.comboBoxMaSinhVien.Name = "comboBoxMaSinhVien";
            this.comboBoxMaSinhVien.Size = new System.Drawing.Size(178, 24);
            this.comboBoxMaSinhVien.TabIndex = 52;
            this.comboBoxMaSinhVien.SelectedValueChanged += new System.EventHandler(this.comboBoxMaSinhVien_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(70, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Tên sách:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(43, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Số lượng trả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(63, 538);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Ngày trả:";
            // 
            // dateTimePickerNgayTra
            // 
            this.dateTimePickerNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayTra.Location = new System.Drawing.Point(218, 533);
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            this.dateTimePickerNgayTra.Size = new System.Drawing.Size(178, 23);
            this.dateTimePickerNgayTra.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(48, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Mã mượn trả:";
            // 
            // buttonHuy
            // 
            this.buttonHuy.Image = global::_2.Properties.Resources.Button_Stop;
            this.buttonHuy.Location = new System.Drawing.Point(250, 596);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(125, 51);
            this.buttonHuy.TabIndex = 46;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonTraSach
            // 
            this.buttonTraSach.Image = global::_2.Properties.Resources.Box_Remove;
            this.buttonTraSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTraSach.Location = new System.Drawing.Point(73, 596);
            this.buttonTraSach.Name = "buttonTraSach";
            this.buttonTraSach.Size = new System.Drawing.Size(135, 51);
            this.buttonTraSach.TabIndex = 45;
            this.buttonTraSach.Text = "Trả sách";
            this.buttonTraSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTraSach.UseVisualStyleBackColor = true;
            this.buttonTraSach.Click += new System.EventHandler(this.buttonTraSach_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(70, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Mã sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(48, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mã sinh viên:";
            // 
            // textBoxMaMuonTra
            // 
            this.textBoxMaMuonTra.Location = new System.Drawing.Point(218, 234);
            this.textBoxMaMuonTra.Name = "textBoxMaMuonTra";
            this.textBoxMaMuonTra.ReadOnly = true;
            this.textBoxMaMuonTra.Size = new System.Drawing.Size(178, 23);
            this.textBoxMaMuonTra.TabIndex = 42;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(218, 451);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(176, 23);
            this.textBoxSoLuong.TabIndex = 41;
            // 
            // dataGridViewSachTra
            // 
            this.dataGridViewSachTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSachTra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewSachTra.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSachTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSachTra.Location = new System.Drawing.Point(486, 379);
            this.dataGridViewSachTra.Name = "dataGridViewSachTra";
            this.dataGridViewSachTra.RowHeadersWidth = 51;
            this.dataGridViewSachTra.RowTemplate.Height = 24;
            this.dataGridViewSachTra.Size = new System.Drawing.Size(822, 308);
            this.dataGridViewSachTra.TabIndex = 40;
            // 
            // dataGridViewSachMuon
            // 
            this.dataGridViewSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSachMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewSachMuon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSachMuon.Location = new System.Drawing.Point(486, 49);
            this.dataGridViewSachMuon.Name = "dataGridViewSachMuon";
            this.dataGridViewSachMuon.RowHeadersWidth = 51;
            this.dataGridViewSachMuon.RowTemplate.Height = 24;
            this.dataGridViewSachMuon.Size = new System.Drawing.Size(822, 288);
            this.dataGridViewSachMuon.TabIndex = 39;
            this.dataGridViewSachMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SachdangduocmuonForm_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(897, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Sách trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(847, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Sách đang được mượn";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(429, 641);
            this.flowLayoutPanel1.TabIndex = 58;
            // 
            // TraSachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1330, 703);
            this.Controls.Add(this.textBoxTenSV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTenSach);
            this.Controls.Add(this.comboBoxMaSach);
            this.Controls.Add(this.comboBoxMaSinhVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerNgayTra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonTraSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaMuonTra);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.dataGridViewSachTra);
            this.Controls.Add(this.dataGridViewSachMuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "TraSachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraSachForm";
            this.Load += new System.EventHandler(this.TraSachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSachTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxTenSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTenSach;
        public System.Windows.Forms.ComboBox comboBoxMaSach;
        public System.Windows.Forms.ComboBox comboBoxMaSinhVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonTraSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxMaMuonTra;
        public System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.DataGridView dataGridViewSachTra;
        private System.Windows.Forms.DataGridView dataGridViewSachMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}