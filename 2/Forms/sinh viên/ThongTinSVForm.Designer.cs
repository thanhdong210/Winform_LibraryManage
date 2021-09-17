
namespace _2
{
    partial class ThongTinSVForm
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
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teDataSet4 = new _2.teDataSet4();
            this.sINHVIENTableAdapter = new _2.teDataSet4TableAdapters.SINHVIENTableAdapter();
            this.buttonRF = new System.Windows.Forms.Button();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lịchSửMượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lịchSửMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.teDataSet4;
            // 
            // teDataSet4
            // 
            this.teDataSet4.DataSetName = "teDataSet4";
            this.teDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRF
            // 
            this.buttonRF.Image = global::_2.Properties.Resources.Glyph_Check;
            this.buttonRF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRF.Location = new System.Drawing.Point(419, 481);
            this.buttonRF.Name = "buttonRF";
            this.buttonRF.Size = new System.Drawing.Size(151, 38);
            this.buttonRF.TabIndex = 1;
            this.buttonRF.Text = "Refresh";
            this.buttonRF.UseVisualStyleBackColor = true;
            this.buttonRF.Click += new System.EventHandler(this.buttonRF_Click);
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSinhVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(6, 5);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.RowHeadersWidth = 51;
            this.dataGridViewSinhVien.RowTemplate.Height = 24;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(961, 470);
            this.dataGridViewSinhVien.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchSửMượnTrảSáchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(222, 28);
            // 
            // lịchSửMượnTrảSáchToolStripMenuItem
            // 
            this.lịchSửMượnTrảSáchToolStripMenuItem.Name = "lịchSửMượnTrảSáchToolStripMenuItem";
            this.lịchSửMượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.lịchSửMượnTrảSáchToolStripMenuItem.Text = "Lịch sử mượn trả sách";
            this.lịchSửMượnTrảSáchToolStripMenuItem.Click += new System.EventHandler(this.lịchSửMượnTrảSáchToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchSửMượnTrảToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(186, 28);
            // 
            // lịchSửMượnTrảToolStripMenuItem
            // 
            this.lịchSửMượnTrảToolStripMenuItem.Name = "lịchSửMượnTrảToolStripMenuItem";
            this.lịchSửMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.lịchSửMượnTrảToolStripMenuItem.Text = "lịch sử mượn trả";
            // 
            // ThongTinSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(970, 520);
            this.Controls.Add(this.dataGridViewSinhVien);
            this.Controls.Add(this.buttonRF);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "ThongTinSVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinSVForm";
            this.Load += new System.EventHandler(this.ThongTinSVForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private teDataSet4 teDataSet4;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private teDataSet4TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        public System.Windows.Forms.Button buttonRF;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lịchSửMượnTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem lịchSửMượnTrảToolStripMenuItem;
    }
}