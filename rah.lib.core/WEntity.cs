using System;

namespace rah.lib.core
{
    public class WEntity : IWEntity
    {
        public int Id { set; get; }
        public DateTime DataCriacao { set; get; }
        public DateTime DataModificacao { set; get; }
    }
}
