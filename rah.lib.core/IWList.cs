namespace rah.lib.core
{
    public interface IWList
    {
        int Count { get; set; }
        int Page { get; set; }
        int Size { get; set; }
        object Itens { get; set; }
    }
}
