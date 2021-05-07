using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApplication.Models;

namespace BakeryApplication.Tests 
{
    [TestClass]
    public class BreadClassTests
    {
        [TestMethod]
        public void GetAmount_ReturnAmount_int()
        {
        BreadClass breadOrder = new BreadClass();
        Assert.AreEqual(5, breadOrder.BreadPrice(1));
        }
        [TestMethod]
        public void GetAmountSecond_ReturnAmountSecond_int()
        {
        BreadClass breadOrder = new BreadClass();
        Assert.AreEqual(60, breadOrder.BreadPrice(12));
        }
        
    }
}