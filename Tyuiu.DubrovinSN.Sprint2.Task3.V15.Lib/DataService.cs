using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DubrovinSN.Sprint2.Task3.V15.Lib
{
    public class DataService : ISprint2Task3V15
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
               y = x + Math.Pow((x + 1) / (x - 1), x);
            }
            else
            {
                if (x == 0)
                {
                    y = (Math.Pow(x, 2) - Math.Pow(Math.Cos(x), 2) + 10) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) + 12);
                }
                else
                {
                    if ((-19 < x) && (x < 2))
                    {
                        y = Math.Pow(1 + (1 / (Math.Pow(x, 2))), 8);
                    }
                        else
                    {
                        if (x < -19)
                        {
                            y = x + 10 * x - (1 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
