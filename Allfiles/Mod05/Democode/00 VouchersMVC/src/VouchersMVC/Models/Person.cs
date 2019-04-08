using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vouchers.Models
{
    public class Person
    {
        public string Name { get; set; }
        public List<Person> Friends { get; set; }
    }
}
