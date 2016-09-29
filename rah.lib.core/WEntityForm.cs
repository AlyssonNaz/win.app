using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
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
        public DataTable DataTable { set; get; } = new DataTable();
        private IList<MetaData> MetaDataList = new List<MetaData>();
        private Dictionary<string, Control> dicComp = new Dictionary<string, Control>();

        public WEntityForm() { }

        public WEntityForm(string metaData, string model, object primaryKey)
        {
            InitializeComponent();
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
                    Control buttonEditor = null;
                    dicComp.TryGetValue(result.Name, out buttonEditor);
                    (buttonEditor as TextEdit).EditValue = result.Value;                    
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
                metaData.Caption = result.caption != null ? result.caption : "";
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
            RepositoryItemTextEdit repository = null;
            Control buttonEditor = null;
            switch (metaData.DataType)
            {
                case MetaDataType.Int:
                    {
                        buttonEditor = new SpinEdit();
                        break;
                    }
                case MetaDataType.DateTime:
                    {
                        buttonEditor = new DateEdit();                        
                        break;
                    }
                case MetaDataType.Float:
                    {
                        
                        break;
                    }
                case MetaDataType.String:
                    {
                        buttonEditor = new ButtonEdit();
                        (buttonEditor as ButtonEdit).Properties.Buttons.Clear();                        
                        break;
                    }
                case MetaDataType.Text:
                    {
                        buttonEditor = new MemoEdit();
                        break;
                    }
            }

            LayoutControlItem lci = layoutControl.Root.AddItem();
            repository = (buttonEditor as TextEdit).Properties;
            lci.Control = buttonEditor;   
            repository.ReadOnly = metaData.ReadOnly || metaData.Name.Equals("createdAt") || metaData.Name.Equals("updatedAt");
            lci.Text = metaData.Caption;
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
            if (index < 0) {
                index = 0;
            }
            primaryKey = DataTable.Rows[index]["id"];
            EntitySelect(primaryKey);
        }

        private void bbNext_Click(object sender, EventArgs e)
        {
            var expression = $"id like '{primaryKey}'";
            DataRow row = DataTable.Select(expression)[0];
            var index = DataTable.Rows.IndexOf(row);
            index++;
            if (index > DataTable.Rows.Count -1) {
                index = DataTable.Rows.Count - 1;
            }                
            primaryKey = DataTable.Rows[index]["id"];
            EntitySelect(primaryKey);
        }

        private void bbLast_Click(object sender, EventArgs e)
        {
            primaryKey = DataTable.Rows[DataTable.Rows.Count - 1]["id"];
            EntitySelect(primaryKey);
        }

        private void bbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
