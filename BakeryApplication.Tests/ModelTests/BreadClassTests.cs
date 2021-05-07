using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApplication.Models;

namespace BakeryApplication.Tests 
{
    [TestClass]
    public class BreadClassTests
    {
        [TestMethod]
        public void Bread_InstantiateEmptyBreadConstructor_Bread()
        {
        BreadClass newBread = new BreadClass ();
        Assert.AreEqual(typeof(BreadClass), newBread.GetType());
        }
        
    }
}