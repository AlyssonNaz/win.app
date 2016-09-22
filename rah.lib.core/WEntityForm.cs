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
        private string metaData;
        private string model;
        private object primaryKey;

        public WEntityForm()
        {
            InitializeComponent();            
        }

        public WEntityForm(string metaData, string model, object primaryKey)
        {
            this.metaData = metaData;
            this.model = model;
            this.primaryKey = primaryKey;
            if (primaryKey != null)
            {
                LoadObj();
            }          
        }

        private void LoadObj()
        {
            var obj = new ConnectionHandler().GetResponse($"api/model/{model}/{primaryKey}");
        }
    }
}
