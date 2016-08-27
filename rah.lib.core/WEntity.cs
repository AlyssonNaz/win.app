using System;

namespace rah.lib.core
{
    public interface IWEntity
    {
        int Id { set; get; }
        DateTime DataCriacao { set; get; }
        DateTime DataModificacao { set; get; }
    }

    public class WEntity : IWEntity
    {
        public int Id { set; get; }
        public DateTime DataCriacao { set; get; }
        public DateTime DataModificacao { set; get; }
    }
}
