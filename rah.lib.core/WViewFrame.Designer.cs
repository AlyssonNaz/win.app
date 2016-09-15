namespace rah.lib.core
{
    partial class WViewFrame
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
            this.panClient = new System.Windows.Forms.Panel();
            this.panLayoutClient = new System.Windows.Forms.TableLayoutPanel();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panClient.SuspendLayout();
            this.panLayoutClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panClient
            // 
            this.panClient.Controls.Add(this.panLayoutClient);
            this.panClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panClient.Location = new System.Drawing.Point(0, 0);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(771, 525);
            this.panClient.TabIndex = 1;
            // 
            // panLayoutClient
            // 
            this.panLayoutClient.ColumnCount = 2;
            this.panLayoutClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panLayoutClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.panLayoutClient.Controls.Add(this.navBarControl1, 1, 0);
            this.panLayoutClient.Controls.Add(this.gridControl1, 0, 0);
            this.panLayoutClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLayoutClient.Location = new System.Drawing.Point(0, 0);
            this.panLayoutClient.Name = "panLayoutClient";
            this.panLayoutClient.RowCount = 1;
            this.panLayoutClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panLayoutClient.Size = new System.Drawing.Size(771, 525);
            this.panLayoutClient.TabIndex = 1;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(604, 3);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 164;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.SideBar;
            this.navBarControl1.Size = new System.Drawing.Size(164, 519);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Processos";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(595, 519);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.InvertSelection = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // WViewFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.panClient);
            this.Name = "WViewFrame";
            this.Size = new System.Drawing.Size(771, 525);
            this.panClient.ResumeLayout(false);
            this.panLayoutClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panClient;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        protected DevExpress.XtraNavBar.NavBarControl navBarControl1;
        protected DevExpress.XtraGrid.GridControl gridControl1;
        protected System.Windows.Forms.TableLayoutPanel panLayoutClient;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
