using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DubrovinSN.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < d + 1000) & (c > b);
            res[1] = (a == b) | (c != d);
            res[2] = !(!res[0]);
            res[3] = (a <= b) ^ (c >= d);
            res[4] = (a + 17 == b) || (d * 3 > c);
            res[5] = (Math.Pow(a, 2) < b) && (c - 737 == d);
            return res;
        }
    }
}
