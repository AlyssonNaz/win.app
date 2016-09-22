using System;

namespace rah.lib.core
{
    public partial class WEntityForm : WChildForm, IWEntityForm
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
                LoadModel();
            }
            else
            {
                LoadEmptyModel();
            }          
        }

        private void CreateEntityFormFromMetaData()
        {
        }

        private void LoadModel()
        {
            CreateEntityFormFromMetaData();
            var obj = new ConnectionHandler().GetResponse($"api/model/{model}/{primaryKey}");
        }

        private void LoadEmptyModel()
        {
            CreateEntityFormFromMetaData();
        }
    }
}
