using System;
using System.Text.RegularExpressions;

namespace GOST_55601
{
    class Program
    {
        static void Main()
        {
            //Вводим переменные Р - расчётное давление, Т - расчетная температура
            double P, T;

            //Для определения данных
            string text;

            //Вводим характеристики сред (взрывоопасная, токсичная, вакуум);
            bool explosive, toxic, vacuum;


            //Группа ГОСТа
            int group_GOST;

            //Вводим условия задачи

            Console.WriteLine("Введите расчётное давление");

            P = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите расчётную температуру");

            T = double.Parse(Console.ReadLine());


            Console.WriteLine("Среда взрывоопасная? (+)");

            text = Console.ReadLine();

            if (text=="+") {
                explosive = true;
                toxic = true;
                Console.WriteLine("Среда взрывоопасная");
            }
            else
            {
                explosive = false;
                toxic = false;
                Console.WriteLine("Среда не взрывоопасная");
            }

            Console.WriteLine("Расчётное давление: {0}, расчётная температура: {1} C,", P, T);

            if (explosive == true)
            {
                Console.WriteLine("Группа 1 по ГОСТ 34347-2017");
            }
            else if (explosive == false && 0.05 <= P && P <= 2.5 && T > 400)
            {
                Console.WriteLine("Группа 2.1 по ГОСТ 34347-2017");
            }
            else if (explosive == false && 2.5 < P && P >= 5 && T > 200)
            {
                Console.WriteLine("Группа 2.2 по ГОСТ 34347-2017");
            }
            else if (explosive == false && P > 5)
            {
                Console.WriteLine("Группа 2.3 по ГОСТ 34347-2017");
            }
            else if (explosive == false && 0.05 <= P && P >= 5 && T < -40)
            {
                Console.WriteLine("Группа 2.4 по ГОСТ 34347-2017");
            }
            else if (explosive == false && P >= 0.05 && P <= 2.5 && T > -40 && T <= 400)
            {
                Console.WriteLine("Группа 3.1 ГОСТ 34347-2017");
            }
            else if (explosive == false && P > 2.5 && P < 5 && T > -40 && T < 200)
            {
                Console.WriteLine("Группа 3.2 ГОСТ 34347-2017");
            }
            else if (explosive == false && P > 0.05 && P <= 1.6 && T > -20 && T < 200)
            {
                Console.WriteLine("Группа 4 ГОСТ 34347-2017");
            }
            else
            {
                Console.WriteLine("Не определил группу");
            }


        }
    }
}