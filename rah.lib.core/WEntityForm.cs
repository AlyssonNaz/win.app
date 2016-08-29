using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rah.lib.core
{
    public partial class WEntityForm : WChildForm
    {
        private MetaData metadata;

        public WEntityForm(MetaData metadata)
        {
            InitializeComponent();
            this.metadata = metadata;
            Load();
        }

        private void Load()
        {
        }
    }
}
