namespace rah.lib.core
{
    public interface IWList
    {
        int Count { get; set; }
        int Page { get; set; }
        int Size { get; set; }
        object Itens { get; set; }
    }

    public class WList : IWList
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public object Itens { get; set; }
    }
}
