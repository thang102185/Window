﻿namespace ThongKeTu
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốNguyênTốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêTừToolStripMenuItem,
            this.sốNguyênTốToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêTừToolStripMenuItem
            // 
            this.thốngKêTừToolStripMenuItem.Name = "thốngKêTừToolStripMenuItem";
            this.thốngKêTừToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.thốngKêTừToolStripMenuItem.Text = "Thống kê từ";
            this.thốngKêTừToolStripMenuItem.Click += new System.EventHandler(this.thốngKêTừToolStripMenuItem_Click);
            // 
            // sốNguyênTốToolStripMenuItem
            // 
            this.sốNguyênTốToolStripMenuItem.Name = "sốNguyênTốToolStripMenuItem";
            this.sốNguyênTốToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.sốNguyênTốToolStripMenuItem.Text = "Số nguyên tố";
            this.sốNguyênTốToolStripMenuItem.Click += new System.EventHandler(this.sốNguyênTốToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTừToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốNguyênTốToolStripMenuItem;
    }
}