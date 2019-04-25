using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vouchers.Models;

namespace Vouchers
{
    public class Demo : Controller
    {
        private IVouchersRepository rep;

        private VouchersDBContext ctx;

        public Demo(IVouchersRepository repository)
        {
            rep = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitDemo()
        {
            var model = rep.GetVoucher(2);
            return View(model);
        }

        [HttpPost]
        public IActionResult SubmitDemo(VoucherDetailsViewModel v)
        {
            return SubmitDemo();
        }

        public async Task<IActionResult> AsyncDemo()
        {
            var model = await ctx.Vouchers.Where(f => f.ID == 2).FirstOrDefaultAsync();
            return View(model);
        }

        public IActionResult DoIteration()
        {
            var p1 = new Person {Name = "Hugo"};
            var p2 = new Person {Name = "Paul"};
            var p3 = new Person {Name = "Alex"};
            p1.Friends = new List<Person> {p2, p3};

            return View(p1);
        }
    }
}
