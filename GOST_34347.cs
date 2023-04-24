using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GOST_55601
{
    // Класс наследник Date
    class GOST_34347 : Date
    {
        // Метод определения группы сосуда по ГОСТ 34347-2017 (Таблица  1)
        public void fine_group()
        {
            if (explosive == true)
            {
                group_gost_34347 = 1;
                Console.WriteLine("Группа 1 по ГОСТ 34347-2017");
            }
            else if (explosive == false && 0.05 <= P && P <= 2.5 && T > 400)
            {
                group_gost_34347 = 2;
                Console.WriteLine("Группа 2.1 по ГОСТ 34347-2017");
            }
            else if (explosive == false && 2.5 < P && P >= 5 && T > 200)
            {
                group_gost_34347 = 2;
                Console.WriteLine("Группа 2.2 по ГОСТ 34347-2017");
            }
            else if (explosive == false && P > 5)
            {
                group_gost_34347 = 2;
                Console.WriteLine("Группа 2.3 по ГОСТ 34347-2017");
            }
            else if (explosive == false && 0.05 <= P && P >= 5 && T < -40)
            {
                group_gost_34347 = 2;
                Console.WriteLine("Группа 2.4 по ГОСТ 34347-2017");
            }
            else if (explosive == false && P >= 0.05 && P <= 1.6 && T > -20 && T < 200)
            {
                group_gost_34347 = 4;
                Console.WriteLine("Группа 4 ГОСТ 34347-2017");
            }
            else if (explosive == false && P >= 0.05 && P <= 2.5 && T > -40 && T <= 400)
            {
                group_gost_34347 = 3;
                Console.WriteLine("Группа 3.1 ГОСТ 34347-2017");
            }
            else if (explosive == false && P > 2.5 && P < 5 && T > -40 && T < 200)
            {
                group_gost_34347 = 3;
                Console.WriteLine("Группа 3.2 ГОСТ 34347-2017");
            }
            else
            {
                group_gost_34347 = 0;
                Console.WriteLine("Не определил группу");
            }

        }
        // В данном методе мы определяем класс точности по ГОСТ Р55601
        public void class_accuracy_GOST_R55601()
        {
            // Если группа сосуда 1, то выбираем по расчётным параметрам
            if (group_gost_34347 == 1)
            {
                explosive = false;
                fine_group();
            
                switch (group_gost_34347) 
                { 
                    case 2: class_accuracy = 1;
                        break;
                    case 3: class_accuracy = 2;
                        break;
                    case 4: class_accuracy = 3;
                        break;
                }  
            }
            else if (group_gost_34347 == 2)
            {
                class_accuracy = 2;
            }
            else if (group_gost_34347 == 3)
            {
                class_accuracy = 3;
            }
            else if(group_gost_34347 == 4)
            {
                class_accuracy = 4;
            }
            Console.WriteLine("Класс точности: {0}", class_accuracy);
        }
    }
    
}
