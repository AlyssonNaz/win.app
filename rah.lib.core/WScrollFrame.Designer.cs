namespace rah.lib.core
{
    partial class WScrollFrame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panTop = new System.Windows.Forms.Panel();
            this.panBottom = new System.Windows.Forms.Panel();
            this.panLeft = new System.Windows.Forms.Panel();
            this.panRight = new System.Windows.Forms.Panel();
            this.panFill = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "[Titulo]";
            // 
            // panTop
            // 
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 32);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(434, 8);
            this.panTop.TabIndex = 1;
            this.panTop.Visible = false;
            // 
            // panBottom
            // 
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 276);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(434, 6);
            this.panBottom.TabIndex = 2;
            this.panBottom.Visible = false;
            // 
            // panLeft
            // 
            this.panLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLeft.Location = new System.Drawing.Point(0, 40);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(6, 236);
            this.panLeft.TabIndex = 3;
            this.panLeft.Visible = false;
            // 
            // panRight
            // 
            this.panRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panRight.Location = new System.Drawing.Point(428, 40);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(6, 236);
            this.panRight.TabIndex = 4;
            this.panRight.Visible = false;
            // 
            // panFill
            // 
            this.panFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFill.Location = new System.Drawing.Point(6, 40);
            this.panFill.Name = "panFill";
            this.panFill.Size = new System.Drawing.Size(422, 236);
            this.panFill.TabIndex = 5;
            // 
            // WScrollFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.panFill);
            this.Controls.Add(this.panRight);
            this.Controls.Add(this.panLeft);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panel1);
            this.Name = "WScrollFrame";
            this.Size = new System.Drawing.Size(434, 282);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.Panel panLeft;
        private System.Windows.Forms.Panel panRight;
        private System.Windows.Forms.Panel panFill;
    }
}
