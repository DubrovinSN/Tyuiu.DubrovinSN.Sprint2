using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DubrovinSN.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((x <= y) && (y <= 2 - x*x)) || ((x >= 0) && (y >= 0) && (2 - x*x >= y) && (x >= y)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
