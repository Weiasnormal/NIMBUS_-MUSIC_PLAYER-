using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Helpers
{
    internal static class Return
    {
        public static bool OK(int execrows)
        {
            if (execrows > 0)
            {
                return true;
            }

            return false;
        }
    }
}
