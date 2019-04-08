using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Vouchers
{
    public class BalanceAccount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required, StringLength(50, ErrorMessage = "Account name must not exceed 50 chars.")]
        [MinLength(4, ErrorMessage = "@ least 4 chars ...")]
        public string Name { get; set; } 

        public bool Expense { get; set; }

        [JsonIgnore]
        public ICollection<VoucherDetail> VoucherDetails { get; set; }

    }
}
