
namespace _2
{
    partial class TimKiemSachForm
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
            this.radioButtonMaSach = new System.Windows.Forms.RadioButton();
            this.radioButtonTenSach = new System.Windows.Forms.RadioButton();
            this.textBoxCheck = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.dataGridViewTimKiem = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonMaSach
            // 
            this.radioButtonMaSach.AutoSize = true;
            this.radioButtonMaSach.Location = new System.Drawing.Point(425, 14);
            this.radioButtonMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMaSach.Name = "radioButtonMaSach";
            this.radioButtonMaSach.Size = new System.Drawing.Size(91, 21);
            this.radioButtonMaSach.TabIndex = 0;
            this.radioButtonMaSach.TabStop = true;
            this.radioButtonMaSach.Text = "Mã sách";
            this.radioButtonMaSach.UseVisualStyleBackColor = true;
            // 
            // radioButtonTenSach
            // 
            this.radioButtonTenSach.AutoSize = true;
            this.radioButtonTenSach.Location = new System.Drawing.Point(535, 14);
            this.radioButtonTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTenSach.Name = "radioButtonTenSach";
            this.radioButtonTenSach.Size = new System.Drawing.Size(98, 21);
            this.radioButtonTenSach.TabIndex = 1;
            this.radioButtonTenSach.TabStop = true;
            this.radioButtonTenSach.Text = "Tên sách";
            this.radioButtonTenSach.UseVisualStyleBackColor = true;
            // 
            // textBoxCheck
            // 
            this.textBoxCheck.Location = new System.Drawing.Point(378, 51);
            this.textBoxCheck.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCheck.Name = "textBoxCheck";
            this.textBoxCheck.Size = new System.Drawing.Size(289, 23);
            this.textBoxCheck.TabIndex = 2;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCheck.Image = global::_2.Properties.Resources.Box;
            this.buttonCheck.Location = new System.Drawing.Point(716, 39);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(150, 39);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // dataGridViewTimKiem
            // 
            this.dataGridViewTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimKiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewTimKiem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiem.Location = new System.Drawing.Point(14, 133);
            this.dataGridViewTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTimKiem.Name = "dataGridViewTimKiem";
            this.dataGridViewTimKiem.RowHeadersWidth = 51;
            this.dataGridViewTimKiem.RowTemplate.Height = 24;
            this.dataGridViewTimKiem.Size = new System.Drawing.Size(1156, 409);
            this.dataGridViewTimKiem.TabIndex = 4;
            this.dataGridViewTimKiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.radioButtonMaSach);
            this.panel1.Controls.Add(this.radioButtonTenSach);
            this.panel1.Controls.Add(this.textBoxCheck);
            this.panel1.Location = new System.Drawing.Point(50, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 90);
            this.panel1.TabIndex = 5;
            // 
            // TimKiemSachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1189, 549);
            this.Controls.Add(this.dataGridViewTimKiem);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TimKiemSachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimKiemSachForm";
            this.Load += new System.EventHandler(this.TimKiemSachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonMaSach;
        private System.Windows.Forms.RadioButton radioButtonTenSach;
        private System.Windows.Forms.TextBox textBoxCheck;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.DataGridView dataGridViewTimKiem;
        private System.Windows.Forms.Panel panel1;
    }
}