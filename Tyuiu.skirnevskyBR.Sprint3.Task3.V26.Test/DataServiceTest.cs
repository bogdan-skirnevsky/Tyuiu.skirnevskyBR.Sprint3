using Tyuiu.skirnevskyBR.Sprint3.Task3.V26.Lib;
namespace Tyuiu.skirnevskyBR.Sprint3.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string value = "have a nice time";
            char item = 'e';
            int wait = 3;
            int res = ds.GetCharCount(value, item);
            Assert.AreEqual(wait, res);
        }
    }
}
