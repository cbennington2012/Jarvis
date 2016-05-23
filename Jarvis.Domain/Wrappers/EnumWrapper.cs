using System;
using System.Collections.Generic;
using Jarvis.Domain.Contracts.Wrappers;

namespace Jarvis.Domain.Wrappers
{
    public class EnumWrapper : IEnumWrapper
    {
        public IList<String> GetNames(Type enumType)
        {
            return Enum.GetNames(enumType);
        }

        public Enum GetEnumFromValue(string value, Type type)
        {
            return Enum.Parse(type, value ?? "0") as Enum; 
        }
    }
}
