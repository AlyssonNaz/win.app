using System.Drawing;

namespace rah.lib.core
{
    public partial class ucEditorInt : WFrame, IButtonEditor
    {
        public ucEditorInt()
        {
            InitializeComponent();
            lpContainer.ColumnStyles[0].SizeType = System.Windows.Forms.SizeType.Absolute;
            lpContainer.ColumnStyles[0].Width = 100;
        }

        public string Caption
        {
            get { return lbEditor.Text; }
            set { lbEditor.Text = value; }
        }

        public object Value
        {
            get { return buttonEdit.EditValue; }
            set { buttonEdit.EditValue = value; }
        }

        public void SetRequired(bool required)
        {
            if (required)
            {
                lbEditor.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
            }
        }

        public void SetReadOnly(bool readOnly)
        {
            buttonEdit.ReadOnly = readOnly;
            buttonEdit.TabStop = !readOnly;
        }
    }
}
