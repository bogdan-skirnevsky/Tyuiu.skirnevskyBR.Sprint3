using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.skirnevskyBR.Sprint3.Task6.V9.Lib
{
    public class DataService : ISprint3Task6V9
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalDivisorsCount = 0;

            for (int num = startValue; num <= stopValue; num++)
            {
                int divisorsCount = 0;

                for (int divisor = 1; divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        divisorsCount++;
                    }
                }

                totalDivisorsCount += divisorsCount;
            }

            return totalDivisorsCount;
        }
    }
}

