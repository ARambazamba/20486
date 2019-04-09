using Vouchers.Common;
using Xunit;

namespace VouchersTests
{
    public class CalculationTests
    {
        [Fact]
        public void TestEquality()
        {
            Assert.Equal(4, Calculation.Add(2, 2));
        }

        [Fact]
        public void TestForEqual()
        {
            Assert.NotEqual(5, Calculation.Add(2, 2));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void IsOddTheory(int value)
        {
            Assert.True(Calculation.IsOdd(value));
        }        
    }
}
