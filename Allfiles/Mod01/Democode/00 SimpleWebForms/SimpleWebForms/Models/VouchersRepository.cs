using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebForms.Models
{
    public class VouchersRepository
    {
        //Vouchers

        public static List<Voucher> GetVouchers()
        {
            using (VouchersDBEntities ctx = new VouchersDBEntities())
            {
                return ctx.Vouchers.OrderByDescending(v => v.Date).ToList();
            }
        }

        public static Voucher GetVoucher(Guid ID)
        {
            using (VouchersDBEntities ctx = new VouchersDBEntities())
            {
                return ctx.Vouchers.FirstOrDefault(v => v.ID == ID);
            }
        }

        //Voucher Details

        public static List<VoucherDetail> GetVoucherDetails(Guid ID)
        {
            using (VouchersDBEntities ctx = new VouchersDBEntities())
            {
                return ctx.VoucherDetails.Where(v => v.VoucherID == ID).ToList();
            }
        }

        public static VoucherDetail GetVoucherDetail(Guid ID)
        {
            using (VouchersDBEntities ctx = new VouchersDBEntities())
            {
                return ctx.VoucherDetails.FirstOrDefault(v => v.ID == ID);
            }
        }

        public static void AddDetail(VoucherDetail Item)
        {
            using (VouchersDBEntities ctx = new VouchersDBEntities())
            {
                ctx.VoucherDetails.Add(Item);
                ctx.SaveChanges();
            }
        }

        public static void RemoveDetail(VoucherDetail Item)
        {
            using (VouchersDBEntities ctx = new VouchersDBEntities())
            {
                var d = ctx.VoucherDetails.FirstOrDefault(vd => vd.ID == Item.ID);
                ctx.VoucherDetails.Remove(d);
                ctx.SaveChanges();
            }
        }

        //Accounts

        public static List<Account> GetAccountsByType(int Type)
        {
            using (VouchersDBEntities ctx = new VouchersDBEntities())
            {
                var isIncome = Convert.ToBoolean(Type);
                return ctx.Accounts.Where(v=>v.Type==isIncome).OrderByDescending(v => v.Type).ToList();
            }
        }

        public static List<Account> GetAllAcccounts()
        {
            using (VouchersDBEntities ctx = new VouchersDBEntities())
            {
                return ctx.Accounts.OrderBy(v => v.Name).ToList();
            }
        }
    }
}