using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.Kazhahmetov.Sprint2.Task3.V12.Lib
{
    public class DataService : ISprint2Task3V12
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                return Math.Round(y =( x + Math.Pow(((x + 1) / (x - 1)), x)), 3);
            }
            else if (x == 0)
            {
                return Math.Round(y = (1 + Math.Cos(Math.Sqrt(x + 1))), 3);
            }
            else if ((-16 < x) && (x < 2))
            {
                return Math.Round(y = (Math.Pow((7 + (5 / x * x)), x)), 3);
            }
            else 
            {
                return Math.Round(y = (x + 10 * x - (1 / x)), 3);
            }
        }
    }
}
