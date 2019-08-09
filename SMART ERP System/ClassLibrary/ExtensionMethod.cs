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
    }
}
