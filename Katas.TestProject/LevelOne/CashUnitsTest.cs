using Katas.LevelOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.TestProject.LevelOne
{
    [TestClass]
    public class CashUnitsTest
    {
        [TestMethod]
        public void IsQuantityExact()
        {
            CashUnits cashUnits = new CashUnits();
            cashUnits.CashUnitCalc(1000);
            Assert.IsTrue(false);
        }
    }    
}
