using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_battle
{
    internal class Researches
    {

        public int hp1_boost { get; set; }
        public int phDmg1_boost { get; set; }
        public int magicDmg1_boost { get; set; }

        public int scatter1_boost { get; set; }
        public int armor1_boost { get; set; }
        public int avoidance1_boost { get; set; }

        public Researches(int Hp1, int PhDmg1, int MagicDmg1, int scatter1, int armor1, int avoidance)
        {
            hp1_boost = Hp1;
            phDmg1_boost = PhDmg1;
            magicDmg1_boost = MagicDmg1;
            scatter1_boost = scatter1;
            armor1_boost = armor1;
            avoidance1_boost = avoidance;
        }

    }
}
