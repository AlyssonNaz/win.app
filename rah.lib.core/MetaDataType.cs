using System;

namespace rah.lib.core
{
    [Flags]
    public enum MetaDataType
    {
        Int = 0,
        String = 2,
        DateTime = 4,
        Float = 8,
        Text = 16
    }
}
