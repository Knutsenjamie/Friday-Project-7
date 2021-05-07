using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApplication.Models;

namespace BakeryApplication.Tests 
{
    [TestClass]
    public class BreadClassTests
    {
        [TestMethod]
        public void GetAmount_ReturnAmount_()
        {
        BreadClass breadOrder = new BreadClass();
        Assert.AreEqual(0, breadOrder.BreadTotal(0));
        }
    }
}