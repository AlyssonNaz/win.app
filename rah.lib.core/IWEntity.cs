using System;

namespace rah.lib.core
{
    public interface IWEntity
    {
        int Id { set; get; }
        DateTime createdAt { set; get; }
        DateTime updatedAt { set; get; }
    }
}
