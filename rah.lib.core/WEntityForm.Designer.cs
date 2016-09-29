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
            this.panNavigation = new System.Windows.Forms.Panel();
            this.bbLast = new DevExpress.XtraEditors.SimpleButton();
            this.bbNext = new DevExpress.XtraEditors.SimpleButton();
            this.bbPrior = new DevExpress.XtraEditors.SimpleButton();
            this.bbFirst = new DevExpress.XtraEditors.SimpleButton();
            this.bbClose = new DevExpress.XtraEditors.SimpleButton();
            this.panTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTop = new System.Windows.Forms.Label();
            this.pcLayoutControl = new System.Windows.Forms.Panel();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panNavigation.SuspendLayout();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pcLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // panNavigation
            // 
            this.panNavigation.Controls.Add(this.bbLast);
            this.panNavigation.Controls.Add(this.bbNext);
            this.panNavigation.Controls.Add(this.bbPrior);
            this.panNavigation.Controls.Add(this.bbFirst);
            this.panNavigation.Controls.Add(this.bbClose);
            this.panNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panNavigation.Location = new System.Drawing.Point(0, 34);
            this.panNavigation.Name = "panNavigation";
            this.panNavigation.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.panNavigation.Size = new System.Drawing.Size(656, 48);
            this.panNavigation.TabIndex = 1;
            // 
            // bbLast
            // 
            this.bbLast.Dock = System.Windows.Forms.DockStyle.Left;
            this.bbLast.Image = global::rah.lib.core.Properties.Resources.Actions_go_last_view_icon;
            this.bbLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bbLast.Location = new System.Drawing.Point(181, 1);
            this.bbLast.Name = "bbLast";
            this.bbLast.Size = new System.Drawing.Size(60, 46);
            this.bbLast.TabIndex = 35;
            this.bbLast.TabStop = false;
            this.bbLast.Click += new System.EventHandler(this.bbLast_Click);
            // 
            // bbNext
            // 
            this.bbNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.bbNext.Image = global::rah.lib.core.Properties.Resources.Actions_go_next_icon;
            this.bbNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bbNext.Location = new System.Drawing.Point(121, 1);
            this.bbNext.Name = "bbNext";
            this.bbNext.Size = new System.Drawing.Size(60, 46);
            this.bbNext.TabIndex = 34;
            this.bbNext.TabStop = false;
            this.bbNext.Click += new System.EventHandler(this.bbNext_Click);
            // 
            // bbPrior
            // 
            this.bbPrior.Dock = System.Windows.Forms.DockStyle.Left;
            this.bbPrior.Image = global::rah.lib.core.Properties.Resources.Actions_go_previous_icon;
            this.bbPrior.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bbPrior.Location = new System.Drawing.Point(61, 1);
            this.bbPrior.Name = "bbPrior";
            this.bbPrior.Size = new System.Drawing.Size(60, 46);
            this.bbPrior.TabIndex = 33;
            this.bbPrior.TabStop = false;
            this.bbPrior.Click += new System.EventHandler(this.bbPrior_Click);
            // 
            // bbFirst
            // 
            this.bbFirst.Dock = System.Windows.Forms.DockStyle.Left;
            this.bbFirst.Image = global::rah.lib.core.Properties.Resources.resultset_first_icon;
            this.bbFirst.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bbFirst.Location = new System.Drawing.Point(1, 1);
            this.bbFirst.Name = "bbFirst";
            this.bbFirst.Size = new System.Drawing.Size(60, 46);
            this.bbFirst.TabIndex = 32;
            this.bbFirst.TabStop = false;
            this.bbFirst.Click += new System.EventHandler(this.bbFirst_Click);
            // 
            // bbClose
            // 
            this.bbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bbClose.Image = global::rah.lib.core.Properties.Resources.logout_icon;
            this.bbClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bbClose.Location = new System.Drawing.Point(596, 1);
            this.bbClose.Name = "bbClose";
            this.bbClose.Size = new System.Drawing.Size(60, 46);
            this.bbClose.TabIndex = 12;
            this.bbClose.TabStop = false;
            this.bbClose.Click += new System.EventHandler(this.bbClose_Click);
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panTop.Controls.Add(this.pictureBox1);
            this.panTop.Controls.Add(this.lbTop);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(656, 34);
            this.panTop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rah.lib.core.Properties.Resources.register_icon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbTop
            // 
            this.lbTop.AutoSize = true;
            this.lbTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTop.Location = new System.Drawing.Point(30, 8);
            this.lbTop.Name = "lbTop";
            this.lbTop.Size = new System.Drawing.Size(113, 16);
            this.lbTop.TabIndex = 0;
            this.lbTop.Text = "[Entity Caption]";
            // 
            // pcLayoutControl
            // 
            this.pcLayoutControl.Controls.Add(this.layoutControl);
            this.pcLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcLayoutControl.Location = new System.Drawing.Point(0, 82);
            this.pcLayoutControl.Name = "pcLayoutControl";
            this.pcLayoutControl.Size = new System.Drawing.Size(656, 384);
            this.pcLayoutControl.TabIndex = 3;
            // 
            // layoutControl
            // 
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(538, 98, 489, 350);
            this.layoutControl.Root = this.layoutControlGroup1;
            this.layoutControl.Size = new System.Drawing.Size(656, 384);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(656, 384);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // WEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(656, 466);
            this.Controls.Add(this.pcLayoutControl);
            this.Controls.Add(this.panNavigation);
            this.Controls.Add(this.panTop);
            this.Name = "WEntityForm";
            this.Text = "WEntityForm";
            this.panNavigation.ResumeLayout(false);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pcLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panNavigation;
        private DevExpress.XtraEditors.SimpleButton bbLast;
        private DevExpress.XtraEditors.SimpleButton bbNext;
        private DevExpress.XtraEditors.SimpleButton bbPrior;
        private DevExpress.XtraEditors.SimpleButton bbFirst;
        private DevExpress.XtraEditors.SimpleButton bbClose;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTop;
        private System.Windows.Forms.Panel pcLayoutControl;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    }
}
