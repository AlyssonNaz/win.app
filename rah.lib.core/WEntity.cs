using System;

namespace rah.lib.core
{
    public class WEntity : IWEntity
    {
        public int Id { set; get; }
        public DateTime createdAt { set; get; }
        public DateTime updatedAt { set; get; }
    }
}
