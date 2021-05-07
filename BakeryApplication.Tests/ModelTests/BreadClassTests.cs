using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApplication.Models;

namespace BakeryApplication.Tests 
{
    [TestClass]
    public class BreadClassTests
    {
        [TestMethod]
        public void BreadPrice_InstantiateEmptyBreadPriceConstructor_BreadPrice()
        {
        BreadClass newBread = new BreadClass ();
        Assert.AreEqual(typeof(BreadClass), newBread.GetType());
        }
        [TestMethod]
        public void GetBreadAmount_ReturnPrice_Int()
        {
        BreadClass newBread = new BreadClass (1); 
        Assert.AreEqual(1, newBread.BreadPrice(5.00));  
        }

    
        
    }
}