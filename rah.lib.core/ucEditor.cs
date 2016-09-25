using System.Drawing;

namespace rah.lib.core
{
    public partial class ucEditor : WFrame
    {        
        public ucEditor()
        {
            InitializeComponent();            
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

        public void CreateIntEditor()
        {            
            lpContainer.Controls.Add(buttonEdit, 1, 0);
        }

        public void CreateStringEditor()
        {
            buttonEdit.Properties.Buttons.Clear();
            lpContainer.Controls.Add(buttonEdit, 1, 0);
        }

        public void CreateDateTimeEditor()
        {           
            
        }

        public void CreateFloatEditor()
        {            
        }

        public void CreateMemoEditor()
        {            
        }

        public void SetRequired(bool required)
        {
            if (required)
            {
                buttonEdit.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
            }
        }

        public void SetReadOnly(bool readOnly)
        {
            buttonEdit.ReadOnly = readOnly;
        }
    }
}
