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

        public WEntityForm()
        {
            InitializeComponent();
        }

        public WEntityForm(string metaData, string model, object primaryKey)
        {
            DataTable = new DataTable();
            MetaDataList = new List<MetaData>();

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
            var row = DataTable.NewRow();
            if (obj != "")
            {
                var results = JsonConvert.DeserializeObject<dynamic>(obj);
                foreach (var result in results)
                {
                    if (DataTable.Columns.IndexOf(result.Name) != -1)
                        if (result.Value.ToString() != "")
                            row[result.Name] = result.Value;
                }                
            }
            DataTable.Rows.Add(row);
            BindingSource bs = new BindingSource();
            bs.DataSource = DataTable;
            VGridControl grid = new VGridControl();
            grid.Parent = this;
            grid.Dock = DockStyle.Fill;
            grid.DataSource = bs.DataSource;
            grid.RowHeaderWidth = 170;
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
                metaData.DataType = MetaDataType.MetaDataString;
                MetaDataList.Add(metaData);
                buildDataTable(metaData);
            }
        }

        private void buildDataTable(MetaData metaData)
        {
            var dataColumn = new DataColumn();
            dataColumn.ColumnName = metaData.Name;
            dataColumn.Caption = metaData.Caption;
            dataColumn.ReadOnly = metaData.ReadOnly;
            switch (metaData.DataType)
            {
                case MetaDataType.MetaDataInt:
                    {
                        dataColumn.DataType = typeof(int);
                        break;
                    }
                case MetaDataType.MetaDataDateTime:
                    {
                        dataColumn.DataType = typeof(DateTime);
                        break;
                    }
                case MetaDataType.MetaDataFloat:
                    {
                        dataColumn.DataType = typeof(float);
                        break;
                    }
                case MetaDataType.MetaDataString:
                    {
                        dataColumn.DataType = typeof(string);
                        break;
                    }
                case MetaDataType.MetaDataText:
                    {
                        dataColumn.DataType = typeof(string);
                        break;
                    }
            }
            DataTable.Columns.Add(dataColumn);
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
