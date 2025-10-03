using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.Kazhahmetov.Sprint2.Task3.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            int k = y;
            int j = x;

            
            if (x > 1)
            {
                return y = x + Math.Pow(((x + 1) / (x - 1)), x);
            }
            else if (x == 0)
            {
                return y = 1 + Math.Cos(Math.Sqrt(x + 1));
            }
            else if ((-16 < x) && (x < 2))
            {
                return y = Math.Pow((7 + (5 / x * x)), x);
            }
            else
            {
                return y = x + 10 * x - (1 / x);
            }
        }
    }
}
