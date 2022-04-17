using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator2._0
{
    public class ListEnum
    {
        public static Dictionary<int, string> EnumList()
        {
            return Enum.GetValues(typeof(Operation)).Cast<Operation>()
                .ToDictionary(operation => (int) operation, operation => operation.ToString());
        }
    }
}