namespace rah.lib.core
{
    partial class WEntityForm
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
            this.panTop = new System.Windows.Forms.Panel();
            this.lbTop = new System.Windows.Forms.Label();
            this.panClient = new System.Windows.Forms.Panel();
            this.panVertialGrid = new System.Windows.Forms.Panel();
            this.panTop.SuspendLayout();
            this.panClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.lbTop);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(483, 34);
            this.panTop.TabIndex = 0;
            // 
            // lbTop
            // 
            this.lbTop.AutoSize = true;
            this.lbTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTop.Location = new System.Drawing.Point(3, 8);
            this.lbTop.Name = "lbTop";
            this.lbTop.Size = new System.Drawing.Size(113, 16);
            this.lbTop.TabIndex = 0;
            this.lbTop.Text = "[Entity Caption]";
            // 
            // panClient
            // 
            this.panClient.Controls.Add(this.panVertialGrid);
            this.panClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panClient.Location = new System.Drawing.Point(0, 34);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(483, 252);
            this.panClient.TabIndex = 1;
            // 
            // panVertialGrid
            // 
            this.panVertialGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panVertialGrid.Location = new System.Drawing.Point(0, 0);
            this.panVertialGrid.Name = "panVertialGrid";
            this.panVertialGrid.Size = new System.Drawing.Size(483, 24);
            this.panVertialGrid.TabIndex = 0;
            // 
            // WEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(483, 286);
            this.Controls.Add(this.panClient);
            this.Controls.Add(this.panTop);
            this.Name = "WEntityForm";
            this.Text = "WEntityForm";
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label lbTop;
        private System.Windows.Forms.Panel panClient;
        private System.Windows.Forms.Panel panVertialGrid;
    }
}
