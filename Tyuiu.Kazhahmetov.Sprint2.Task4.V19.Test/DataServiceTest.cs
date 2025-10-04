using Tyuiu.Kazhahmetov.Sprint2.Task4.V19.Lib;
namespace Tyuiu.Kazhahmetov.Sprint2.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 6;
            double res = ds.Calculate(x, y);
            double wait = 10;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 10;
            Assert.AreEqual(wait, res);
        }
    }
}
