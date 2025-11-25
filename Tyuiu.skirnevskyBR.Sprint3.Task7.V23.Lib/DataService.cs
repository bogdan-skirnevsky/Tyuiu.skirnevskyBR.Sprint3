using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.skirnevskyBR.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23

    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] resultArray = new double[length];

            for (int x = startValue, index = 0; x <= stopValue; x++, index++)
            {
                if (2 * x - 2 == 0)
                {
                    resultArray[index] = 0;
                }
                else
                {
                    double numerator = 2 + Math.Cos(x);
                    double denominator = 2 * x - 2;
                    double fraction = numerator / denominator;
                    double functionValue = 4 - 2 * x + fraction;
                    resultArray[index] = Math.Round(functionValue, 2);
                }
            }

            return resultArray;
        }
    }
}