namespace De3
{
    partial class Form3
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
            this.btnThem = new System.Windows.Forms.Button();
            this.ntmXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.cmbDaiTu = new System.Windows.Forms.ComboBox();
            this.txtHoDem = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDS = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(58, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ntmXoa
            // 
            this.ntmXoa.Location = new System.Drawing.Point(139, 22);
            this.ntmXoa.Name = "ntmXoa";
            this.ntmXoa.Size = new System.Drawing.Size(75, 23);
            this.ntmXoa.TabIndex = 0;
            this.ntmXoa.Text = "Xóa";
            this.ntmXoa.UseVisualStyleBackColor = true;
            this.ntmXoa.Click += new System.EventHandler(this.ntmXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(220, 22);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cmbDaiTu
            // 
            this.cmbDaiTu.FormattingEnabled = true;
            this.cmbDaiTu.Items.AddRange(new object[] {
            "Ông",
            "Bà",
            "Cô",
            "Anh"});
            this.cmbDaiTu.Location = new System.Drawing.Point(12, 84);
            this.cmbDaiTu.Name = "cmbDaiTu";
            this.cmbDaiTu.Size = new System.Drawing.Size(121, 21);
            this.cmbDaiTu.TabIndex = 1;
            // 
            // txtHoDem
            // 
            this.txtHoDem.Location = new System.Drawing.Point(139, 85);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.Size = new System.Drawing.Size(100, 20);
            this.txtHoDem.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(245, 85);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ đệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên";
            // 
            // lstDS
            // 
            this.lstDS.FormattingEnabled = true;
            this.lstDS.Location = new System.Drawing.Point(12, 129);
            this.lstDS.Name = "lstDS";
            this.lstDS.Size = new System.Drawing.Size(333, 95);
            this.lstDS.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 249);
            this.Controls.Add(this.lstDS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoDem);
            this.Controls.Add(this.cmbDaiTu);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.ntmXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button ntmXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cmbDaiTu;
        private System.Windows.Forms.TextBox txtHoDem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDS;
    }
}