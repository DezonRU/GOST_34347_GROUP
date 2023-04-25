using System;
using System.Text.RegularExpressions;
// Добавил на переменные P, T чтобы предотварить ошибку закрывания программы
using System.Globalization;

namespace GOST_55601
{
    class Program
    {
        static void Main()
        {
            //Вызываем для определения группы сосуда
            GOST_34347 fine_group = new GOST_34347();

            // Вводим переменную для повторого выполнения задания программы
            bool replay;

            // Версия программы
            Console.WriteLine("Версия программы: " + fine_group.vesion + " Автор: Мухновский В.А.");

            // Цикл повтора программы при условии replay = true
            do
            {

                Console.WriteLine("Введите расчётное давление");

                fine_group.P = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Введите расчётную температуру");

                fine_group.T = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

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

                // Спрашиваем пользователя о повтором запуске программы
                Console.WriteLine("Повторить? (+)");

                string replay_text = Console.ReadLine();

                if (replay_text == "+")
                {
                    replay = true;
                }
                else
                {
                    replay = false;
                }
            }
            // Условие повторения цикла, при replay==false программа завершается
            while (replay==true);

            Console.ReadLine();
        }
    }
}