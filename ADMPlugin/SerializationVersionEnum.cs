using System;
using System.Collections.Generic;
using System.Text;

namespace AgGateway.ADAPT.ADMPlugin
{
    public enum SerializationVersionEnum
    {
        Unknown = 0,
        V1 = 1,
        V2 = 2,
        XML = 3,
        SQLite = 4,
        Parquet = 5
    }
}