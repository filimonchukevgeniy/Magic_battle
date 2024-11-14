using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_battle
{
    public partial class ResearchForm : Form
    {
        public ResearchForm()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void HP_buster1_button_Click(object sender, EventArgs e)
        {
            int prise = 1;
            int fraction = GlobalVariables.hero_fraction_global;
            var researches = GlobalVariables.researches[fraction];
            var points = GlobalVariables.points[fraction];
            if (points.hp >= prise && researches.hp1_boost == 0)
            {
                GlobalVariables.points[fraction].hp = GlobalVariables.points[fraction].hp - prise;
                GlobalVariables.hero_property[fraction].hp = GlobalVariables.hero_property[fraction].hp + 20;
                researches.hp1_boost = 1;
                HP_buster1_button.Enabled = false;
                HP_buster1_button.BackColor = Color.LightSteelBlue;
            }
            else
            {
                HP_buster1_button.Enabled = false;
            }
        }

        

        private void HP_buster2_button_Click(object sender, EventArgs e)
        {
            int prise = 2;
            int fraction = GlobalVariables.hero_fraction_global;
            var researches = GlobalVariables.researches[fraction];
            var points = GlobalVariables.points[fraction];
            if (points.hp >= prise && researches.hp1_boost == 1)
            {
                GlobalVariables.points[fraction].hp = GlobalVariables.points[fraction].hp - prise;
                GlobalVariables.hero_property[fraction].hp = GlobalVariables.hero_property[fraction].hp + 20;
                researches.hp1_boost = 2;
                HP_buster2_button.Enabled = false;
                HP_buster2_button.BackColor = Color.LightSteelBlue;
            }
            else
            {
                HP_buster2_button.Enabled = false;
            }
        }

        private void ResearchForm_Load(object sender, EventArgs e)
        {

        }

        

        

        private void button5_Click(object sender, EventArgs e)
        {
            int prise = 1;
            int fraction = GlobalVariables.hero_fraction_global;
            var researches = GlobalVariables.researches[fraction];
            var points = GlobalVariables.points[fraction];

            if (points.dmg >= prise && researches.phDmg1_boost == 0)
            {
                GlobalVariables.hero_property[fraction].phDmg = GlobalVariables.hero_property[fraction].phDmg + 10;
                GlobalVariables.points[fraction].dmg = GlobalVariables.points[fraction].dmg - prise;
                researches.phDmg1_boost = 1;
                ph_buster1_button.Enabled = false;
                ph_buster1_button.BackColor = Color.LightSteelBlue;
            }
            else
            {
                ph_buster1_button.Enabled = false;
            }
        }

        

        private void select_fraction_button_Click(object sender, EventArgs e)
        {
            int hero_fraction = GlobalVariables.hero_fraction_global;


            if (hero_fraction == 0)
            {
                hero_fraction = 1;
                select_fraction_button.BackgroundImage = Image.FromFile(@"assets\water_element.png");
            }
            else if (hero_fraction == 1)
            {
                hero_fraction = 2;
                select_fraction_button.BackgroundImage = Image.FromFile(@"assets\air_element.png");
            }
            else if (hero_fraction == 2)
            {
                hero_fraction = 3;
                select_fraction_button.BackgroundImage = Image.FromFile(@"assets\earth_element.png");
            }
            else if (hero_fraction == 3)
            {
                hero_fraction = 0;
                select_fraction_button.BackgroundImage = Image.FromFile(@"assets\fire_element.png");
            }
        }
    }
}


