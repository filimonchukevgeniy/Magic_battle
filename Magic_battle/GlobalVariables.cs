using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_battle
{
    internal class GlobalVariables
    {
        public static int hero_fraction_global = 0;



        public static List<characteristics_fraction> property = new List<characteristics_fraction>
    {
        new characteristics_fraction(100, 20, 30, "Вогняний маг", @"assets\fire_magic.png"),
        new characteristics_fraction(120, 25, 15, "Водний чарівник", @"assets\water_magic.png"),
        new characteristics_fraction(90, 20, 30, "Повітряний маг", @"assets\air_magic.jpg"),
        new characteristics_fraction(200, 15, 10, "Земляний чарівник", @"assets\earth_magic.jpg"),
        // додавай інших героїв із потрібними параметрами
    };
    }
}
