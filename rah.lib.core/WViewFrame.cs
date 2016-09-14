using Newtonsoft.Json;
using System;
using System.Collections;
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
            _dataTable = new DataTable();
            _metaDataList = new List<MetaData>();           
        }

        private DataTable _dataTable;
        private IList<MetaData> _metaDataList;
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
            bs.DataSource = _dataTable;
            gridControl1.DataSource = bs.DataSource;            
            gridView1.RestoreLayoutFromRegistry($"SOFTWARE\\Rah\\{model}");
        }

        private void buildItens(dynamic itensValues)
        {            
            foreach (var iten in itensValues)
            {
                var results = JsonConvert.DeserializeObject<dynamic>(iten.ToString());
                var row = _dataTable.NewRow();
                foreach (var result in results)
                {
                    var name = result.Name;
                    var value = result.Value;
                    if (_dataTable.Columns.IndexOf(name) != -1)
                    {
                        row[name] = value;                        
                    }
                }
                _dataTable.Rows.Add(row);
            }
        }

        private void buildMetaData(dynamic metaDataValues)
        {
            foreach(var metaData in metaDataValues)
            {
                var result = JsonConvert.DeserializeObject<dynamic>(metaData.Value.ToString());
                var _metaData = new MetaData();
                _metaData.Name = metaData.Name;
                _metaData.Caption = result.caption;
                _metaData.ReadOnly = result.readOnly;
                if (result.type == "string")
                    _metaData.DataType = MetaDataType.MetaDataString;
                else if (result.type == "int")
                    _metaData.DataType = MetaDataType.MetaDataInt;
                _metaDataList.Add(_metaData);
                buildDataTable(_metaData);
            }
        }

        private void buildDataTable(MetaData _metaData)
        {
            var dataColumn = new DataColumn();
            dataColumn.ColumnName = _metaData.Name;
            dataColumn.Caption = _metaData.Caption;
            dataColumn.ReadOnly = _metaData.ReadOnly;
            //dataColumn.MaxLength = _metaData.Size;
            switch (_metaData.DataType)
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
            _dataTable.Columns.Add(dataColumn);
        }
    }
}
