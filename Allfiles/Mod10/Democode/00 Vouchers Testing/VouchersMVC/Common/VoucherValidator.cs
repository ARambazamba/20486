using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vouchers.Common
{
    public class VoucherValidator
    {
        public static bool Validate(Voucher v, VoucherDetail[] details, BalanceAccount[] accts = null)
        {
            bool result = false;

            if (v != null && details != null)
            {
                result = v.Amount == details.Sum(f => f.Amount);
            }
            return result;
        }
    }
}
