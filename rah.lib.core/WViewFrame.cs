using Newtonsoft.Json;
using System;
using System.Data;

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
        }

        private void buildItens(dynamic itensValues)
        {            
        }

        private void buildMetaData(dynamic metaDataValues)
        {
            //var metaDataInfo = new MetaData();
            //foreach (var m in metaDataValue)
            //{
            //    var metaDataFirst = m.First;
            //    foreach (var metaData in metaDataFirst)
            //    {
            //        metaDataInfo.Caption = metaData.caption;
            //        metaDataInfo.ReadOnly = metaData.readOnly;
            //        if (metaData.type == "string")
            //            metaDataInfo.DataType = MetaDataType.MetaDataString;
            //        else if (metaData.type == "int")
            //            metaDataInfo.DataType = MetaDataType.MetaDataInt;
            //    }
            //}

            buildDataTable();
        }

        private void buildDataTable()
        {
            var dataColumn = new DataColumn();
            dataColumn.Caption = _metaData.Caption;
            dataColumn.ReadOnly = _metaData.ReadOnly;
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
