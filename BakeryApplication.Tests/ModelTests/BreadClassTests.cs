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
        
    }
}