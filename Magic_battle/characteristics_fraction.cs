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
        public int fraction_scatter { get; set; }
        public int fraction_Armor { get; set; }
        public int fraction_avoidance { get; set; }

        public characteristics_fraction(int fraction_Hp, int fraction_PhDmg, int fraction_MagicDmg, string fraction_Name 
            , string fraction_Image, int fraction_Scatter, int fraction_Armor, int fraction_avoidance)
        {
            fraction_Hp_ = fraction_Hp;
            fraction_Ph_Dmg = fraction_PhDmg;
            fraction_Magic_Dmg = fraction_MagicDmg;
            fraction_name = fraction_Name;
            fraction_image = fraction_Image;
            fraction_scatter = fraction_Scatter;
            this.fraction_Armor = fraction_Armor;
            this.fraction_avoidance = fraction_avoidance;
        }
    }

    internal class image_for_battle
    {
        public string im1 { get; set; }
        public string im2 { get; set; }
        public string im3 { get; set; }

        

        public image_for_battle(string Im1, string Im2, string Im3)
        {
            im1 = Im1;
            im2 = Im2;
            im3 = Im3;
            
        }
    }

    internal class points
    {
        public int hp { get; set; }
        public int dmg { get; set; }
        public int magic { get; set; }



        public points(int HP, int DMG, int Magic)
        {
            hp = HP;
            dmg = DMG;
            magic = Magic;

        }
    }

    internal class hero_characteristics
    {
        public int hp { get; set; }
        public int phDmg { get; set; }
        public int magicDmg { get; set; }

        public string name { get; set; }
        public string image { get; set; }
        public int scatter { get; set; }
        public int armor { get; set; }
        public int avoidance { get; set; }

        public hero_characteristics(int Hp, int PhDmg, int MagicDmg, string Name, string Image, int Scatter, int armor, int avoidance)
        {
            hp = Hp;
            phDmg = PhDmg;
            magicDmg = MagicDmg;
            name = Name;
            image = Image;
            scatter = Scatter;
            this.armor = armor;
            this.avoidance = avoidance;
        }
    }
}
