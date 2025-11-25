using Tyuiu.skirnevskyBR.Sprint3.Task6.V9.Lib;
namespace Tyuiu.skirnevskyBR.Sprint3.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 19;
            int stopValue = 30;

            int wait = 53;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
