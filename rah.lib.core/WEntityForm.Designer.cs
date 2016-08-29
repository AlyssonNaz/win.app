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
            this.panClient = new System.Windows.Forms.Panel();
            this.panNavBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(687, 53);
            this.panTop.TabIndex = 0;
            // 
            // panClient
            // 
            this.panClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panClient.Location = new System.Drawing.Point(0, 53);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(687, 419);
            this.panClient.TabIndex = 2;
            // 
            // panNavBar
            // 
            this.panNavBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panNavBar.Location = new System.Drawing.Point(532, 53);
            this.panNavBar.Name = "panNavBar";
            this.panNavBar.Size = new System.Drawing.Size(155, 419);
            this.panNavBar.TabIndex = 3;
            // 
            // WEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(687, 472);
            this.Controls.Add(this.panNavBar);
            this.Controls.Add(this.panClient);
            this.Controls.Add(this.panTop);
            this.Name = "WEntityForm";
            this.Text = "WEntityForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panClient;
        private System.Windows.Forms.Panel panNavBar;
    }
}
