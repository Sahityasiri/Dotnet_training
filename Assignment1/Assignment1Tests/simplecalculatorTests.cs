using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class simplecalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Icalcii calc=new simplecalculator();
            int res = calc.Add(5, 5);
            Assert.AreEqual(10,res);
        }
        public void SubtractTest()
        {
            Icalcii calc = new simplecalculator();
            int res = calc.Subtract(5, 5);
            Assert.AreEqual(0, res);
        }
        public void MultiplyTest()
        {
            Icalcii calc = new simplecalculator();
            int res = calc.Multiply(5, 5);
            Assert.AreEqual(25, res);
        }
        public void DivideTest()
        {
            Icalcii calc = new simplecalculator();
            int res = calc.Divide(5, 5);
            Assert.AreEqual(1, res);
        }
    }
}