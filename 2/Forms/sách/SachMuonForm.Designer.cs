
namespace _2
{
    partial class SachMuonForm
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
            this.sACHMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teDataSet1 = new _2.teDataSet1();
            this.sACHMUONTableAdapter = new _2.teDataSet1TableAdapters.SACHMUONTableAdapter();
            this.dataGridViewSachMuon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sACHMUONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // sACHMUONBindingSource
            // 
            this.sACHMUONBindingSource.DataMember = "SACHMUON";
            this.sACHMUONBindingSource.DataSource = this.teDataSet1;
            // 
            // teDataSet1
            // 
            this.teDataSet1.DataSetName = "teDataSet1";
            this.teDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHMUONTableAdapter
            // 
            this.sACHMUONTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewSachMuon
            // 
            this.dataGridViewSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSachMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewSachMuon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSachMuon.Location = new System.Drawing.Point(2, 1);
            this.dataGridViewSachMuon.Name = "dataGridViewSachMuon";
            this.dataGridViewSachMuon.RowHeadersWidth = 51;
            this.dataGridViewSachMuon.RowTemplate.Height = 24;
            this.dataGridViewSachMuon.Size = new System.Drawing.Size(1154, 451);
            this.dataGridViewSachMuon.TabIndex = 0;
            // 
            // SachMuonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 453);
            this.Controls.Add(this.dataGridViewSachMuon);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "SachMuonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SachMuonForm";
            this.Load += new System.EventHandler(this.SachMuonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sACHMUONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSachMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private teDataSet1 teDataSet1;
        private System.Windows.Forms.BindingSource sACHMUONBindingSource;
        private teDataSet1TableAdapters.SACHMUONTableAdapter sACHMUONTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewSachMuon;
    }
}