using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vouchers
{
    public class VoucherDetailsViewModel
    {
        public Voucher CurrentVoucher { get; set; }

        public VoucherDetail EditDetail { get; set; }

        public List<VoucherDetail> Details { get; set; }

        public List<BalanceAccount> Accounts { get; set; }        
    }
}
