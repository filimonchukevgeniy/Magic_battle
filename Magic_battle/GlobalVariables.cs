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
        public static int hero_HP_poin = 0;
        public static int hero_Ph_poin = 0;
        public static int hero_Mg_poin = 0;
        public static int enemy_generat_number = 2;
        public static int reseived_dmg = 0;
        public static int done_ph_dmg = 0;
        public static int done_mg_dmg = 0;
        public static int experience = 0;
        public static int k = 1;
        


        public static List<characteristics_fraction> property = new List<characteristics_fraction>
    {
        new characteristics_fraction(100, 20, 40, "Вогняний маг", @"assets\fire_magic.png", 20, 0, 0),
        new characteristics_fraction(120, 25, 15, "Водний чарівник", @"assets\water_magic.png", 5, 0, 0),
        new characteristics_fraction(90, 20, 35, "Повітряний маг", @"assets\air_magic.jpg", 30, 0, 5),
        new characteristics_fraction(200, 15, 10, "Земляний чарівник", @"assets\earth_magic.jpg", 5 , 5, 0),
        // додавай інших героїв із потрібними параметрами
    };

        public static List<hero_characteristics> hero_property = new List<hero_characteristics>
    {
        new hero_characteristics(100, 20, 40, "Вогняний маг", @"assets\fire_magic.png", 20, 0, 0),
        new hero_characteristics(120, 25, 15, "Водний чарівник", @"assets\water_magic.png", 5, 0, 0),
        new hero_characteristics(90, 20, 35, "Повітряний маг", @"assets\air_magic.jpg", 30, 0, 5),
        new hero_characteristics(200, 15, 10, "Земляний чарівник", @"assets\earth_magic.jpg", 5, 5, 0),
        // додавай інших героїв із потрібними параметрами
    };

        public static List<Researches> researches = new List<Researches>
    {
        new Researches(0,0,0,0,0,0,0),
        new Researches(0,0,0,0,0,0,0),
        new Researches(0,0,0,0,0,0,0),
        new Researches(0,0,0,0,0,0,0),
        // додавай інших героїв із потрібними параметрами
    };
        public static List<image_for_battle> Image_for_battle = new List<image_for_battle>
    {
        
        new image_for_battle(@"assets\Sword_0.png",@"assets\Sword_1.png",@"assets\Sword_2.png"),
        new image_for_battle(@"assets\magic_0.png",@"assets\magic_1.png",@"assets\magic_2.png"),
        new image_for_battle(@"assets\miss.png",@"assets\miss.png",@"assets\miss.png")
        // додавай інших героїв із потрібними параметрами
    };
        public static List<points> points = new List<points>
    {
        new points(0,0,0),
        new points(0,0,0),
        new points(0,0,0),
        new points(0,0,0)
    };

    }
}
