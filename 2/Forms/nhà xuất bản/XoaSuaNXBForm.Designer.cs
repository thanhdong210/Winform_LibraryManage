
namespace _2
{
    partial class XoaSuaNXBForm
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
            this.dataGridViewNXB = new System.Windows.Forms.DataGridView();
            this.buttonRF = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaNXB = new System.Windows.Forms.TextBox();
            this.textBoxTenNXB = new System.Windows.Forms.TextBox();
            this.textBoxDiaChiNXB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNXB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNXB
            // 
            this.dataGridViewNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNXB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewNXB.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNXB.Location = new System.Drawing.Point(411, 12);
            this.dataGridViewNXB.Name = "dataGridViewNXB";
            this.dataGridViewNXB.RowHeadersWidth = 51;
            this.dataGridViewNXB.RowTemplate.Height = 24;
            this.dataGridViewNXB.Size = new System.Drawing.Size(577, 354);
            this.dataGridViewNXB.TabIndex = 0;
            this.dataGridViewNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.XoaSuaNXBForm_CellClick);
            // 
            // buttonRF
            // 
            this.buttonRF.Image = global::_2.Properties.Resources.Glyph_Check;
            this.buttonRF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRF.Location = new System.Drawing.Point(274, 328);
            this.buttonRF.Name = "buttonRF";
            this.buttonRF.Size = new System.Drawing.Size(130, 38);
            this.buttonRF.TabIndex = 1;
            this.buttonRF.Text = "Refresh";
            this.buttonRF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRF.UseVisualStyleBackColor = true;
            this.buttonRF.Click += new System.EventHandler(this.buttonRF_Click_1);
            // 
            // buttonSua
            // 
            this.buttonSua.Image = global::_2.Properties.Resources.Button_White_Add;
            this.buttonSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSua.Location = new System.Drawing.Point(38, 249);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(117, 36);
            this.buttonSua.TabIndex = 1;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Image = global::_2.Properties.Resources.Glyph_Remove;
            this.buttonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoa.Location = new System.Drawing.Point(215, 249);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(117, 36);
            this.buttonXoa.TabIndex = 1;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin nhà xuất bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã nhà xuất bản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên nhà xuất bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ nhà xuất bản:";
            // 
            // textBoxMaNXB
            // 
            this.textBoxMaNXB.Location = new System.Drawing.Point(201, 42);
            this.textBoxMaNXB.Name = "textBoxMaNXB";
            this.textBoxMaNXB.ReadOnly = true;
            this.textBoxMaNXB.Size = new System.Drawing.Size(130, 23);
            this.textBoxMaNXB.TabIndex = 4;
            // 
            // textBoxTenNXB
            // 
            this.textBoxTenNXB.Location = new System.Drawing.Point(201, 94);
            this.textBoxTenNXB.Name = "textBoxTenNXB";
            this.textBoxTenNXB.Size = new System.Drawing.Size(170, 23);
            this.textBoxTenNXB.TabIndex = 4;
            // 
            // textBoxDiaChiNXB
            // 
            this.textBoxDiaChiNXB.Location = new System.Drawing.Point(201, 145);
            this.textBoxDiaChiNXB.Multiline = true;
            this.textBoxDiaChiNXB.Name = "textBoxDiaChiNXB";
            this.textBoxDiaChiNXB.Size = new System.Drawing.Size(170, 87);
            this.textBoxDiaChiNXB.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.textBoxDiaChiNXB);
            this.panel1.Controls.Add(this.textBoxTenNXB);
            this.panel1.Controls.Add(this.textBoxMaNXB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonSua);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 311);
            this.panel1.TabIndex = 5;
            // 
            // XoaSuaNXBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(992, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRF);
            this.Controls.Add(this.dataGridViewNXB);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "XoaSuaNXBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XoaSuaNXBForm";
            this.Load += new System.EventHandler(this.XoaSuaNXBForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNXB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNXB;
        private System.Windows.Forms.Button buttonRF;
        public System.Windows.Forms.Button buttonSua;
        public System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxMaNXB;
        public System.Windows.Forms.TextBox textBoxTenNXB;
        public System.Windows.Forms.TextBox textBoxDiaChiNXB;
        private System.Windows.Forms.Panel panel1;
    }
}