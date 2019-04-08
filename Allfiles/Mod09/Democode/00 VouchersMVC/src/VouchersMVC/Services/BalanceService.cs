using System.Linq;

namespace Vouchers
{
    public class BalanceService
    {
        private readonly VouchersDBContext ctx;

        public BalanceService(VouchersDBContext context)
        {
            ctx = context;
        }

        public string GetSumTotal(bool expense)
        {
            var result = expense ? "Total Expenses: " : "Total Income: ";
            var accts = ctx.BalanceAccounts.Where(f => f.Expense == expense).Select(f => f.ID).ToList();
            var vds = ctx.VoucherDetails.Where(f => f.Account != null && accts.Contains(f.AccountID)).Sum(f => f.Amount);
            return result + vds;
        }
    }
}