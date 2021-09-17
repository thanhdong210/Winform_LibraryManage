
namespace _2
{
    partial class SachTraForm
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
            this.sACHTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teDataSet2 = new _2.teDataSet2();
            this.sACHTRATableAdapter = new _2.teDataSet2TableAdapters.SACHTRATableAdapter();
            this.dataGridViewSachTra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sACHTRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSachTra)).BeginInit();
            this.SuspendLayout();
            // 
            // sACHTRABindingSource
            // 
            this.sACHTRABindingSource.DataMember = "SACHTRA";
            this.sACHTRABindingSource.DataSource = this.teDataSet2;
            // 
            // teDataSet2
            // 
            this.teDataSet2.DataSetName = "teDataSet2";
            this.teDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHTRATableAdapter
            // 
            this.sACHTRATableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewSachTra
            // 
            this.dataGridViewSachTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSachTra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewSachTra.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSachTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSachTra.Location = new System.Drawing.Point(3, 1);
            this.dataGridViewSachTra.Name = "dataGridViewSachTra";
            this.dataGridViewSachTra.RowHeadersWidth = 51;
            this.dataGridViewSachTra.RowTemplate.Height = 24;
            this.dataGridViewSachTra.Size = new System.Drawing.Size(1159, 450);
            this.dataGridViewSachTra.TabIndex = 0;
            // 
            // SachTraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 453);
            this.Controls.Add(this.dataGridViewSachTra);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "SachTraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SachTraForm";
            this.Load += new System.EventHandler(this.SachTraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sACHTRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSachTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private teDataSet2 teDataSet2;
        private System.Windows.Forms.BindingSource sACHTRABindingSource;
        private teDataSet2TableAdapters.SACHTRATableAdapter sACHTRATableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewSachTra;
    }
}