using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vouchers.Models;

namespace VouchersMVC.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IGetDataRepository _data;  

        public EmployeeController(IGetDataRepository data)  
        {  
            _data = data;  
        }  
  
        public IActionResult Index()  
        {  
            return View();  
        }  
  
        public string GetNameById(int id)  
        {  
            return _data.GetNameById(id);  
        }  
    }
}