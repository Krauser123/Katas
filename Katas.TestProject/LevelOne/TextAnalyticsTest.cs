using Katas.LevelOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.TestProject.LevelOne
{
    [TestClass]
    public class TextAnalyticsTest
    {
        [TestMethod]
        public void IsTextAnalyticsRight()
        {
            TextAnalytics textAnalytics = new TextAnalytics();
            textAnalytics.StartAnalyze();
            Assert.IsTrue(false);
        }
    }
}
