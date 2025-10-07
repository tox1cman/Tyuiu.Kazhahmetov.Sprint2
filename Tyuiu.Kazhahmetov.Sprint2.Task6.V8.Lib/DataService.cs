using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.Kazhahmetov.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int n, int m)
        {
            string res = $"{n}, {m}";
            if ((m == 2) || (m == 4) || (m == 6) || (m == 8) || (m == 9) || (m == 11))
            {
                switch (n)
                {
                    case 1:
                        n = 31;
                        m = m - 1;
                        break;
                    default:
                        n = n - 1;
                        break;

                }
            }
            else if (m == 3)
            {
                switch (n)
                {
                    case 1:
                        n = 28;
                        m = m - 1;
                        break;
                    default:
                        n = n - 1;
                        break;

                }
            }
            else
            {
                switch (n)
                {
                    case 1:
                        n = 30;
                        m = m - 1;
                        break;
                    default:
                        n = n - 1;
                        break;
                }
            }


            if ((m >= 1) && (m <= 9) && (n >= 1) && (n <= 9))
            {
                return $"0{n}.0{m}";
            }
            else if ((m >= 1) && (m <= 9))
            {
                return $"{n}.0{m}";
            }
            else if ((n >= 1) && (n <= 9))
            {
                return $"0{n}.{m}";
            }
            else
            {
                return $"{n}.{m}";
            }
        }
    }
}
