﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.Kazhahmetov.Sprint2.Task2.V11.Lib
{
    public class DataService : ISprint2Task2V11
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (((x >= 3) && (x <= 5) && (y >= 3) && (y <= 4)) || ((x >= 6) && (x <= 9) && (y >= 5) && (y <= 10)) || ((x >= 11) && (x <= 12) && (y >= 5) && (y <= 11)) || ((x >= 2) && (x <= 5) && (x == 7)) || ((x >= 3) && (x <= 5) && (y == 11)) || ((x == 7) && (y == 12)) || ((x == 9) && (y >= 3) && (y <= 4)) || ((x == 10) && (y >= 8) && (y <= 10)) || ((x == 13) && (y == 8)))
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
    