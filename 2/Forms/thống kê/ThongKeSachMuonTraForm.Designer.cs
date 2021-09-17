
namespace _2
{
    partial class ThongKeSachTraForm
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
            this.panelSachDaTra = new System.Windows.Forms.Panel();
            this.labelSachDaTra = new System.Windows.Forms.Label();
            this.panelTotalSachMuon = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotalSachMuon = new System.Windows.Forms.Label();
            this.panelSachConLai = new System.Windows.Forms.Panel();
            this.labelSachConLai = new System.Windows.Forms.Label();
            this.panelSachDaTra.SuspendLayout();
            this.panelTotalSachMuon.SuspendLayout();
            this.panelSachConLai.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSachDaTra
            // 
            this.panelSachDaTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelSachDaTra.Controls.Add(this.labelSachDaTra);
            this.panelSachDaTra.Location = new System.Drawing.Point(3, 172);
            this.panelSachDaTra.Name = "panelSachDaTra";
            this.panelSachDaTra.Size = new System.Drawing.Size(298, 179);
            this.panelSachDaTra.TabIndex = 5;
            // 
            // labelSachDaTra
            // 
            this.labelSachDaTra.AutoSize = true;
            this.labelSachDaTra.Location = new System.Drawing.Point(63, 73);
            this.labelSachDaTra.Name = "labelSachDaTra";
            this.labelSachDaTra.Size = new System.Drawing.Size(102, 17);
            this.labelSachDaTra.TabIndex = 0;
            this.labelSachDaTra.Text = "Sách đã trả:";
            // 
            // panelTotalSachMuon
            // 
            this.panelTotalSachMuon.BackColor = System.Drawing.Color.Silver;
            this.panelTotalSachMuon.Controls.Add(this.panel3);
            this.panelTotalSachMuon.Controls.Add(this.labelTotalSachMuon);
            this.panelTotalSachMuon.Location = new System.Drawing.Point(4, 1);
            this.panelTotalSachMuon.Name = "panelTotalSachMuon";
            this.panelTotalSachMuon.Size = new System.Drawing.Size(592, 170);
            this.panelTotalSachMuon.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(294, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 185);
            this.panel3.TabIndex = 2;
            // 
            // labelTotalSachMuon
            // 
            this.labelTotalSachMuon.AutoSize = true;
            this.labelTotalSachMuon.Location = new System.Drawing.Point(180, 66);
            this.labelTotalSachMuon.Name = "labelTotalSachMuon";
            this.labelTotalSachMuon.Size = new System.Drawing.Size(191, 17);
            this.labelTotalSachMuon.TabIndex = 3;
            this.labelTotalSachMuon.Text = "Tổng số sách đã mượn:";
            // 
            // panelSachConLai
            // 
            this.panelSachConLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelSachConLai.Controls.Add(this.labelSachConLai);
            this.panelSachConLai.Location = new System.Drawing.Point(302, 172);
            this.panelSachConLai.Name = "panelSachConLai";
            this.panelSachConLai.Size = new System.Drawing.Size(295, 179);
            this.panelSachConLai.TabIndex = 6;
            // 
            // labelSachConLai
            // 
            this.labelSachConLai.AutoSize = true;
            this.labelSachConLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelSachConLai.Location = new System.Drawing.Point(89, 73);
            this.labelSachConLai.Name = "labelSachConLai";
            this.labelSachConLai.Size = new System.Drawing.Size(121, 17);
            this.labelSachConLai.TabIndex = 2;
            this.labelSachConLai.Text = "Sách chưa trả:";
            // 
            // ThongKeSachTraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 353);
            this.Controls.Add(this.panelSachDaTra);
            this.Controls.Add(this.panelTotalSachMuon);
            this.Controls.Add(this.panelSachConLai);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThongKeSachTraForm";
            this.Text = "ThongKeSachMuonTraForm";
            this.Load += new System.EventHandler(this.ThongKeFormSachTra_Load);
            this.panelSachDaTra.ResumeLayout(false);
            this.panelSachDaTra.PerformLayout();
            this.panelTotalSachMuon.ResumeLayout(false);
            this.panelTotalSachMuon.PerformLayout();
            this.panelSachConLai.ResumeLayout(false);
            this.panelSachConLai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelSachDaTra;
        public System.Windows.Forms.Label labelSachDaTra;
        public System.Windows.Forms.Panel panelTotalSachMuon;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label labelTotalSachMuon;
        public System.Windows.Forms.Panel panelSachConLai;
        public System.Windows.Forms.Label labelSachConLai;
    }
}