namespace rah.lib.core
{
    public class WList : IWList
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public object Itens { get; set; }
    }
}
