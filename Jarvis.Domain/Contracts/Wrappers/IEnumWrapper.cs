using System;
using System.Collections.Generic;

namespace Jarvis.Domain.Contracts.Wrappers
{
    public interface IEnumWrapper
    {
        IList<String> GetNames(Type enumType);
        Enum GetEnumFromValue(string value, Type type);
    }
}
