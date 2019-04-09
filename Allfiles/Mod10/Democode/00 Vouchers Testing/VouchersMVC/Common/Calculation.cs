using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vouchers.Common
{
    public class Calculation
    {
        public static bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
