using Moq;  
using Microsoft.Extensions.Logging;
using Vouchers.Models;
using VouchersMVC.Controllers;
using Xunit;

namespace VouchersTests  
{  
    public class MockTest  
    {  
        [Fact]
        public void UseMock()  
        {  
            var mock = new Mock<IGetDataRepository>();  
            mock.Setup(p => p.GetNameById(1)).Returns("Jignesh");  
            EmployeeController home = new EmployeeController(mock.Object);  
            string result = home.GetNameById(1); 
            Assert.Equal("Jignesh", result);
        }  
    }  
}  