using Tyuiu.skirnevskyBR.Sprint3.Task5.V29.Lib;
namespace Tyuiu.skirnevskyBR.Sprint3.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;

            double wait = 44.853;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}