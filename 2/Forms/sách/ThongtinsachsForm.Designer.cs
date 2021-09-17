
namespace _2
{
    partial class ThongtinsachsForm
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
            this.contextMenuStripChinhSuaThongTinSach = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chỉnhSửaThôngTinSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTSACHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tTSACHBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tTSACHBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tTSACHBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.masachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentacgiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namxbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manxbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTSACHBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tTSACHBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.teDataSet = new _2.teDataSet();
            this.tTSACHTableAdapter = new _2.teDataSetTableAdapters.TTSACHTableAdapter();
            this.dataGridViewSach = new System.Windows.Forms.DataGridView();
            this.contextMenuStripChinhSuaThongTinSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripChinhSuaThongTinSach
            // 
            this.contextMenuStripChinhSuaThongTinSach.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripChinhSuaThongTinSach.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaThôngTinSáchToolStripMenuItem});
            this.contextMenuStripChinhSuaThongTinSach.Name = "contextMenuStripChinhSuaThongTinSach";
            this.contextMenuStripChinhSuaThongTinSach.Size = new System.Drawing.Size(240, 28);
            // 
            // chỉnhSửaThôngTinSáchToolStripMenuItem
            // 
            this.chỉnhSửaThôngTinSáchToolStripMenuItem.Name = "chỉnhSửaThôngTinSáchToolStripMenuItem";
            this.chỉnhSửaThôngTinSáchToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.chỉnhSửaThôngTinSáchToolStripMenuItem.Text = "Chỉnh sửa thông tin sách";
            this.chỉnhSửaThôngTinSáchToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaThôngTinSáchToolStripMenuItem_Click);
            // 
            // tTSACHBindingSource
            // 
            this.tTSACHBindingSource.DataMember = "TTSACH";
            // 
            // button1
            // 
            this.button1.Image = global::_2.Properties.Resources.Glyph_Check;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(460, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lOGINBindingSource
            // 
            this.lOGINBindingSource.DataMember = "LOGIN";
            // 
            // tTSACHBindingSource1
            // 
            this.tTSACHBindingSource1.DataMember = "TTSACH";
            // 
            // tTSACHBindingSource4
            // 
            this.tTSACHBindingSource4.DataMember = "TTSACH";
            // 
            // masachDataGridViewTextBoxColumn
            // 
            this.masachDataGridViewTextBoxColumn.DataPropertyName = "Masach";
            this.masachDataGridViewTextBoxColumn.HeaderText = "Masach";
            this.masachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masachDataGridViewTextBoxColumn.Name = "masachDataGridViewTextBoxColumn";
            this.masachDataGridViewTextBoxColumn.Width = 125;
            // 
            // tensachDataGridViewTextBoxColumn
            // 
            this.tensachDataGridViewTextBoxColumn.DataPropertyName = "Tensach";
            this.tensachDataGridViewTextBoxColumn.HeaderText = "Tensach";
            this.tensachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tensachDataGridViewTextBoxColumn.Name = "tensachDataGridViewTextBoxColumn";
            this.tensachDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaisachDataGridViewTextBoxColumn
            // 
            this.loaisachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaisachDataGridViewTextBoxColumn.DataPropertyName = "Loaisach";
            this.loaisachDataGridViewTextBoxColumn.HeaderText = "Loaisach";
            this.loaisachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaisachDataGridViewTextBoxColumn.Name = "loaisachDataGridViewTextBoxColumn";
            // 
            // tentacgiaDataGridViewTextBoxColumn
            // 
            this.tentacgiaDataGridViewTextBoxColumn.DataPropertyName = "Tentacgia";
            this.tentacgiaDataGridViewTextBoxColumn.HeaderText = "Tentacgia";
            this.tentacgiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tentacgiaDataGridViewTextBoxColumn.Name = "tentacgiaDataGridViewTextBoxColumn";
            this.tentacgiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // namxbDataGridViewTextBoxColumn
            // 
            this.namxbDataGridViewTextBoxColumn.DataPropertyName = "Namxb";
            this.namxbDataGridViewTextBoxColumn.HeaderText = "Namxb";
            this.namxbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namxbDataGridViewTextBoxColumn.Name = "namxbDataGridViewTextBoxColumn";
            this.namxbDataGridViewTextBoxColumn.Width = 125;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "Soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Soluong";
            this.soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.Width = 125;
            // 
            // manxbDataGridViewTextBoxColumn
            // 
            this.manxbDataGridViewTextBoxColumn.DataPropertyName = "Manxb";
            this.manxbDataGridViewTextBoxColumn.HeaderText = "Manxb";
            this.manxbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manxbDataGridViewTextBoxColumn.Name = "manxbDataGridViewTextBoxColumn";
            this.manxbDataGridViewTextBoxColumn.Width = 125;
            // 
            // tTSACHBindingSource5
            // 
            this.tTSACHBindingSource5.DataMember = "TTSACH";
            // 
            // tTSACHBindingSource6
            // 
            this.tTSACHBindingSource6.DataMember = "TTSACH";
            this.tTSACHBindingSource6.DataSource = this.teDataSet;
            // 
            // teDataSet
            // 
            this.teDataSet.DataSetName = "teDataSet";
            this.teDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTSACHTableAdapter
            // 
            this.tTSACHTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewSach
            // 
            this.dataGridViewSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewSach.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSach.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.RowHeadersWidth = 51;
            this.dataGridViewSach.RowTemplate.Height = 24;
            this.dataGridViewSach.Size = new System.Drawing.Size(1070, 465);
            this.dataGridViewSach.TabIndex = 3;
            // 
            // ThongtinsachsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1071, 520);
            this.Controls.Add(this.dataGridViewSach);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ThongtinsachsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "thongtinsachsForm";
            this.Load += new System.EventHandler(this.ThongtinsachsForm_Load);
            this.contextMenuStripChinhSuaThongTinSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTSACHBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripChinhSuaThongTinSach;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaThôngTinSáchToolStripMenuItem;
       
        private System.Windows.Forms.BindingSource tTSACHBindingSource;
       
       
        private System.Windows.Forms.BindingSource lOGINBindingSource;
       
        private System.Windows.Forms.BindingSource tTSACHBindingSource1;
       
        private System.Windows.Forms.BindingSource tTSACHBindingSource2;
        
        private System.Windows.Forms.BindingSource tTSACHBindingSource3;
       
        private System.Windows.Forms.BindingSource tTSACHBindingSource4;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn masachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentacgiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namxbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manxbDataGridViewTextBoxColumn;
        
        private System.Windows.Forms.BindingSource tTSACHBindingSource5;
        private teDataSet teDataSet;
        private System.Windows.Forms.BindingSource tTSACHBindingSource6;
        private teDataSetTableAdapters.TTSACHTableAdapter tTSACHTableAdapter;
        public System.Windows.Forms.DataGridView dataGridViewSach;
    }
}