using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApplication.Models;

namespace BakeryApplication.Tests 
{
    [TestClass]
    public class BreadClassTests
    {
        [TestMethod]
        public void BreadClassConstructor_InstantiateEmptyBreadClassConstructor_BreadClass()
        {
            BreadClass newBread = new BreadClass(5);
            Assert.AreEqual(typeof(BreadClass), newBread.GetType());
        }
        [TestMethod]
        public void GetBreadLoafAmount_ReturnsBreadLoafAmount_BreadClass()
        {
            int breadLoafAmount = 5;
            BreadClass newBread = new BreadClass(5);
            Assert.AreEqual(breadLoafAmount, newBread.BreadLoafAmount);

        }
        [TestMethod]
        public void CalculatedBaseCost_ReturnBreadCost_int()
        {
            int breadLoafAmount = 2;
            BreadClass newBread = new BreadClass(breadLoafAmount);
            Assert.AreEqual(10, newBread.CalculatedBaseCost(2));
        }
        [TestMethod]
        public void CalculatedBonusCost_ReturnsBonusBreadLoaves_int()
        {
           int breadLoafAmount = 3;
           BreadClass newBread = new BreadClass(breadLoafAmount);
           Assert.AreEqual(0, newBread.CalculatedBonusCost(breadLoafAmount));

        }
        
    }
}