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
        PastryClass newPastry = new PastryClass ();
        Assert.AreEqual(typeof(PastryClass), newPastry.GetType());
        }
        [TestMethod]
        public void GetPastryPrice_ReturnPastryPrice_int()
        {
        Assert.AreEqual(2, PastryClass.pastryPrice(1));
        }
    }

}