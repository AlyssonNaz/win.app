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
        public DataTable DataTable { set; get; }
        private IList<MetaData> MetaDataList;
        private Dictionary<string, IButtonEditor> dicComp;

        public WEntityForm() { }

        public WEntityForm(string metaData, string model, object primaryKey)
        {
            InitializeComponent();            
            MetaDataList = new List<MetaData>();
            dicComp = new Dictionary<string, IButtonEditor>();
            panVertialGrid.Height = 0;
            this.metaData = metaData;
            this.model = model;
            this.primaryKey = primaryKey;
            LoadModel();
        }

        public void InitDataSouce()
        {
            var bs = new BindingSource();
            bs.DataSource = DataTable;                      
        }

        private void CreateEntityFormFromMetaData(string obj = "")
        {
            var Data = JsonConvert.DeserializeObject<dynamic>(metaData);
            buildMetaData(Data.metadata);            
            if (obj != "")
            {
                LoadEntity(obj);
            }
        }

        private void LoadEntity(string obj)
        {
            var results = JsonConvert.DeserializeObject<dynamic>(obj);
            foreach (var result in results)
            {
                if (dicComp.ContainsKey(result.Name))
                {
                    IButtonEditor buttonEditor = null;
                    dicComp.TryGetValue(result.Name, out buttonEditor);
                    buttonEditor.Value = result.Value;
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
                CreateButtonEditor(metaData);                
            }
        }

        private void CreateButtonEditor(MetaData metaData)
        {
            IButtonEditor buttonEditor = null;
            switch (metaData.DataType)
            {
                case MetaDataType.Int:
                    {
                        buttonEditor = new ucEditorInt();
                        break;
                    }
                case MetaDataType.DateTime:
                    {
                        buttonEditor = new ucEditorDateTime();
                        break;
                    }
                case MetaDataType.Float:
                    {
                        
                        break;
                    }
                case MetaDataType.String:
                    {
                        buttonEditor = new ucEditor();                        
                        break;
                    }
                case MetaDataType.Text:
                    {
                        buttonEditor = new ucEditorText();
                        break;
                    }
            }
            buttonEditor.Caption = metaData.Caption;
            buttonEditor.Parent = panVertialGrid;
            buttonEditor.Dock = DockStyle.Bottom;
            var readOnly = metaData.ReadOnly || metaData.Name.Equals("createdAt") || metaData.Name.Equals("updatedAt");
            buttonEditor.SetRequired(metaData.Required);
            buttonEditor.SetReadOnly(readOnly);
            panVertialGrid.Height += buttonEditor.Height;
            dicComp.Add(metaData.Name, buttonEditor);
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

        private void EntitySelect(object pk)
        {
            var connection = WDMMain.GetInstance().GetConnection();
            LoadEntity(connection.GetResponse($"api/model/{model}/{pk}"));
        }

        private void bbFirst_Click(object sender, EventArgs e)
        {
            primaryKey = DataTable.Rows[0]["id"];
            EntitySelect(primaryKey);
        }

        private void bbPrior_Click(object sender, EventArgs e)
        {
            var expression = $"id like '{primaryKey}'";
            DataRow row = DataTable.Select(expression)[0];
            var index = DataTable.Rows.IndexOf(row);
            index--;
            if (index < 0)
                index = 0;
            primaryKey = DataTable.Rows[index]["id"];
            EntitySelect(primaryKey);
        }

        private void bbNext_Click(object sender, EventArgs e)
        {
            var expression = $"id like '{primaryKey}'";
            DataRow row = DataTable.Select(expression)[0];
            var index = DataTable.Rows.IndexOf(row);
            index++;
            if (index > DataTable.Rows.Count -1)
                index = DataTable.Rows.Count -1;
            primaryKey = DataTable.Rows[index]["id"];
            EntitySelect(primaryKey);
        }

        private void bbLast_Click(object sender, EventArgs e)
        {
            primaryKey = DataTable.Rows[DataTable.Rows.Count - 1]["id"];
            EntitySelect(primaryKey);
        }
    }
}
