using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOST_55601
{
    class Date
    {
        public double P, T;
        public bool explosive;
        public bool vacuum;
        //Группа сосуда фактическая по ГОСТ 34347
        public int group_gost_34347;
        // Группа сосуда расчётная по ГОСТ 34347
       // public int group;
        //Класс точности
        public int class_accuracy;
    }
}
