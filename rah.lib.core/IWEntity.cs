using System;

namespace rah.lib.core
{
    public interface IWEntity
    {
        int Id { set; get; }
        DateTime DataCriacao { set; get; }
        DateTime DataModificacao { set; get; }
    }
}
