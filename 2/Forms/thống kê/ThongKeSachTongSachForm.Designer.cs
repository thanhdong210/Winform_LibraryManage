
namespace _2
{
    partial class ThongKeSachMuonForm
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
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotalSach = new System.Windows.Forms.Label();
            this.panelSachMuon = new System.Windows.Forms.Panel();
            this.labelSachMuon = new System.Windows.Forms.Label();
            this.labelSachConLai = new System.Windows.Forms.Label();
            this.panelSachTra = new System.Windows.Forms.Panel();
            this.panelTotal.SuspendLayout();
            this.panelSachMuon.SuspendLayout();
            this.panelSachTra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.Silver;
            this.panelTotal.Controls.Add(this.labelTotalSach);
            this.panelTotal.Location = new System.Drawing.Point(3, 1);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(652, 166);
            this.panelTotal.TabIndex = 0;
            // 
            // labelTotalSach
            // 
            this.labelTotalSach.AutoSize = true;
            this.labelTotalSach.Location = new System.Drawing.Point(191, 72);
            this.labelTotalSach.Name = "labelTotalSach";
            this.labelTotalSach.Size = new System.Drawing.Size(277, 17);
            this.labelTotalSach.TabIndex = 3;
            this.labelTotalSach.Text = "Tổng số cuốn sách trong thư viện:";
            // 
            // panelSachMuon
            // 
            this.panelSachMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelSachMuon.Controls.Add(this.labelSachMuon);
            this.panelSachMuon.Location = new System.Drawing.Point(2, 164);
            this.panelSachMuon.Name = "panelSachMuon";
            this.panelSachMuon.Size = new System.Drawing.Size(329, 187);
            this.panelSachMuon.TabIndex = 1;
            // 
            // labelSachMuon
            // 
            this.labelSachMuon.AutoSize = true;
            this.labelSachMuon.Location = new System.Drawing.Point(-2, 73);
            this.labelSachMuon.Name = "labelSachMuon";
            this.labelSachMuon.Size = new System.Drawing.Size(305, 17);
            this.labelSachMuon.TabIndex = 0;
            this.labelSachMuon.Text = "Số lượng cuốn sách đang được mượn:";
            // 
            // labelSachConLai
            // 
            this.labelSachConLai.AutoSize = true;
            this.labelSachConLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelSachConLai.Location = new System.Drawing.Point(9, 73);
            this.labelSachConLai.Name = "labelSachConLai";
            this.labelSachConLai.Size = new System.Drawing.Size(304, 17);
            this.labelSachConLai.TabIndex = 2;
            this.labelSachConLai.Text = "Số lượng cuốn sách chưa được mượn:";
            // 
            // panelSachTra
            // 
            this.panelSachTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelSachTra.Controls.Add(this.labelSachConLai);
            this.panelSachTra.Location = new System.Drawing.Point(330, 164);
            this.panelSachTra.Name = "panelSachTra";
            this.panelSachTra.Size = new System.Drawing.Size(325, 187);
            this.panelSachTra.TabIndex = 3;
            // 
            // ThongKeSachMuonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(656, 353);
            this.Controls.Add(this.panelSachTra);
            this.Controls.Add(this.panelSachMuon);
            this.Controls.Add(this.panelTotal);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThongKeSachMuonForm";
            this.Text = "ThongKeSach";
            this.Load += new System.EventHandler(this.ThongKeFormSachMuon_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelSachMuon.ResumeLayout(false);
            this.panelSachMuon.PerformLayout();
            this.panelSachTra.ResumeLayout(false);
            this.panelSachTra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panelTotal;
        public System.Windows.Forms.Label labelTotalSach;
        public System.Windows.Forms.Panel panelSachMuon;
        public System.Windows.Forms.Label labelSachMuon;
        public System.Windows.Forms.Label labelSachConLai;
        public System.Windows.Forms.Panel panelSachTra;
    }
}