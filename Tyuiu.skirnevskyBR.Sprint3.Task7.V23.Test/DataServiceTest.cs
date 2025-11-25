using Tyuiu.skirnevskyBR.Sprint3.Task7.V23.Lib;
namespace Tyuiu.skirnevskyBR.Sprint3.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(11, result.Length);


            Assert.AreEqual(0, result[6]); 
          
            foreach (double value in result)
            {
                string stringValue = value.ToString("F2");
                double roundedValue = double.Parse(stringValue);
                Assert.AreEqual(roundedValue, value, 0.001);
            }
        }
    }
}
