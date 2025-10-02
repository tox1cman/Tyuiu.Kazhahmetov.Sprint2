using Tyuiu.Kazhahmetov.Sprint2.Task2.V11.Lib;
namespace Tyuiu.Kazhahmetov.Sprint2.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCoordinate()
        {
            DataService ds = new DataService();
            int x = 7;
            int y = 6;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
