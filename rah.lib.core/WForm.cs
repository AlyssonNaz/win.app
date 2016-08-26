using System;
using System.Windows.Forms;

namespace rah.lib.core
{
    public partial class WForm : Form
    {
        public WForm()
        {
            InitializeComponent();
            KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    SendKeys.Send("{tab}");
                    e.Handled = true;
                }
            };
        }
    }
}
