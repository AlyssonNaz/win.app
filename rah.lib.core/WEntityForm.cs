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
        private Dictionary<string, ucEditor> dicComp;

        public WEntityForm(string metaData, string model, object primaryKey)
        {
            InitializeComponent();
            DataTable = new DataTable();
            MetaDataList = new List<MetaData>();
            dicComp = new Dictionary<string, ucEditor>();
            panVertialGrid.Height = 0;

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
                        ucEditor ucEditor = null;
                        dicComp.TryGetValue(result.Name, out ucEditor);                       
                        ucEditor.Value = result.Value;
                    }
                }                
            }
        }

        private void buildMetaData(dynamic metaDataValues)
        {
            int index = 0;
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
                }                
                MetaDataList.Add(metaData);
                CreateUcEditor(metaData, index);
                index++;
            }
        }

        private void CreateUcEditor(MetaData metaData, int index)
        {
            var ucEditor = new ucEditor();
            ucEditor.Caption = metaData.Caption;
            ucEditor.Parent = panVertialGrid;
            ucEditor.Dock = DockStyle.Bottom;
            ucEditor.SetRequired(metaData.Required);
            ucEditor.SetReadOnly(metaData.ReadOnly);
            panVertialGrid.Height += 24;            
            switch (metaData.DataType)
            {
                case MetaDataType.Int:
                    {
                        ucEditor.CreateIntEditor();
                        break;
                    }
                case MetaDataType.DateTime:
                    {
                        ucEditor.CreateDateTimeEditor();
                        break;
                    }
                case MetaDataType.Float:
                    {
                        ucEditor.CreateFloatEditor();
                        break;
                    }
                case MetaDataType.String:
                    {
                        ucEditor.CreateStringEditor();                        
                        break;
                    }
                case MetaDataType.Text:
                    {
                        ucEditor.CreateMemoEditor();
                        break;
                    }
            }
            dicComp.Add(metaData.Name, ucEditor);   
        }

        private void LoadModel()
        {
            var obj = new ConnectionHandler().GetResponse($"api/model/{model}/{primaryKey}");
            CreateEntityFormFromMetaData(obj);
        }

        private void LoadEmptyModel()
        {
            CreateEntityFormFromMetaData();
        }

        protected virtual void DoBeforeCreate()
        {
        }
    }
}
