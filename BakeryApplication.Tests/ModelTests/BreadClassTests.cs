using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApplication.Models;

namespace BakeryApplication.Tests 
{
    [TestClass]
    public class BreadClassTests
    {
        [TestMethod]
        public void BreadClass_InstantiateEmptyBreadClassConstructor_Bread()
        {
        BreadClass newBread = new BreadClass ();
        Assert.AreEqual(typeof(BreadClass), newBread.GetType());
        }
        // [TestMethod]
        // public void GetBreadCount_ReturnBreadAmount_Int()
        // {
         
        // }
        
    }
}