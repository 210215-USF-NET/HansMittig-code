using System;
using Xunit;
using CalcClass;

namespace TestCalculator
{
    public class TestCalc
    {
        CalcClass test = new CalcClass();
        [Fact]
        public void AddNumber()
        {
            var sum = test.Add(0,0);

            Assert.Equal(0, sum);
        }
    }
}
