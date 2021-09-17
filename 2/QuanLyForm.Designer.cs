
namespace _2
{
    partial class QuanLyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonShowFull = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabelGioiTinh = new System.Windows.Forms.LinkLabel();
            this.linkLabelSachTra = new System.Windows.Forms.LinkLabel();
            this.linkLabelSachMuon = new System.Windows.Forms.LinkLabel();
            this.linkLabelLoaiSach = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 71);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bạn đang đăng nhập dưới quyền admin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.buttonShowFull);
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Location = new System.Drawing.Point(12, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 299);
            this.panel2.TabIndex = 1;
            // 
            // buttonShowFull
            // 
            this.buttonShowFull.Location = new System.Drawing.Point(6, 243);
            this.buttonShowFull.Name = "buttonShowFull";
            this.buttonShowFull.Size = new System.Drawing.Size(333, 31);
            this.buttonShowFull.TabIndex = 0;
            this.buttonShowFull.Text = "Danh sách nhân viên";
            this.buttonShowFull.UseVisualStyleBackColor = true;
            this.buttonShowFull.Click += new System.EventHandler(this.buttonShowFull_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::_2.Properties.Resources.Glyph_Check;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(19, 112);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(118, 39);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.Text = "Chỉnh sửa";
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.textBoxMaNhanVien);
            this.panel4.Controls.Add(this.buttonDelete);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(8, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 63);
            this.panel4.TabIndex = 2;
            // 
            // textBoxMaNhanVien
            // 
            this.textBoxMaNhanVien.Location = new System.Drawing.Point(114, 15);
            this.textBoxMaNhanVien.Name = "textBoxMaNhanVien";
            this.textBoxMaNhanVien.Size = new System.Drawing.Size(114, 22);
            this.textBoxMaNhanVien.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(245, 15);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân viên";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::_2.Properties.Resources.Button_Add;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(19, 42);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(118, 43);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.linkLabelGioiTinh);
            this.panel3.Controls.Add(this.linkLabelSachTra);
            this.panel3.Controls.Add(this.linkLabelSachMuon);
            this.panel3.Controls.Add(this.linkLabelLoaiSach);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(371, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 299);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // linkLabelGioiTinh
            // 
            this.linkLabelGioiTinh.AutoSize = true;
            this.linkLabelGioiTinh.LinkColor = System.Drawing.Color.Red;
            this.linkLabelGioiTinh.Location = new System.Drawing.Point(31, 243);
            this.linkLabelGioiTinh.Name = "linkLabelGioiTinh";
            this.linkLabelGioiTinh.Size = new System.Drawing.Size(110, 17);
            this.linkLabelGioiTinh.TabIndex = 1;
            this.linkLabelGioiTinh.TabStop = true;
            this.linkLabelGioiTinh.Text = "Giới tính độc giả";
            this.linkLabelGioiTinh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGioiTinh_LinkClicked);
            // 
            // linkLabelSachTra
            // 
            this.linkLabelSachTra.AutoSize = true;
            this.linkLabelSachTra.LinkColor = System.Drawing.Color.Red;
            this.linkLabelSachTra.Location = new System.Drawing.Point(31, 182);
            this.linkLabelSachTra.Name = "linkLabelSachTra";
            this.linkLabelSachTra.Size = new System.Drawing.Size(61, 17);
            this.linkLabelSachTra.TabIndex = 1;
            this.linkLabelSachTra.TabStop = true;
            this.linkLabelSachTra.Text = "Sách trả";
            this.linkLabelSachTra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSachTra_LinkClicked);
            // 
            // linkLabelSachMuon
            // 
            this.linkLabelSachMuon.AutoSize = true;
            this.linkLabelSachMuon.LinkColor = System.Drawing.Color.Red;
            this.linkLabelSachMuon.Location = new System.Drawing.Point(31, 123);
            this.linkLabelSachMuon.Name = "linkLabelSachMuon";
            this.linkLabelSachMuon.Size = new System.Drawing.Size(79, 17);
            this.linkLabelSachMuon.TabIndex = 1;
            this.linkLabelSachMuon.TabStop = true;
            this.linkLabelSachMuon.Text = "Sách mượn";
            this.linkLabelSachMuon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSachMuon_LinkClicked);
            // 
            // linkLabelLoaiSach
            // 
            this.linkLabelLoaiSach.AutoSize = true;
            this.linkLabelLoaiSach.LinkColor = System.Drawing.Color.Red;
            this.linkLabelLoaiSach.Location = new System.Drawing.Point(31, 68);
            this.linkLabelLoaiSach.Name = "linkLabelLoaiSach";
            this.linkLabelLoaiSach.Size = new System.Drawing.Size(69, 17);
            this.linkLabelLoaiSach.TabIndex = 1;
            this.linkLabelLoaiSach.TabStop = true;
            this.linkLabelLoaiSach.Text = "Loại sách";
            this.linkLabelLoaiSach.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoaiSach_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thống kê sách trong thư viện";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // QuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(632, 389);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyForm";
            this.Text = "QuanLyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button buttonShowFull;
        public System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.TextBox textBoxMaNhanVien;
        public System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.LinkLabel linkLabelSachMuon;
        public System.Windows.Forms.LinkLabel linkLabelLoaiSach;
        public System.Windows.Forms.LinkLabel linkLabelGioiTinh;
        public System.Windows.Forms.LinkLabel linkLabelSachTra;
    }
}