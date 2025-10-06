using Tyuiu.Kazhahmetov.Sprint2.Task6.V8.Lib;
namespace Tyuiu.Kazhahmetov.Sprint2.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int m = 10;
            int n = 1;
            string res = ds.FindDateOfPreviousDay(m, n);
            string wait = "30.09";
            Assert.AreEqual(wait, res);
        }
    }
}
