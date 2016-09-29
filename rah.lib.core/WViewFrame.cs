using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace rah.lib.core
{
    public partial class WViewFrame : WFrame, IWViewFrame
    {
        public WViewFrame()
        {
            InitializeComponent();
            DataTable = new DataTable();
            MetaDataList = new List<MetaData>();
        }

        private DataTable DataTable;
        private IList<MetaData> MetaDataList;
        private string model;

        protected virtual void DoLoadModel(string model)
        {
            // para ser sobrecarregado.
        }

        public void LoadModel(string model)
        {
            this.model = model;
            DoLoadModel(model);
        }

        protected string GetModelListUrl(string model)
        {
            return $"api/model/{model}/list";
        }

        public void DoLeave()
        {
            gridView1.SaveLayoutToRegistry($"SOFTWARE\\Rah\\{model}");
        }

        protected void buildResponse(string response)
        {
            var metaData = ((dynamic)JsonConvert.DeserializeObject(response)).metadata;
            var itens = ((dynamic)JsonConvert.DeserializeObject(response)).itens;
            buildMetaData(metaData);
            buildItens(itens);

            BindingSource bs = new BindingSource();
            bs.DataSource = DataTable;
            gridControl1.DataSource = bs.DataSource;
            gridView1.RestoreLayoutFromRegistry($"SOFTWARE\\Rah\\{model}");
        }

        private void buildItens(dynamic itensValues)
        {
            foreach (var iten in itensValues)
            {
                var results = JsonConvert.DeserializeObject<dynamic>(iten.ToString());
                var row = DataTable.NewRow();
                foreach (var result in results)
                {
                    if (DataTable.Columns.IndexOf(result.Name) != -1)
                        if(result.Value.ToString() != "")
                            row[result.Name] = result.Value;
                }
                DataTable.Rows.Add(row);
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
                metaData.DataType = MetaDataType.String;
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
                case MetaDataType.Int:
                    {
                        dataColumn.DataType = typeof(int);
                        break;
                    }
                case MetaDataType.DateTime:
                    {
                        dataColumn.DataType = typeof(DateTime);
                        break;
                    }
                case MetaDataType.Float:
                    {
                        dataColumn.DataType = typeof(float);
                        break;
                    }
                case MetaDataType.String:
                    {
                        dataColumn.DataType = typeof(string);
                        break;
                    }
                case MetaDataType.Text:
                    {
                        dataColumn.DataType = typeof(string);
                        break;
                    }
            }
            DataTable.Columns.Add(dataColumn);            
        }

        protected virtual IWEntityForm CreateEntityForm(string model, object primaryKey = null)
        {
            Utility.LockWindowUpdate();
            try
            {
                var connection = WDMMain.GetInstance().GetConnection();
                var entityForm = new WEntityForm(connection.GetResponse($"api/model/{model}/info"), model, primaryKey);
                entityForm.MdiParent = WDMMain.GetInstance().MainForm;
                entityForm.Show();
                entityForm.DataTable = DataTable;
                entityForm.InitDataSouce();
                return entityForm;
            }
            finally
            {
                Utility.UnLockWindowUpdate();
            }            
        }

        private void nbiAdd_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CreateEntityForm(model);
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            CreateEntityForm(model, gridView1.GetFocusedRowCellValue("id"));
        }
    }
}
