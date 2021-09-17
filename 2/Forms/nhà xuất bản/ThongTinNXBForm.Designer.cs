
namespace _2
{
    partial class ThongTinNXBForm
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonRF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNXB
            // 
            this.dataGridViewNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNXB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewNXB.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNXB.Location = new System.Drawing.Point(0, 1);
            this.dataGridViewNXB.Name = "dataGridViewNXB";
            this.dataGridViewNXB.RowHeadersWidth = 51;
            this.dataGridViewNXB.RowTemplate.Height = 24;
            this.dataGridViewNXB.Size = new System.Drawing.Size(615, 336);
            this.dataGridViewNXB.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(603, 655);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(128, 36);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonRF
            // 
            this.buttonRF.Image = global::_2.Properties.Resources.Glyph_Check;
            this.buttonRF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRF.Location = new System.Drawing.Point(232, 343);
            this.buttonRF.Name = "buttonRF";
            this.buttonRF.Size = new System.Drawing.Size(142, 38);
            this.buttonRF.TabIndex = 2;
            this.buttonRF.Text = "Refresh";
            this.buttonRF.UseVisualStyleBackColor = true;
            this.buttonRF.Click += new System.EventHandler(this.buttonRF_Click);
            // 
            // ThongTinNXBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(613, 386);
            this.Controls.Add(this.buttonRF);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewNXB);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "ThongTinNXBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinNXBForm";
            this.Load += new System.EventHandler(this.ThongtinNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNXB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button buttonRefresh;
        public System.Windows.Forms.DataGridView dataGridViewNXB;
        private System.Windows.Forms.Button buttonRF;
    }
}