using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Vouchers
{
    public class RememberedVouchers : ViewComponent
    {
        private VouchersDBContext ctx;

        public RememberedVouchers(VouchersDBContext db)
        {
            ctx = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await ctx.Vouchers.Where(f => f.Remark).ToListAsync();
            return View("Default", model);
        }

    }
}
