namespace rah.lib.core
{
    partial class ucEditor
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
            this.lpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lbEditor = new System.Windows.Forms.Label();
            this.buttonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.lpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lpContainer
            // 
            this.lpContainer.ColumnCount = 2;
            this.lpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.lpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.94736F));
            this.lpContainer.Controls.Add(this.lbEditor, 0, 0);
            this.lpContainer.Controls.Add(this.buttonEdit, 1, 0);
            this.lpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lpContainer.Location = new System.Drawing.Point(0, 0);
            this.lpContainer.Name = "lpContainer";
            this.lpContainer.RowCount = 1;
            this.lpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lpContainer.Size = new System.Drawing.Size(399, 24);
            this.lpContainer.TabIndex = 0;
            // 
            // lbEditor
            // 
            this.lbEditor.AutoSize = true;
            this.lbEditor.Location = new System.Drawing.Point(3, 0);
            this.lbEditor.Name = "lbEditor";
            this.lbEditor.Size = new System.Drawing.Size(35, 13);
            this.lbEditor.TabIndex = 0;
            this.lbEditor.Text = "label1";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEdit.Location = new System.Drawing.Point(87, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit.Size = new System.Drawing.Size(309, 20);
            this.buttonEdit.TabIndex = 1;
            // 
            // ucEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.lpContainer);
            this.Name = "ucEditor";
            this.Size = new System.Drawing.Size(399, 24);
            this.lpContainer.ResumeLayout(false);
            this.lpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lpContainer;
        private System.Windows.Forms.Label lbEditor;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit;
    }
}
