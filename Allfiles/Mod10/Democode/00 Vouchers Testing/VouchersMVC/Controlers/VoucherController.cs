using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Vouchers
{
    public class VoucherController : Controller
    {
        private IVouchersRepository rep;

        public VoucherController(IVouchersRepository repository)
        {
            rep = repository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Vouchers App";
            //ViewBag.MyProp = "Alex";
            //ViewBag.MaxRows = 10;
            var model = rep.GetAllVouchers();
            return View(model);            
        }
        
        //Voucher Details
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            VoucherDetailsViewModel model = rep.GetVoucher(Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int Id, VoucherDetailsViewModel value, string ActionBtn)
        {
            int redirectID = Id;
            switch (ActionBtn)
            {
                case "Save Voucher":
                    if(value.CurrentVoucher != null)
                    {
                        if (value.CurrentVoucher.ID == 0)
                        {
                            var v =  rep.CreateVoucher(value.CurrentVoucher);
                            redirectID = v.ID;
                        }
                        else
                        {
                            rep.UpdateVoucher(value.CurrentVoucher);
                        }
                    }
                    break;
                case "Save Detail":
                    if (value.EditDetail != null)
                    {
                        var vd = value.EditDetail;
                        vd.VoucherID = value.CurrentVoucher.ID;
                        if (vd.ID == 0)
                        {
                            rep.CreateVoucherDetail(vd);
                        }
                        else
                        {
                            rep.UpdateVoucherDetail(vd);
                        }
                    }
                    break;
            }        
            return RedirectToAction("Edit", new {id=redirectID });
        }

        public IActionResult DeleteDetail(int DetailID, int VoucherID)
        {
            rep.DeleteVoucherDetail(DetailID);
            return RedirectToAction("Edit", "Voucher", new { Id = VoucherID});
        }
    }
}
