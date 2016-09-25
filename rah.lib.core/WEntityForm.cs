using DevExpress.XtraVerticalGrid;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace rah.lib.core
{
    public partial class WEntityForm : WChildForm, IWEntityForm
    {
        private string metaData;
        private string model;
        private object primaryKey;
        private DataTable DataTable;
        private IList<MetaData> MetaDataList;
        private Dictionary<string, IButtonEditor> dicComp;

        public WEntityForm() { }

        public WEntityForm(string metaData, string model, object primaryKey)
        {
            InitializeComponent();
            DataTable = new DataTable();
            MetaDataList = new List<MetaData>();
            dicComp = new Dictionary<string, IButtonEditor>();
            panVertialGrid.Height = 0;
            this.metaData = metaData;
            this.model = model;
            this.primaryKey = primaryKey;
            LoadModel();
        }

        private void CreateEntityFormFromMetaData(string obj = "")
        {
            var Data = JsonConvert.DeserializeObject<dynamic>(metaData);
            buildMetaData(Data.metadata);            
            if (obj != "")
            {
                var results = JsonConvert.DeserializeObject<dynamic>(obj);
                foreach (var result in results)
                {
                    if (dicComp.ContainsKey(result.Name))
                    {
                        IButtonEditor ucEditor = null;
                        dicComp.TryGetValue(result.Name, out ucEditor);                       
                        ucEditor.Value = result.Value;
                    }
                }                
            }
        }

        private void buildMetaData(dynamic metaDataValues)
        {            
            foreach (var m in metaDataValues)
            {
                var result = JsonConvert.DeserializeObject<dynamic>(m.Value.ToString());
                var metaData = new MetaData();
                metaData.Name = m.Name;
                metaData.Caption = result.caption;
                metaData.ReadOnly = result.readOnly != null ? result.readOnly : false;
                if (result.type != null)
                {
                    if(result.type.ToString() == "STRING")
                    {
                        metaData.DataType = MetaDataType.String;
                    }
                    else if (result.type.ToString() == "INTEGER")
                    {
                        metaData.DataType = MetaDataType.Int;
                    }
                    else if (result.type.ToString() == "DATE" || result.type.ToString() == "DATETIME")
                    {
                        metaData.DataType = MetaDataType.DateTime;
                    }
                }                
                MetaDataList.Add(metaData);
                CreateUcEditor(metaData);                
            }
        }

        private void CreateUcEditor(MetaData metaData)
        {
            IButtonEditor ucEditor = null;
            switch (metaData.DataType)
            {
                case MetaDataType.Int:
                    {
                        ucEditor = new ucEditorInt();
                        break;
                    }
                case MetaDataType.DateTime:
                    {
                        ucEditor = new ucEditorDateTime();
                        break;
                    }
                case MetaDataType.Float:
                    {
                        
                        break;
                    }
                case MetaDataType.String:
                    {
                        ucEditor = new ucEditor();                        
                        break;
                    }
                case MetaDataType.Text:
                    {
                        ucEditor = new ucEditorText();
                        break;
                    }
            }
            ucEditor.Caption = metaData.Caption;
            ucEditor.Parent = panVertialGrid;
            ucEditor.Dock = DockStyle.Bottom;
            var readOnly = metaData.ReadOnly || metaData.Name.Equals("createdAt") || metaData.Name.Equals("updatedAt");
            ucEditor.SetRequired(metaData.Required);
            ucEditor.SetReadOnly(readOnly);
            panVertialGrid.Height += ucEditor.Height;
            dicComp.Add(metaData.Name, ucEditor);
        }

        private void LoadModel()
        {
            if (primaryKey == null)
                CreateEntityFormFromMetaData();
            else
            {
                var connection = WDMMain.GetInstance().GetConnection();
                CreateEntityFormFromMetaData(connection.GetResponse($"api/model/{model}/{primaryKey}"));
            }
        }
    }
}
