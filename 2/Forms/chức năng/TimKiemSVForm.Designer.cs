
namespace _2
{
    partial class TimKiemSVForm
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
            this.dataGridViewTimKiem = new System.Windows.Forms.DataGridView();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxCheck = new System.Windows.Forms.TextBox();
            this.radioButtonTenSach = new System.Windows.Forms.RadioButton();
            this.radioButtonMaSach = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTimKiem
            // 
            this.dataGridViewTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimKiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewTimKiem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiem.Location = new System.Drawing.Point(11, 138);
            this.dataGridViewTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTimKiem.Name = "dataGridViewTimKiem";
            this.dataGridViewTimKiem.RowHeadersWidth = 51;
            this.dataGridViewTimKiem.RowTemplate.Height = 24;
            this.dataGridViewTimKiem.Size = new System.Drawing.Size(989, 437);
            this.dataGridViewTimKiem.TabIndex = 9;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Image = global::_2.Properties.Resources.Box;
            this.buttonCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheck.Location = new System.Drawing.Point(592, 39);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(150, 36);
            this.buttonCheck.TabIndex = 8;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click_1);
            // 
            // textBoxCheck
            // 
            this.textBoxCheck.Location = new System.Drawing.Point(300, 52);
            this.textBoxCheck.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCheck.Name = "textBoxCheck";
            this.textBoxCheck.Size = new System.Drawing.Size(264, 23);
            this.textBoxCheck.TabIndex = 7;
            // 
            // radioButtonTenSach
            // 
            this.radioButtonTenSach.AutoSize = true;
            this.radioButtonTenSach.Location = new System.Drawing.Point(432, 12);
            this.radioButtonTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTenSach.Name = "radioButtonTenSach";
            this.radioButtonTenSach.Size = new System.Drawing.Size(132, 21);
            this.radioButtonTenSach.TabIndex = 6;
            this.radioButtonTenSach.TabStop = true;
            this.radioButtonTenSach.Text = "Tên sinh viên";
            this.radioButtonTenSach.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaSach
            // 
            this.radioButtonMaSach.AutoSize = true;
            this.radioButtonMaSach.Location = new System.Drawing.Point(300, 12);
            this.radioButtonMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMaSach.Name = "radioButtonMaSach";
            this.radioButtonMaSach.Size = new System.Drawing.Size(125, 21);
            this.radioButtonMaSach.TabIndex = 5;
            this.radioButtonMaSach.TabStop = true;
            this.radioButtonMaSach.Text = "Mã sinh viên";
            this.radioButtonMaSach.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.radioButtonMaSach);
            this.panel1.Controls.Add(this.radioButtonTenSach);
            this.panel1.Controls.Add(this.textBoxCheck);
            this.panel1.Location = new System.Drawing.Point(44, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 100);
            this.panel1.TabIndex = 10;
            // 
            // TimKiemSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1015, 604);
            this.Controls.Add(this.dataGridViewTimKiem);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TimKiemSVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimKiemSVForm";
            this.Load += new System.EventHandler(this.TimKiemSVForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTimKiem;
        private System.Windows.Forms.TextBox textBoxCheck;
        private System.Windows.Forms.RadioButton radioButtonTenSach;
        private System.Windows.Forms.RadioButton radioButtonMaSach;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button buttonCheck;
    }
}