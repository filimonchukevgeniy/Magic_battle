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
        new characteristics_fraction(100, 20, 40, "Вогняний маг", @"assets\fire_magic.png", 20),
        new characteristics_fraction(120, 25, 15, "Водний чарівник", @"assets\water_magic.png", 5),
        new characteristics_fraction(90, 20, 35, "Повітряний маг", @"assets\air_magic.jpg", 30),
        new characteristics_fraction(200, 15, 10, "Земляний чарівник", @"assets\earth_magic.jpg", 5),
        // додавай інших героїв із потрібними параметрами
    };

        public static List<hero_characteristics> hero_property = new List<hero_characteristics>
    {
        new hero_characteristics(100, 20, 40, "Вогняний маг", @"assets\fire_magic.png", 20),
        new hero_characteristics(120, 25, 15, "Водний чарівник", @"assets\water_magic.png", 5),
        new hero_characteristics(90, 20, 35, "Повітряний маг", @"assets\air_magic.jpg", 30),
        new hero_characteristics(200, 15, 10, "Земляний чарівник", @"assets\earth_magic.jpg", 5),
        // додавай інших героїв із потрібними параметрами
    };

        public static List<Researches> researches = new List<Researches>
    {
        new Researches(0,0,0,0,0,0),
        new Researches(0,0,0,0,0,0),
        new Researches(0,0,0,0,0,0),
        new Researches(0,0,0,0,0,0),
        // додавай інших героїв із потрібними параметрами
    };
    }
}
