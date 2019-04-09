using System;
using System.Collections.Generic;
using System.Linq;
using Vouchers;
using Vouchers.Common;
using Xunit;

namespace VouchersTests
{
    public class VouchersValidatorTests
    {
        private VoucherDetailsViewModel data;
        public VouchersValidatorTests()
        {
            data = GetMockData();
        }

        [Fact]
        public void SumVoucherEqualsVoucherDetailsSum()
        {
            Assert.Equal(VoucherValidator.Validate(data.CurrentVoucher, data.CurrentVoucher.Details.ToArray(), data.Accounts.ToArray()),true);
        }

        [Fact]
        public void SumVoucherNotEqualsVoucherDetailsSumIsNotValid()
        {
            var details = data.CurrentVoucher.Details;
            details.Add(new VoucherDetail { VoucherID = data.CurrentVoucher.ID, Text = "USB Stick", Amount = 22, AccountID = 1 });
            Assert.Equal(VoucherValidator.Validate(data.CurrentVoucher, details.ToArray(), data.Accounts.ToArray()), false);
        }

        [Fact]
        public void VoucherNullIsNotValid()
        {
            Assert.Equal(VoucherValidator.Validate(null, data.CurrentVoucher.Details.ToArray(), data.Accounts.ToArray()), false);
        }

        [Fact]
        public void VoucherWithDetailsNullNotValid()
        {
            Assert.Equal(VoucherValidator.Validate(data.CurrentVoucher, null, data.Accounts.ToArray()), false);
        }

        //[Fact]
        //public void VoucherIsOfSameTypeAsDetailAccounts()
        //{
        //    Assert.Equal(VoucherValidator.Validate(data.CurrentVoucher, data.CurrentVoucher.Details.ToArray(), data.Accounts.ToArray()), true);
        //}

        private static VoucherDetailsViewModel GetMockData()
        {
            VoucherDetailsViewModel vdvm = new VoucherDetailsViewModel
            {
                CurrentVoucher = new Voucher
                {
                    Date = DateTime.Now.AddDays(-3),
                    Amount = 40,
                    Text = "Media Markt",
                    Paid = true,
                    Expense = true
                },
                Accounts = GetAccounts()
            };
            vdvm.CurrentVoucher.Details = GetDetails(vdvm.CurrentVoucher.ID);
            return vdvm;
        }

        
        private static List<VoucherDetail> GetDetails(int VoucherID)
        {
            List<VoucherDetail> details = new List<VoucherDetail>
            {
                new VoucherDetail {VoucherID = VoucherID, Text = "Game of Thrones, Season 6", Amount = 29, AccountID = 1},
                new VoucherDetail {VoucherID = VoucherID, Text = "USB Stick", Amount = 11, AccountID = 1}
            };
            return details;
        }

        private static Voucher GetVoucher()
        {
            var v = new Voucher
            {
                Date = DateTime.Now.AddDays(-3),
                Amount = 40,
                Text = "Media Markt",
                Paid = true,
                Expense = true
            };
            return v;
        }

        private static List<BalanceAccount> GetAccounts()
        {
            List<BalanceAccount> result = new List<BalanceAccount>
            {
                new BalanceAccount {Name = "Unclassified", Expense = true},
                new BalanceAccount {Name = "Car Maintenance", Expense = true},
                new BalanceAccount {Name = "Development", Expense = false},
                new BalanceAccount {Name = "Consulting", Expense = false},
                new BalanceAccount {Name = "Training", Expense = false},
                new BalanceAccount {Name = "Software", Expense = true},
                new BalanceAccount {Name = "Hosting & Internet", Expense = true}
            };
            return result;
        }
    }
}
