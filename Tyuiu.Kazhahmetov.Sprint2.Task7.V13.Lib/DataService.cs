using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.Kazhahmetov.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (((y <= 1) && (y >= x - 1) && (x >= 0)) || ((x * x + y * y <= 1) && (x >= 0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
