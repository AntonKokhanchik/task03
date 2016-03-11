using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensions
{
    static class ExtFunc
    {
        public static string GetString<T>(this IList<T> list)
        {
            StringBuilder result = new StringBuilder();
            foreach (T elem in list)
                result = result.AppendFormat("{0}, ", elem);
            result.Remove(result.Length - 2, 2);
            return result.ToString();
        }
    }
}
