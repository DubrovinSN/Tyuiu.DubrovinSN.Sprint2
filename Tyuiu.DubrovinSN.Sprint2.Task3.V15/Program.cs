using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DubrovinSN.Sprint2.Task3.V15.Lib;

namespace Tyuiu.DubrovinSN.Sprint2.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Дубровин С.Н | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Дубровин Степан Николаевич | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
            Console.WriteLine("* с использованием вложенных оператор if-else                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X");
            int x = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции - " + res);

            Console.ReadKey();
        }
    }
}
