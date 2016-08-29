namespace rah.lib.core
{
    public class MetaData
    {
        public string Name { get; set; }
        public string Caption { get; set; }
        public string DataType { get; set; }
        public int Size { get; set; }
        public bool Required { get; set; }
        public bool ReadOnly { get; set; }

        public void Load(string metaData)
        {
        }
    }
}
