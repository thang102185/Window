namespace De4
{
    partial class Form1
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
            this.câu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.câu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.câu1ToolStripMenuItem,
            this.câu2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // câu1ToolStripMenuItem
            // 
            this.câu1ToolStripMenuItem.Name = "câu1ToolStripMenuItem";
            this.câu1ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.câu1ToolStripMenuItem.Text = "Câu 1";
            this.câu1ToolStripMenuItem.Click += new System.EventHandler(this.câu1ToolStripMenuItem_Click);
            // 
            // câu2ToolStripMenuItem
            // 
            this.câu2ToolStripMenuItem.Name = "câu2ToolStripMenuItem";
            this.câu2ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.câu2ToolStripMenuItem.Text = "Câu 2";
            this.câu2ToolStripMenuItem.Click += new System.EventHandler(this.câu2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem câu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem câu2ToolStripMenuItem;
    }
}

