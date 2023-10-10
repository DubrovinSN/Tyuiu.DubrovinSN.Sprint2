using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DubrovinSN.Sprint2.Task6.V5.Lib;

namespace Tyuiu.DubrovinSN.Sprint2.Task6.V5
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Дубровин Степан Николаевич | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По заданному номеру карты k (6 <= k <= 14) определить достоинство       *");
            Console.WriteLine("* соответствующей карты. валету» — 11, «даме» — 12, «королю» — 13,        *");
            Console.WriteLine("* «тузу»—14. Порядковые номера остальных карт соответствуют их названиям. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите порядковый номер карты");
            int value = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindCardValue(value);

            if ((value < 6) || (value > 14))
            {
                res = "Введен неверный порядковый номер";
            }
            else
            {
                res = "Достонство соответствующей карты " + ds.FindCardValue(value);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();


        }
    }
}
