using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApplication.Models;

namespace BakeryApplication.Tests 
{
    [TestClass]
    public class BreadClassTests
    {
        [TestMethod]
        public void BreadAmount_InstantiateEmptyBreadAmountConstructor_BreadAmount()
        {
        BreadClass newBread = new BreadClass ();
        Assert.AreEqual(typeof(BreadClass), newBread.GetType());
        }
        [TestMethod]
        public void GetBreadCount_ReturnBreadAmount_Int()
        {
        BreadClass newBread = new BreadClass (); 
        Assert.AreEqual(5, newBread.BreadCount(1));  
        }
        [TestMethod]
        public void GetBreadCountTwo_ReturnBreadAmountTwo_Int()
        {
        BreadClass newBread = new BreadClass (); 
        Assert.AreEqual(60, newBread.BreadCount(12));  
        }
        [TestMethod]
        public void GetBreadCountOddNumber_ReturnBreadAmountForOddNumber_Int()
        {
        BreadClass newBread = new BreadClass (); 
        Assert.AreEqual(65, newBread.BreadCount(13));
        }

        
    }
}