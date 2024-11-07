using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_battle
{
    internal class hero_characteristics
    {
        public int hp { get; set; }
        public int phDmg { get; set; }
        public int magicDmg { get; set; }

        public string name { get; set; }
        public string image { get; set; }
        public int scatter { get; set; }

        public hero_characteristics(int Hp, int PhDmg, int MagicDmg, string Name, string Image, int Scatter)
        {
            hp = Hp;
            phDmg = PhDmg;
            magicDmg = MagicDmg;
            name = Name;
            image = Image;
            scatter = Scatter;
        }
    }
}

