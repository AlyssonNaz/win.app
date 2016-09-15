﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace rah.lib.core
{
    public partial class WViewFrame : WFrame
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
                    var name = result.Name;
                    var value = result.Value;
                    if (DataTable.Columns.IndexOf(name) != -1)
                    {
                        row[name] = value;                        
                    }
                }
                DataTable.Rows.Add(row);
            }
        }

        private void buildMetaData(dynamic metaDataValues)
        {
            foreach(var m in metaDataValues)
            {
                var result = JsonConvert.DeserializeObject<dynamic>(m.Value.ToString());
                var metaData = new MetaData();
                metaData.Name = m.Name;
                metaData.Caption = result.caption;
                metaData.ReadOnly = result.readOnly;                
                if (result.type == "string")
                {
                    metaData.DataType = MetaDataType.MetaDataString;
                }
                else if (result.type == "int")
                {
                    metaData.DataType = MetaDataType.MetaDataInt;
                }                    
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
            //dataColumn.MaxLength = _metaData.Size;
            switch (metaData.DataType)
            {
                case MetaDataType.MetaDataInt :
                    {
                        dataColumn.DataType = typeof(int);
                        break;
                    }
                case MetaDataType.MetaDataDateTime :
                    {
                        dataColumn.DataType = typeof(DateTime);
                        break;
                    }
                case MetaDataType.MetaDataFloat :
                    {
                        dataColumn.DataType = typeof(float);
                        break;
                    }
                case MetaDataType.MetaDataString :
                    {
                        dataColumn.DataType = typeof(string);
                        break;
                    }
                case MetaDataType.MetaDataText :
                    {
                        dataColumn.DataType = typeof(string);
                        break;
                    }
            }
            DataTable.Columns.Add(dataColumn);
        }
    }
}
