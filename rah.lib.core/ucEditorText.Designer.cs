﻿namespace rah.lib.core
{
    partial class ucEditorText
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
            this.lbEditor = new System.Windows.Forms.Label();
            this.lpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEdit = new DevExpress.XtraEditors.MemoEdit();
            this.lpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEditor
            // 
            this.lbEditor.AutoSize = true;
            this.lbEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditor.Location = new System.Drawing.Point(3, 0);
            this.lbEditor.Name = "lbEditor";
            this.lbEditor.Size = new System.Drawing.Size(51, 20);
            this.lbEditor.TabIndex = 0;
            this.lbEditor.Text = "label1";
            // 
            // lpContainer
            // 
            this.lpContainer.ColumnCount = 2;
            this.lpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.lpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.94736F));
            this.lpContainer.Controls.Add(this.buttonEdit, 0, 0);
            this.lpContainer.Controls.Add(this.lbEditor, 0, 0);
            this.lpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lpContainer.Location = new System.Drawing.Point(0, 0);
            this.lpContainer.Name = "lpContainer";
            this.lpContainer.RowCount = 1;
            this.lpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lpContainer.Size = new System.Drawing.Size(403, 100);
            this.lpContainer.TabIndex = 1;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEdit.Location = new System.Drawing.Point(87, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(313, 94);
            this.buttonEdit.TabIndex = 2;
            // 
            // ucEditorText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.lpContainer);
            this.Name = "ucEditorText";
            this.Size = new System.Drawing.Size(403, 100);
            this.lpContainer.ResumeLayout(false);
            this.lpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEditor;
        private System.Windows.Forms.TableLayoutPanel lpContainer;
        private DevExpress.XtraEditors.MemoEdit buttonEdit;
    }
}