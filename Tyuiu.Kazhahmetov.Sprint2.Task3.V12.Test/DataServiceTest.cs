using Tyuiu.Kazhahmetov.Sprint2.Task3.V12.Lib;
namespace Tyuiu.Kazhahmetov.Sprint2.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 11;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.54;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.54;
            Assert.AreEqual(wait, res);

        }
    }
}
