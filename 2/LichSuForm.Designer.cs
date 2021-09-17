
namespace _2
{
    partial class LichSuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaSV = new System.Windows.Forms.TextBox();
            this.textBoxTenSV = new System.Windows.Forms.TextBox();
            this.dataGridViewMuonSach = new System.Windows.Forms.DataGridView();
            this.dataGridViewTraSach = new System.Windows.Forms.DataGridView();
            this.buttonDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuonSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1080, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lịch sử trả sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lịch sử mượn sách";
            // 
            // textBoxMaSV
            // 
            this.textBoxMaSV.Location = new System.Drawing.Point(656, 29);
            this.textBoxMaSV.Name = "textBoxMaSV";
            this.textBoxMaSV.ReadOnly = true;
            this.textBoxMaSV.Size = new System.Drawing.Size(174, 25);
            this.textBoxMaSV.TabIndex = 2;
            // 
            // textBoxTenSV
            // 
            this.textBoxTenSV.Location = new System.Drawing.Point(656, 77);
            this.textBoxTenSV.Name = "textBoxTenSV";
            this.textBoxTenSV.ReadOnly = true;
            this.textBoxTenSV.Size = new System.Drawing.Size(174, 25);
            this.textBoxTenSV.TabIndex = 2;
            // 
            // dataGridViewMuonSach
            // 
            this.dataGridViewMuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMuonSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewMuonSach.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuonSach.Location = new System.Drawing.Point(11, 146);
            this.dataGridViewMuonSach.Name = "dataGridViewMuonSach";
            this.dataGridViewMuonSach.RowHeadersWidth = 51;
            this.dataGridViewMuonSach.RowTemplate.Height = 24;
            this.dataGridViewMuonSach.Size = new System.Drawing.Size(707, 389);
            this.dataGridViewMuonSach.TabIndex = 3;
            // 
            // dataGridViewTraSach
            // 
            this.dataGridViewTraSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTraSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewTraSach.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTraSach.Location = new System.Drawing.Point(760, 146);
            this.dataGridViewTraSach.Name = "dataGridViewTraSach";
            this.dataGridViewTraSach.RowHeadersWidth = 51;
            this.dataGridViewTraSach.RowTemplate.Height = 24;
            this.dataGridViewTraSach.Size = new System.Drawing.Size(710, 389);
            this.dataGridViewTraSach.TabIndex = 3;
            // 
            // buttonDong
            // 
            this.buttonDong.Image = global::_2.Properties.Resources.Stop1;
            this.buttonDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDong.Location = new System.Drawing.Point(690, 542);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(106, 41);
            this.buttonDong.TabIndex = 4;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDong.UseVisualStyleBackColor = true;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // LichSuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1482, 587);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.dataGridViewTraSach);
            this.Controls.Add(this.dataGridViewMuonSach);
            this.Controls.Add(this.textBoxTenSV);
            this.Controls.Add(this.textBoxMaSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LichSuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LichSuForm";
            this.Load += new System.EventHandler(this.LichSuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridViewMuonSach;
        public System.Windows.Forms.DataGridView dataGridViewTraSach;
        public System.Windows.Forms.Button buttonDong;
        public System.Windows.Forms.TextBox textBoxMaSV;
        public System.Windows.Forms.TextBox textBoxTenSV;
    }
}