using System;
using System.Text.RegularExpressions;

namespace GOST_55601
{
    class Program
    {
        static void Main()
        {
            //Вызываем для определения группы сосуда
            GOST_34347 fine_group = new GOST_34347();

            Console.WriteLine("Введите расчётное давление");

            fine_group.P = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите расчётную температуру");

            fine_group.T = double.Parse(Console.ReadLine());

            Console.WriteLine("Среда взрывоопасная/пожароопасная/токсичная? (+)");

            string explosive = Console.ReadLine();

            // Если среда взрывоопасная/пожароопасная/токсичная, тогда задаем параметр true
            if (explosive == "+")
            {
                fine_group.explosive = true;
            }
            else
            {
                fine_group.explosive = false;
            }

            // Сосуд находится под вакуумом

            Console.WriteLine("Сосуд под вакуумом? (+)");

            string vacuum = Console.ReadLine();

            if (vacuum == "+")
            {
                fine_group.vacuum = true;
            }
            else
            {
                fine_group.vacuum = false;
            }

            // Выводим данные задачи
            Console.WriteLine("Расчётное давление {0} МПа, расчётная температура {1} C, токсичная: {2}, вакуум: {3}", fine_group.P, fine_group.T, fine_group.explosive, fine_group.vacuum);

            // Вызываем класс для определения группы аппарата по ГОСТ 34347-2017
            fine_group.fine_group();

            fine_group.class_accuracy_GOST_R55601();
            
            Console.ReadLine();

        }
    }
}