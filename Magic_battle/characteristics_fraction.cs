using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_battle
{

    internal class characteristics_fraction
    {
        public int fraction_Hp_ { get; set; }
        public int fraction_Ph_Dmg { get; set; }
        public int fraction_Magic_Dmg { get; set; }

        public string fraction_name { get; set; }
        public string fraction_image { get; set; }

        public characteristics_fraction(int fraction_Hp, int fraction_PhDmg, int fraction_MagicDmg, string fraction_Name , string fraction_Image)
        {
            fraction_Hp_ = fraction_Hp;
            fraction_Ph_Dmg = fraction_PhDmg;
            fraction_Magic_Dmg = fraction_MagicDmg;
            fraction_name = fraction_Name;
            fraction_image = fraction_Image;
        }
    }
}
