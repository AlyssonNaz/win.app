using System;

namespace rah.lib.core
{
    [Flags]
    public enum MetaDataType
    {
        MetaDataInt = 0,
        MetaDataString = 2,
        MetaDataDateTime = 4,
        MetaDataFloat = 8,
        MetaDataText = 16
    }
}
