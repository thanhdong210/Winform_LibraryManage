
namespace _2
{
    partial class PhatForm
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
            this.dataGridViewPhat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDongPhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhat
            // 
            this.dataGridViewPhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhat.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhat.Location = new System.Drawing.Point(6, 43);
            this.dataGridViewPhat.Name = "dataGridViewPhat";
            this.dataGridViewPhat.RowHeadersWidth = 51;
            this.dataGridViewPhat.RowTemplate.Height = 24;
            this.dataGridViewPhat.Size = new System.Drawing.Size(724, 347);
            this.dataGridViewPhat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin phạt";
            // 
            // buttonDongPhat
            // 
            this.buttonDongPhat.Image = global::_2.Properties.Resources.Glyph_Check;
            this.buttonDongPhat.Location = new System.Drawing.Point(290, 396);
            this.buttonDongPhat.Name = "buttonDongPhat";
            this.buttonDongPhat.Size = new System.Drawing.Size(143, 42);
            this.buttonDongPhat.TabIndex = 2;
            this.buttonDongPhat.Text = "Đóng phạt";
            this.buttonDongPhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDongPhat.UseVisualStyleBackColor = true;
            this.buttonDongPhat.Click += new System.EventHandler(this.buttonTraTien_Click);
            // 
            // PhatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.buttonDongPhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPhat);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PhatForm";
            this.Text = "PhatForm";
            this.Load += new System.EventHandler(this.PhatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewPhat;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonDongPhat;
    }
}