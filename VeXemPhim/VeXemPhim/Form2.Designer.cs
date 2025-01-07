namespace VeXemPhim
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radThuong = new System.Windows.Forms.RadioButton();
            this.chkBongnuoc = new System.Windows.Forms.CheckBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radVip = new System.Windows.Forms.RadioButton();
            this.radSvip = new System.Windows.Forms.RadioButton();
            this.cmbPhim = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(136, 20);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 59);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID khách hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(136, 103);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại vé";
            // 
            // radThuong
            // 
            this.radThuong.AutoSize = true;
            this.radThuong.Location = new System.Drawing.Point(407, 64);
            this.radThuong.Name = "radThuong";
            this.radThuong.Size = new System.Drawing.Size(74, 17);
            this.radThuong.TabIndex = 9;
            this.radThuong.TabStop = true;
            this.radThuong.Text = "Vé thường";
            this.radThuong.UseVisualStyleBackColor = true;
            this.radThuong.CheckedChanged += new System.EventHandler(this.radThuong_CheckedChanged);
            // 
            // chkBongnuoc
            // 
            this.chkBongnuoc.AutoSize = true;
            this.chkBongnuoc.Location = new System.Drawing.Point(340, 107);
            this.chkBongnuoc.Name = "chkBongnuoc";
            this.chkBongnuoc.Size = new System.Drawing.Size(113, 17);
            this.chkBongnuoc.TabIndex = 10;
            this.chkBongnuoc.Text = "Combo bóng nước";
            this.chkBongnuoc.UseVisualStyleBackColor = true;
            this.chkBongnuoc.CheckedChanged += new System.EventHandler(this.chkBongnuoc_CheckedChanged);
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(228, 149);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(100, 20);
            this.txtTien.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng tiền";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radVip
            // 
            this.radVip.AutoSize = true;
            this.radVip.Location = new System.Drawing.Point(487, 64);
            this.radVip.Name = "radVip";
            this.radVip.Size = new System.Drawing.Size(55, 17);
            this.radVip.TabIndex = 14;
            this.radVip.TabStop = true;
            this.radVip.Text = "Vé vip";
            this.radVip.UseVisualStyleBackColor = true;
            this.radVip.CheckedChanged += new System.EventHandler(this.radVip_CheckedChanged);
            // 
            // radSvip
            // 
            this.radSvip.AutoSize = true;
            this.radSvip.Location = new System.Drawing.Point(548, 64);
            this.radSvip.Name = "radSvip";
            this.radSvip.Size = new System.Drawing.Size(62, 17);
            this.radSvip.TabIndex = 15;
            this.radSvip.TabStop = true;
            this.radSvip.Text = "Vé Svip";
            this.radSvip.UseVisualStyleBackColor = true;
            this.radSvip.CheckedChanged += new System.EventHandler(this.radSvip_CheckedChanged);
            // 
            // cmbPhim
            // 
            this.cmbPhim.FormattingEnabled = true;
            this.cmbPhim.Items.AddRange(new object[] {
            "Mai",
            "Sonic",
            "Panda"});
            this.cmbPhim.Location = new System.Drawing.Point(407, 19);
            this.cmbPhim.Name = "cmbPhim";
            this.cmbPhim.Size = new System.Drawing.Size(121, 21);
            this.cmbPhim.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 190);
            this.Controls.Add(this.cmbPhim);
            this.Controls.Add(this.radSvip);
            this.Controls.Add(this.radVip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkBongnuoc);
            this.Controls.Add(this.radThuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radThuong;
        private System.Windows.Forms.CheckBox chkBongnuoc;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radVip;
        private System.Windows.Forms.RadioButton radSvip;
        private System.Windows.Forms.ComboBox cmbPhim;
    }
}