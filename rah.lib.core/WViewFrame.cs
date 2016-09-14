using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;

namespace rah.lib.core
{
    public partial class WViewFrame : WFrame
    {        
        public WViewFrame()
        {
            InitializeComponent();
            _metaData = new MetaData();
            _dataTable = new DataTable();
        }

        private MetaData _metaData;
        private DataTable _dataTable; 

        protected virtual void DoLoadModel(string model)
        {
            // para ser sobrecarregado.
        }

        public void LoadModel(string model)
        {
            DoLoadModel(model);
        }

        protected string GetModelListUrl(string model)
        {
            return $"api/model/{model}/list";
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
        }

        private void buildItens(dynamic itensValues)
        {
                        
        }

        private void buildMetaData(dynamic metaDataValues)
        {
            foreach(var metaData in metaDataValues)
            {
                var result = JsonConvert.DeserializeObject<dynamic>(metaData.Value.ToString());
                _metaData.Caption = result.caption;
                _metaData.ReadOnly = result.readOnly;
                if (result.type == "string")
                    _metaData.DataType = MetaDataType.MetaDataString;
                else if (result.type == "int")
                    _metaData.DataType = MetaDataType.MetaDataInt;
                buildDataTable();
            }
        }

        private void buildDataTable()
        {
            var dataColumn = new DataColumn();
            dataColumn.Caption = _metaData.Caption;
            dataColumn.ReadOnly = _metaData.ReadOnly;
            dataColumn.MaxLength = _metaData.Size;
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
