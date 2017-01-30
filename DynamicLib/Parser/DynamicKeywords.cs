
using System.Collections.Generic;

namespace DynamicLib.Parser
{
    using System;
    using System.Linq.Expressions;

    public static class DynamicKeywords
    {
        public static readonly Dictionary<string, object> Keywords = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase)
        {
            {"true", Expression.Constant(true)},
            {"false", Expression.Constant(false)},
            {"null", Expression.Constant(null)},
            {"it", "it"},
            {"iif", "iif"},
            {"new", "new"},
            {"Object", typeof(Object)},
            {"Boolean", typeof(Boolean)},
            {"Char", typeof(Char)},
            {"String", typeof(String)},
            {"SByte", typeof(SByte)},
            {"Byte", typeof(Byte)},
            {"Int16", typeof(Int16)},
            {"UInt16", typeof(UInt16)},
            {"Int32", typeof(Int32)},
            {"UInt32", typeof(UInt32)},
            {"Int64", typeof(Int64)},
            {"UInt64", typeof(UInt64)},
            {"Single", typeof(Single)},
            {"Double", typeof(Double)},
            {"Decimal", typeof(Decimal)},
            {"DateTime", typeof(DateTime)},
            {"TimeSpan", typeof(TimeSpan)},
            {"Guid", typeof(Guid)},
            {"Math", typeof(Math)},
            {"Convert", typeof(Convert)}
        }; 
    }
}
