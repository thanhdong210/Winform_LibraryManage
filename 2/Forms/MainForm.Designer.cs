
namespace _2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóasửaSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóasửaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóasửaNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phạtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePickerXemGio = new System.Windows.Forms.DateTimePicker();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sáchTrảTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchToolStripMenuItem,
            this.độcGiảToolStripMenuItem,
            this.nhàXuấtBảnToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1330, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinSáchToolStripMenuItem,
            this.thêmSáchToolStripMenuItem,
            this.xóasửaSáchToolStripMenuItem,
            this.sáchMượnToolStripMenuItem,
            this.sáchTrảToolStripMenuItem});
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.sáchToolStripMenuItem.Text = "sách";
            // 
            // thôngTinSáchToolStripMenuItem
            // 
            this.thôngTinSáchToolStripMenuItem.Image = global::_2.Properties.Resources._682d9f41_125a_49d0_b296_40f56f20d7a8;
            this.thôngTinSáchToolStripMenuItem.Name = "thôngTinSáchToolStripMenuItem";
            this.thôngTinSáchToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.thôngTinSáchToolStripMenuItem.Text = "thông tin sách ";
            this.thôngTinSáchToolStripMenuItem.Click += new System.EventHandler(this.thôngTinSáchToolStripMenuItem_Click);
            // 
            // thêmSáchToolStripMenuItem
            // 
            this.thêmSáchToolStripMenuItem.Image = global::_2.Properties.Resources.Upload;
            this.thêmSáchToolStripMenuItem.Name = "thêmSáchToolStripMenuItem";
            this.thêmSáchToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.thêmSáchToolStripMenuItem.Text = "thêm sách";
            this.thêmSáchToolStripMenuItem.Click += new System.EventHandler(this.thêmSáchToolStripMenuItem_Click);
            // 
            // xóasửaSáchToolStripMenuItem
            // 
            this.xóasửaSáchToolStripMenuItem.Image = global::_2.Properties.Resources.Warning_icon;
            this.xóasửaSáchToolStripMenuItem.Name = "xóasửaSáchToolStripMenuItem";
            this.xóasửaSáchToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.xóasửaSáchToolStripMenuItem.Text = "xóa/sửa sách";
            this.xóasửaSáchToolStripMenuItem.Click += new System.EventHandler(this.xóasửaSáchToolStripMenuItem_Click);
            // 
            // sáchMượnToolStripMenuItem
            // 
            this.sáchMượnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sáchMượnToolStripMenuItem.Image")));
            this.sáchMượnToolStripMenuItem.Name = "sáchMượnToolStripMenuItem";
            this.sáchMượnToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.sáchMượnToolStripMenuItem.Text = "thông tin sách mượn";
            this.sáchMượnToolStripMenuItem.Click += new System.EventHandler(this.sáchMượnToolStripMenuItem_Click);
            // 
            // sáchTrảToolStripMenuItem
            // 
            this.sáchTrảToolStripMenuItem.Image = global::_2.Properties.Resources._682d9f41_125a_49d0_b296_40f56f20d7a8;
            this.sáchTrảToolStripMenuItem.Name = "sáchTrảToolStripMenuItem";
            this.sáchTrảToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.sáchTrảToolStripMenuItem.Text = "thông tin sách trả";
            this.sáchTrảToolStripMenuItem.Click += new System.EventHandler(this.sáchTrảToolStripMenuItem_Click);
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinSinhViênToolStripMenuItem,
            this.thêmSinhViênToolStripMenuItem,
            this.xóasửaSinhViênToolStripMenuItem});
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.độcGiảToolStripMenuItem.Text = "sinh viên";
            this.độcGiảToolStripMenuItem.Click += new System.EventHandler(this.độcGiảToolStripMenuItem_Click);
            // 
            // thôngTinSinhViênToolStripMenuItem
            // 
            this.thôngTinSinhViênToolStripMenuItem.Image = global::_2.Properties.Resources.image_gallery1;
            this.thôngTinSinhViênToolStripMenuItem.Name = "thôngTinSinhViênToolStripMenuItem";
            this.thôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.thôngTinSinhViênToolStripMenuItem.Text = "thông tin sinh viên";
            this.thôngTinSinhViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinSinhViênToolStripMenuItem_Click);
            // 
            // thêmSinhViênToolStripMenuItem
            // 
            this.thêmSinhViênToolStripMenuItem.Image = global::_2.Properties.Resources.create_users_group_people_512;
            this.thêmSinhViênToolStripMenuItem.Name = "thêmSinhViênToolStripMenuItem";
            this.thêmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.thêmSinhViênToolStripMenuItem.Text = "thêm sinh viên";
            this.thêmSinhViênToolStripMenuItem.Click += new System.EventHandler(this.thêmSinhViênToolStripMenuItem_Click);
            // 
            // xóasửaSinhViênToolStripMenuItem
            // 
            this.xóasửaSinhViênToolStripMenuItem.Image = global::_2.Properties.Resources.Warning_icon;
            this.xóasửaSinhViênToolStripMenuItem.Name = "xóasửaSinhViênToolStripMenuItem";
            this.xóasửaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.xóasửaSinhViênToolStripMenuItem.Text = "xóa/sửa sinh viên";
            this.xóasửaSinhViênToolStripMenuItem.Click += new System.EventHandler(this.xóasửaSinhViênToolStripMenuItem_Click);
            // 
            // nhàXuấtBảnToolStripMenuItem
            // 
            this.nhàXuấtBảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhàXuấtBảnToolStripMenuItem,
            this.thêmNhàXuấtBảnToolStripMenuItem,
            this.xóasửaNhàXuấtBảnToolStripMenuItem});
            this.nhàXuấtBảnToolStripMenuItem.Name = "nhàXuấtBảnToolStripMenuItem";
            this.nhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.nhàXuấtBảnToolStripMenuItem.Text = "nhà xuất bản";
            // 
            // thôngTinNhàXuấtBảnToolStripMenuItem
            // 
            this.thôngTinNhàXuấtBảnToolStripMenuItem.Image = global::_2.Properties.Resources.images25401;
            this.thôngTinNhàXuấtBảnToolStripMenuItem.Name = "thôngTinNhàXuấtBảnToolStripMenuItem";
            this.thôngTinNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.thôngTinNhàXuấtBảnToolStripMenuItem.Text = "thông tin nhà xuất bản";
            this.thôngTinNhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNhàXuấtBảnToolStripMenuItem_Click);
            // 
            // thêmNhàXuấtBảnToolStripMenuItem
            // 
            this.thêmNhàXuấtBảnToolStripMenuItem.Image = global::_2.Properties.Resources.Upload1;
            this.thêmNhàXuấtBảnToolStripMenuItem.Name = "thêmNhàXuấtBảnToolStripMenuItem";
            this.thêmNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.thêmNhàXuấtBảnToolStripMenuItem.Text = "thêm nhà xuất bản";
            this.thêmNhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.thêmNhàXuấtBảnToolStripMenuItem_Click);
            // 
            // xóasửaNhàXuấtBảnToolStripMenuItem
            // 
            this.xóasửaNhàXuấtBảnToolStripMenuItem.Image = global::_2.Properties.Resources.Stop;
            this.xóasửaNhàXuấtBảnToolStripMenuItem.Name = "xóasửaNhàXuấtBảnToolStripMenuItem";
            this.xóasửaNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.xóasửaNhàXuấtBảnToolStripMenuItem.Text = "xóa/sửa nhà xuất bản";
            this.xóasửaNhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.xóasửaNhàXuấtBảnToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmSáchToolStripMenuItem,
            this.mượnSáchToolStripMenuItem,
            this.trảSáchToolStripMenuItem,
            this.phạtToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.chứcNăngToolStripMenuItem.Text = "chức năng";
            // 
            // tìmKiếmSáchToolStripMenuItem
            // 
            this.tìmKiếmSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchToolStripMenuItem2,
            this.sinhViênToolStripMenuItem,
            this.sáchTheoNgàyToolStripMenuItem,
            this.sáchTrảTheoNgàyToolStripMenuItem});
            this.tìmKiếmSáchToolStripMenuItem.Image = global::_2.Properties.Resources.Search;
            this.tìmKiếmSáchToolStripMenuItem.Name = "tìmKiếmSáchToolStripMenuItem";
            this.tìmKiếmSáchToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tìmKiếmSáchToolStripMenuItem.Text = "tìm kiếm";
            // 
            // sáchToolStripMenuItem2
            // 
            this.sáchToolStripMenuItem2.Image = global::_2.Properties.Resources.Documents;
            this.sáchToolStripMenuItem2.Name = "sáchToolStripMenuItem2";
            this.sáchToolStripMenuItem2.Size = new System.Drawing.Size(226, 26);
            this.sáchToolStripMenuItem2.Text = "sách";
            this.sáchToolStripMenuItem2.Click += new System.EventHandler(this.sáchToolStripMenuItem2_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Image = global::_2.Properties.Resources.image_gallery1;
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.sinhViênToolStripMenuItem.Text = "sinh viên";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // sáchTheoNgàyToolStripMenuItem
            // 
            this.sáchTheoNgàyToolStripMenuItem.Image = global::_2.Properties.Resources._682d9f41_125a_49d0_b296_40f56f20d7a8;
            this.sáchTheoNgàyToolStripMenuItem.Name = "sáchTheoNgàyToolStripMenuItem";
            this.sáchTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.sáchTheoNgàyToolStripMenuItem.Text = "sách mượn theo ngày";
            this.sáchTheoNgàyToolStripMenuItem.Click += new System.EventHandler(this.sáchTheoNgàyToolStripMenuItem_Click);
            // 
            // mượnSáchToolStripMenuItem
            // 
            this.mượnSáchToolStripMenuItem.Image = global::_2.Properties.Resources.Documents;
            this.mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            this.mượnSáchToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.mượnSáchToolStripMenuItem.Text = "mượn sách";
            this.mượnSáchToolStripMenuItem.Click += new System.EventHandler(this.mượnSáchToolStripMenuItem_Click);
            // 
            // trảSáchToolStripMenuItem
            // 
            this.trảSáchToolStripMenuItem.Image = global::_2.Properties.Resources.Bookmark;
            this.trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            this.trảSáchToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.trảSáchToolStripMenuItem.Text = "trả sách";
            this.trảSáchToolStripMenuItem.Click += new System.EventHandler(this.trảSáchToolStripMenuItem_Click);
            // 
            // phạtToolStripMenuItem
            // 
            this.phạtToolStripMenuItem.Image = global::_2.Properties.Resources.Alert;
            this.phạtToolStripMenuItem.Name = "phạtToolStripMenuItem";
            this.phạtToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.phạtToolStripMenuItem.Text = "phạt";
            this.phạtToolStripMenuItem.Click += new System.EventHandler(this.phạtToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.Window;
            this.labelTitle.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Red;
            this.labelTitle.Location = new System.Drawing.Point(628, 230);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(670, 55);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "QUAN LY THU VIEN NHOM 4";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePickerXemGio
            // 
            this.dateTimePickerXemGio.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerXemGio.Enabled = false;
            this.dateTimePickerXemGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerXemGio.Location = new System.Drawing.Point(20, 669);
            this.dateTimePickerXemGio.Name = "dateTimePickerXemGio";
            this.dateTimePickerXemGio.Size = new System.Drawing.Size(184, 23);
            this.dateTimePickerXemGio.TabIndex = 3;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(1190, 659);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(108, 32);
            this.buttonThoat.TabIndex = 4;
            this.buttonThoat.Text = "Thoat";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1330, 622);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sáchTrảTheoNgàyToolStripMenuItem
            // 
            this.sáchTrảTheoNgàyToolStripMenuItem.Name = "sáchTrảTheoNgàyToolStripMenuItem";
            this.sáchTrảTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.sáchTrảTheoNgàyToolStripMenuItem.Text = "sách trả theo ngày";
            this.sáchTrảTheoNgàyToolStripMenuItem.Click += new System.EventHandler(this.sáchTrảTheoNgàyToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1330, 703);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.dateTimePickerXemGio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phạtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmSáchToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DateTimePicker dateTimePickerXemGio;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.ToolStripMenuItem thêmSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóasửaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóasửaSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóasửaNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchTheoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchTrảTheoNgàyToolStripMenuItem;
    }
}

