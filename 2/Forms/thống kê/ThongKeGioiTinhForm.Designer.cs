
namespace _2
{
    partial class ThongKeGioiTinhForm
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
            this.panelNam = new System.Windows.Forms.Panel();
            this.labelNam = new System.Windows.Forms.Label();
            this.panelTotalDocGia = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotalSV = new System.Windows.Forms.Label();
            this.panelNu = new System.Windows.Forms.Panel();
            this.labelNu = new System.Windows.Forms.Label();
            this.panelNam.SuspendLayout();
            this.panelTotalDocGia.SuspendLayout();
            this.panelNu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNam
            // 
            this.panelNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelNam.Controls.Add(this.labelNam);
            this.panelNam.Location = new System.Drawing.Point(3, 172);
            this.panelNam.Name = "panelNam";
            this.panelNam.Size = new System.Drawing.Size(259, 179);
            this.panelNam.TabIndex = 5;
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Location = new System.Drawing.Point(56, 73);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(45, 17);
            this.labelNam.TabIndex = 0;
            this.labelNam.Text = "Nam:";
            // 
            // panelTotalDocGia
            // 
            this.panelTotalDocGia.BackColor = System.Drawing.Color.Silver;
            this.panelTotalDocGia.Controls.Add(this.panel3);
            this.panelTotalDocGia.Controls.Add(this.labelTotalSV);
            this.panelTotalDocGia.Location = new System.Drawing.Point(4, 1);
            this.panelTotalDocGia.Name = "panelTotalDocGia";
            this.panelTotalDocGia.Size = new System.Drawing.Size(526, 165);
            this.panelTotalDocGia.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(261, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 185);
            this.panel3.TabIndex = 2;
            // 
            // labelTotalSV
            // 
            this.labelTotalSV.AutoSize = true;
            this.labelTotalSV.Location = new System.Drawing.Point(189, 74);
            this.labelTotalSV.Name = "labelTotalSV";
            this.labelTotalSV.Size = new System.Drawing.Size(143, 17);
            this.labelTotalSV.TabIndex = 3;
            this.labelTotalSV.Text = "Tổng số Sinh Viên:";
            // 
            // panelNu
            // 
            this.panelNu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelNu.Controls.Add(this.labelNu);
            this.panelNu.Location = new System.Drawing.Point(268, 172);
            this.panelNu.Name = "panelNu";
            this.panelNu.Size = new System.Drawing.Size(262, 179);
            this.panelNu.TabIndex = 6;
            // 
            // labelNu
            // 
            this.labelNu.AutoSize = true;
            this.labelNu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelNu.Location = new System.Drawing.Point(79, 73);
            this.labelNu.Name = "labelNu";
            this.labelNu.Size = new System.Drawing.Size(34, 17);
            this.labelNu.TabIndex = 2;
            this.labelNu.Text = "Nữ:";
            // 
            // ThongKeGioiTinhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.panelNam);
            this.Controls.Add(this.panelTotalDocGia);
            this.Controls.Add(this.panelNu);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThongKeGioiTinhForm";
            this.Text = "ThongKeGioiTinhForm";
            this.Load += new System.EventHandler(this.ThongKeGioiTinhForm_Load);
            this.panelNam.ResumeLayout(false);
            this.panelNam.PerformLayout();
            this.panelTotalDocGia.ResumeLayout(false);
            this.panelTotalDocGia.PerformLayout();
            this.panelNu.ResumeLayout(false);
            this.panelNu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelNam;
        public System.Windows.Forms.Label labelNam;
        public System.Windows.Forms.Panel panelTotalDocGia;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label labelTotalSV;
        public System.Windows.Forms.Panel panelNu;
        public System.Windows.Forms.Label labelNu;
    }
}