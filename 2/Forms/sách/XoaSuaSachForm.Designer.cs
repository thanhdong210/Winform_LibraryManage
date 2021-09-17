
namespace _2
{
    partial class XoaSuaSachForm
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
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.textBoxManxb = new System.Windows.Forms.TextBox();
            this.labelMaNhaXuatBan = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelNamXuatBan = new System.Windows.Forms.Label();
            this.textBoxTenTacGia = new System.Windows.Forms.TextBox();
            this.labelTenTacGia = new System.Windows.Forms.Label();
            this.textBoxLoaiSach = new System.Windows.Forms.TextBox();
            this.labelLoaiSach = new System.Windows.Forms.Label();
            this.textBoxTenSach = new System.Windows.Forms.TextBox();
            this.textBoxMaSach = new System.Windows.Forms.TextBox();
            this.labelTenSach = new System.Windows.Forms.Label();
            this.labelMaSach = new System.Windows.Forms.Label();
            this.dateTimePickerNamxb = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewXoaSua = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaSua)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonXoa
            // 
            this.buttonXoa.Image = global::_2.Properties.Resources.Box_Remove;
            this.buttonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoa.Location = new System.Drawing.Point(32, 551);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(130, 60);
            this.buttonXoa.TabIndex = 31;
            this.buttonXoa.Text = "Xóa cuốn sách này";
            this.buttonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Image = global::_2.Properties.Resources.Glyph_Check;
            this.buttonLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLuu.Location = new System.Drawing.Point(202, 551);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(155, 60);
            this.buttonLuu.TabIndex = 30;
            this.buttonLuu.Text = "Lưu thông tin vừa cập nhật";
            this.buttonLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // textBoxManxb
            // 
            this.textBoxManxb.Location = new System.Drawing.Point(187, 486);
            this.textBoxManxb.Name = "textBoxManxb";
            this.textBoxManxb.Size = new System.Drawing.Size(169, 23);
            this.textBoxManxb.TabIndex = 29;
            // 
            // labelMaNhaXuatBan
            // 
            this.labelMaNhaXuatBan.AutoSize = true;
            this.labelMaNhaXuatBan.BackColor = System.Drawing.Color.Silver;
            this.labelMaNhaXuatBan.Location = new System.Drawing.Point(28, 486);
            this.labelMaNhaXuatBan.Name = "labelMaNhaXuatBan";
            this.labelMaNhaXuatBan.Size = new System.Drawing.Size(143, 17);
            this.labelMaNhaXuatBan.TabIndex = 28;
            this.labelMaNhaXuatBan.Text = "Mã nhà xuất bản:";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(187, 412);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(169, 23);
            this.textBoxSoLuong.TabIndex = 27;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.BackColor = System.Drawing.Color.Silver;
            this.labelSoLuong.Location = new System.Drawing.Point(74, 417);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(84, 17);
            this.labelSoLuong.TabIndex = 26;
            this.labelSoLuong.Text = "Số lượng:";
            // 
            // labelNamXuatBan
            // 
            this.labelNamXuatBan.AutoSize = true;
            this.labelNamXuatBan.BackColor = System.Drawing.Color.Silver;
            this.labelNamXuatBan.Location = new System.Drawing.Point(43, 346);
            this.labelNamXuatBan.Name = "labelNamXuatBan";
            this.labelNamXuatBan.Size = new System.Drawing.Size(121, 17);
            this.labelNamXuatBan.TabIndex = 24;
            this.labelNamXuatBan.Text = "Năm xuất bản:";
            // 
            // textBoxTenTacGia
            // 
            this.textBoxTenTacGia.Location = new System.Drawing.Point(187, 268);
            this.textBoxTenTacGia.Name = "textBoxTenTacGia";
            this.textBoxTenTacGia.Size = new System.Drawing.Size(169, 23);
            this.textBoxTenTacGia.TabIndex = 23;
            // 
            // labelTenTacGia
            // 
            this.labelTenTacGia.AutoSize = true;
            this.labelTenTacGia.BackColor = System.Drawing.Color.Silver;
            this.labelTenTacGia.Location = new System.Drawing.Point(62, 271);
            this.labelTenTacGia.Name = "labelTenTacGia";
            this.labelTenTacGia.Size = new System.Drawing.Size(104, 17);
            this.labelTenTacGia.TabIndex = 22;
            this.labelTenTacGia.Text = "Tên tác giả: ";
            // 
            // textBoxLoaiSach
            // 
            this.textBoxLoaiSach.Location = new System.Drawing.Point(187, 195);
            this.textBoxLoaiSach.Name = "textBoxLoaiSach";
            this.textBoxLoaiSach.Size = new System.Drawing.Size(169, 23);
            this.textBoxLoaiSach.TabIndex = 21;
            // 
            // labelLoaiSach
            // 
            this.labelLoaiSach.AutoSize = true;
            this.labelLoaiSach.BackColor = System.Drawing.Color.Silver;
            this.labelLoaiSach.Location = new System.Drawing.Point(80, 198);
            this.labelLoaiSach.Name = "labelLoaiSach";
            this.labelLoaiSach.Size = new System.Drawing.Size(86, 17);
            this.labelLoaiSach.TabIndex = 20;
            this.labelLoaiSach.Text = "Loại sách:";
            // 
            // textBoxTenSach
            // 
            this.textBoxTenSach.Location = new System.Drawing.Point(187, 128);
            this.textBoxTenSach.Name = "textBoxTenSach";
            this.textBoxTenSach.Size = new System.Drawing.Size(169, 23);
            this.textBoxTenSach.TabIndex = 19;
            // 
            // textBoxMaSach
            // 
            this.textBoxMaSach.Location = new System.Drawing.Point(187, 74);
            this.textBoxMaSach.Name = "textBoxMaSach";
            this.textBoxMaSach.Size = new System.Drawing.Size(169, 23);
            this.textBoxMaSach.TabIndex = 18;
            // 
            // labelTenSach
            // 
            this.labelTenSach.AutoSize = true;
            this.labelTenSach.BackColor = System.Drawing.Color.Silver;
            this.labelTenSach.Location = new System.Drawing.Point(74, 133);
            this.labelTenSach.Name = "labelTenSach";
            this.labelTenSach.Size = new System.Drawing.Size(83, 17);
            this.labelTenSach.TabIndex = 17;
            this.labelTenSach.Text = "Tên sách:";
            // 
            // labelMaSach
            // 
            this.labelMaSach.AutoSize = true;
            this.labelMaSach.BackColor = System.Drawing.Color.Silver;
            this.labelMaSach.Location = new System.Drawing.Point(80, 77);
            this.labelMaSach.Name = "labelMaSach";
            this.labelMaSach.Size = new System.Drawing.Size(76, 17);
            this.labelMaSach.TabIndex = 16;
            this.labelMaSach.Text = "Mã sách:";
            // 
            // dateTimePickerNamxb
            // 
            this.dateTimePickerNamxb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNamxb.Location = new System.Drawing.Point(187, 346);
            this.dateTimePickerNamxb.Name = "dateTimePickerNamxb";
            this.dateTimePickerNamxb.Size = new System.Drawing.Size(169, 23);
            this.dateTimePickerNamxb.TabIndex = 32;
            // 
            // dataGridViewXoaSua
            // 
            this.dataGridViewXoaSua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXoaSua.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewXoaSua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXoaSua.Location = new System.Drawing.Point(396, 58);
            this.dataGridViewXoaSua.Name = "dataGridViewXoaSua";
            this.dataGridViewXoaSua.RowHeadersWidth = 51;
            this.dataGridViewXoaSua.RowTemplate.Height = 24;
            this.dataGridViewXoaSua.Size = new System.Drawing.Size(920, 633);
            this.dataGridViewXoaSua.TabIndex = 33;
            this.dataGridViewXoaSua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.XoaSuaSachForm_CellClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::_2.Properties.Resources.Glyph_Check;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(256, 644);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(133, 47);
            this.buttonRefresh.TabIndex = 34;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(14, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 580);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(802, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Thông tin sách";
            // 
            // XoaSuaSachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1330, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewXoaSua);
            this.Controls.Add(this.dateTimePickerNamxb);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.textBoxManxb);
            this.Controls.Add(this.labelMaNhaXuatBan);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.labelNamXuatBan);
            this.Controls.Add(this.textBoxTenTacGia);
            this.Controls.Add(this.labelTenTacGia);
            this.Controls.Add(this.textBoxLoaiSach);
            this.Controls.Add(this.labelLoaiSach);
            this.Controls.Add(this.textBoxTenSach);
            this.Controls.Add(this.textBoxMaSach);
            this.Controls.Add(this.labelTenSach);
            this.Controls.Add(this.labelMaSach);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "XoaSuaSachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XoaSuaSachForm";
            this.Load += new System.EventHandler(this.XoaSuaSachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaSua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonXoa;
        public System.Windows.Forms.Button buttonLuu;
        public System.Windows.Forms.Label labelMaNhaXuatBan;
        public System.Windows.Forms.TextBox textBoxSoLuong;
        public System.Windows.Forms.Label labelSoLuong;
        public System.Windows.Forms.Label labelNamXuatBan;
        public System.Windows.Forms.TextBox textBoxTenTacGia;
        public System.Windows.Forms.Label labelTenTacGia;
        public System.Windows.Forms.TextBox textBoxLoaiSach;
        public System.Windows.Forms.Label labelLoaiSach;
        public System.Windows.Forms.TextBox textBoxTenSach;
        public System.Windows.Forms.TextBox textBoxMaSach;
        public System.Windows.Forms.Label labelTenSach;
        public System.Windows.Forms.Label labelMaSach;
        public System.Windows.Forms.DateTimePicker dateTimePickerNamxb;
        public System.Windows.Forms.TextBox textBoxManxb;
        private System.Windows.Forms.DataGridView dataGridViewXoaSua;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}