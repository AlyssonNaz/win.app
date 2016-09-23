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
            this.nbiAdd = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDelete = new DevExpress.XtraNavBar.NavBarItem();
            this.panLayoutClient = new System.Windows.Forms.TableLayoutPanel();
            this.nbcProcess = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgProcess = new DevExpress.XtraNavBar.NavBarGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.panClient = new System.Windows.Forms.Panel();
            this.panLayoutClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbcProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // nbiAdd
            // 
            this.nbiAdd.Caption = "Adicionar";
            this.nbiAdd.Name = "nbiAdd";
            this.nbiAdd.SmallImage = global::rah.lib.core.Properties.Resources.Files_New_File_icon;
            this.nbiAdd.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiAdd_LinkClicked);
            // 
            // nbiDelete
            // 
            this.nbiDelete.Caption = "Excluir";
            this.nbiDelete.Hint = "Este processo irá excluir o registro selecionado.";
            this.nbiDelete.Name = "nbiDelete";
            this.nbiDelete.SmallImage = global::rah.lib.core.Properties.Resources.delete_file_icon;
            // 
            // panLayoutClient
            // 
            this.panLayoutClient.ColumnCount = 2;
            this.panLayoutClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panLayoutClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.panLayoutClient.Controls.Add(this.nbcProcess, 1, 0);
            this.panLayoutClient.Controls.Add(this.gridControl1, 0, 0);
            this.panLayoutClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLayoutClient.Location = new System.Drawing.Point(0, 0);
            this.panLayoutClient.Name = "panLayoutClient";
            this.panLayoutClient.RowCount = 1;
            this.panLayoutClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panLayoutClient.Size = new System.Drawing.Size(771, 525);
            this.panLayoutClient.TabIndex = 1;
            // 
            // nbcProcess
            // 
            this.nbcProcess.ActiveGroup = this.nbgProcess;
            this.nbcProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbcProcess.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgProcess});
            this.nbcProcess.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiAdd,
            this.nbiDelete});
            this.nbcProcess.Location = new System.Drawing.Point(604, 3);
            this.nbcProcess.Name = "nbcProcess";
            this.nbcProcess.OptionsNavPane.ExpandedWidth = 164;
            this.nbcProcess.OptionsNavPane.ShowExpandButton = false;
            this.nbcProcess.OptionsNavPane.ShowGroupImageInHeader = true;
            this.nbcProcess.OptionsNavPane.ShowOverflowButton = false;
            this.nbcProcess.OptionsNavPane.ShowOverflowPanel = false;
            this.nbcProcess.OptionsNavPane.ShowSplitter = false;
            this.nbcProcess.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.SideBar;
            this.nbcProcess.Size = new System.Drawing.Size(164, 519);
            this.nbcProcess.TabIndex = 0;
            this.nbcProcess.Text = "Processos";
            this.nbcProcess.View = new DevExpress.XtraNavBar.ViewInfo.NavigationPaneViewInfoRegistrator();
            // 
            // nbgProcess
            // 
            this.nbgProcess.Caption = "Processos";
            this.nbgProcess.Expanded = true;
            this.nbgProcess.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAdd),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDelete)});
            this.nbgProcess.LargeImage = global::rah.lib.core.Properties.Resources.application_process;
            this.nbgProcess.Name = "nbgProcess";
            this.nbgProcess.SmallImage = global::rah.lib.core.Properties.Resources.application_process;
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Processos";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAdd),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDelete)});
            this.navBarGroup1.Name = "navBarGroup1";
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
            // WViewFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.panClient);
            this.Name = "WViewFrame";
            this.Size = new System.Drawing.Size(771, 525);
            this.panLayoutClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbcProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarItem nbiAdd;
        private DevExpress.XtraNavBar.NavBarItem nbiDelete;
        protected System.Windows.Forms.TableLayoutPanel panLayoutClient;
        protected DevExpress.XtraNavBar.NavBarControl nbcProcess;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        protected DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panClient;
        private DevExpress.XtraNavBar.NavBarGroup nbgProcess;
    }
}
