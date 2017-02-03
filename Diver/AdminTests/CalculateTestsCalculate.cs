using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver.Tests
{
    [TestClass()]
    public class CalculateTestsCalculate
    {
        [TestMethod()]
        public void Valid()
        {
            Calculate p1 = new Calculate(1.0);
            Assert.AreEqual(true, p1.Valid());
        }

        [TestMethod()]
        public void Calculate()
        {
            Calculate p1 = new Calculate();
            Array expected = new[] { 2, 3, 4, 5, 6 };
            


            Assert.AreEqual(expected, new[]{ 2, 3, 4, 5, 6});
        }

    }
}