using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class ExtensionMethod
    {
        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool IsOneOf<T>(this T value, params T[] items)
        {
            for (int i = 0; i < items.Length; ++i)
            {
                if (items[i].Equals(value))
                    return true;
            }
            return false;
        }
    }
}
