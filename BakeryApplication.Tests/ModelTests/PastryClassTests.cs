using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApplication.Models;

namespace BakeryApplication.Tests 
{
    [TestClass]
    public class PastryClassTests
    {
        [TestMethod]
        public void PastryAmount_InstantiateEmptyPastryAmountConstructor_PastryAmount()
        {
        PastryClass newPastry = new PastryClass (5);
        Assert.AreEqual(typeof(PastryClass), newPastry.GetType());
        }
        [TestMethod]
        public void GetPastryAmount_ReturnPastryAmount_PastryAmount()
        {
        int pastryAmount = 3;
        PastryClass newPastry = new PastryClass(pastryAmount);
        Assert.AreEqual(pastryAmount, newPastry.PastryAmount);
        }
        [TestMethod]
        public void GetPatstryPriceEasy_ReturnsPastryPriceEasy_int()
        {
        int pastryAmount = 6;
        PastryClass newPastry = new PastryClass(pastryAmount);
        Assert.AreEqual(9, newPastry.PastryPrice(6));
        }
        // [TestMethod]
        // public void GetFinalPastryPrice_ReturnsFinalPastryPrice_int()
        // {
        //     Assert.AreEqual(17, PastryClass.pastryPrice(10));
        // }
    }

}