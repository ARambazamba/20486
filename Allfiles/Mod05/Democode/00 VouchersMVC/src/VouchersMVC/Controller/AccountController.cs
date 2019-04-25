using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Vouchers
{
    public class AccountController : Controller
    {
        private VouchersDBContext ctx;

        public AccountController(VouchersDBContext dbcontext)
        {
            ctx = dbcontext;
        }

        public IActionResult Index()
        {
            var model = ctx.BalanceAccounts.OrderBy(f => f.Expense).ThenBy(f => f.Name).ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new BalanceAccount());
        }

        [HttpPost]
        public IActionResult Create(BalanceAccount acct)
        {
            if (ModelState.IsValid)
            {
                ctx.BalanceAccounts.Add(acct);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int Id)
        {
            var acct = ctx.BalanceAccounts.FirstOrDefault(f => f.ID == Id);
            return View(acct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int Id, BalanceAccount acct)
        {
            if (ModelState.IsValid)
            {
                var a = ctx.BalanceAccounts.FirstOrDefault(f => f.ID == Id);
                if (a != null)
                {
                    Mapper.CopyData(acct, a);
                    ctx.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            var a = ctx.BalanceAccounts.FirstOrDefault(f => f.ID == Id);
            if (a!=null)
            {
                ctx.Remove(a);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
