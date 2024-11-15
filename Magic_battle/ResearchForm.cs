﻿using System;
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
        string properties;
        int prise = 1;
        string type_point = "hp";
        string type_researches = "hp1";
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
            prise = 1;
            type_point = "hp";
            type_researches = "hp1";
            research(HP_buster1_button);
        }

        

        private void HP_buster2_button_Click(object sender, EventArgs e)
        {
            prise = 2;
            type_point = "hp";
            type_researches = "hp2";
            research(HP_buster2_button);
        }

        private void ResearchForm_Load(object sender, EventArgs e)
        {

        }

        

        

        private void button5_Click(object sender, EventArgs e)
        {
            prise = 1;
            type_point = "ph";
            type_researches = "ph1";
            research(ph_buster1_button);
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

        private void research(Button button)
        {

            
            int fraction = GlobalVariables.hero_fraction_global;
            var researches = GlobalVariables.researches[fraction];
            var points = GlobalVariables.points[fraction];

            if (type_point == "hp")
            {
                if(type_researches == "hp1")
                {
                    if (points.hp >= prise && researches.hp1_boost == 0)
                    {
                        GlobalVariables.points[fraction].hp = GlobalVariables.points[fraction].hp - prise;
                        GlobalVariables.hero_property[fraction].hp = GlobalVariables.hero_property[fraction].hp + 10;
                        GlobalVariables.researches[fraction].hp1_boost = 1;
                        button.Enabled = false;
                        button.BackColor = Color.LightSteelBlue;
                    }
                    else
                    {
                        button.Enabled = false;
                    }
                }else if (type_researches == "hp2")
                {
                    if (points.hp >= prise && researches.hp1_boost == 1)
                    {
                        GlobalVariables.points[fraction].hp = GlobalVariables.points[fraction].hp - prise;
                        GlobalVariables.hero_property[fraction].hp = GlobalVariables.hero_property[fraction].hp + 20;
                        GlobalVariables.researches[fraction].hp1_boost = 2;
                        button.Enabled = false;
                        button.BackColor = Color.LightSteelBlue;
                    }
                    else
                    {
                        button.Enabled = false;
                    }
                }
                else if (type_researches == "hp3")
                {
                    if (points.hp >= prise && researches.hp1_boost == 2)
                    {
                        GlobalVariables.points[fraction].hp = GlobalVariables.points[fraction].hp - prise;
                        GlobalVariables.hero_property[fraction].hp = GlobalVariables.hero_property[fraction].hp + 30;
                        GlobalVariables.researches[fraction].hp1_boost = 3;
                        button.Enabled = false;
                        button.BackColor = Color.LightSteelBlue;
                    }
                    else
                    {
                        button.Enabled = false;
                    }
                }


            }else if(type_point == "ph")
            {
                if(type_researches == "ph1")
                {
                    if (points.dmg >= prise && researches.phDmg1_boost == 0)
                    {
                        GlobalVariables.points[fraction].dmg = GlobalVariables.points[fraction].dmg - prise;
                        GlobalVariables.hero_property[fraction].phDmg = GlobalVariables.hero_property[fraction].phDmg + 10;
                        GlobalVariables.researches[fraction].phDmg1_boost = 1;
                        button.Enabled = false;
                        button.BackColor = Color.LightSteelBlue;
                    }
                    else
                    {
                        button.Enabled = false;
                    }
                }else if (type_researches == "ph2")
                {
                    if (points.dmg >= prise && researches.phDmg1_boost == 1)
                    {
                        GlobalVariables.points[fraction].dmg = GlobalVariables.points[fraction].dmg - prise;
                        GlobalVariables.hero_property[fraction].phDmg = GlobalVariables.hero_property[fraction].phDmg + 10;
                        GlobalVariables.researches[fraction].phDmg1_boost = 2;
                        button.Enabled = false;
                        button.BackColor = Color.LightSteelBlue;
                    }
                    else
                    {
                        button.Enabled = false;
                    }
                }
                else if (type_researches == "ph3")
                {
                    if (points.dmg >= prise && researches.phDmg1_boost == 2)
                    {
                        GlobalVariables.points[fraction].dmg = GlobalVariables.points[fraction].dmg - prise;
                        GlobalVariables.hero_property[fraction].phDmg = GlobalVariables.hero_property[fraction].phDmg + 15;
                        GlobalVariables.researches[fraction].phDmg1_boost = 3;
                        button.Enabled = false;
                        button.BackColor = Color.LightSteelBlue;
                    }
                    else
                    {
                        button.Enabled = false;
                    }
                }

            }
            else if (type_point == "mg")
            {
                if (type_researches == "mg1")
                {
                    if (points.magic >= prise && researches.magicDmg1_boost == 0)
                    {
                        GlobalVariables.points[fraction].magic = GlobalVariables.points[fraction].magic - prise;
                        GlobalVariables.hero_property[fraction].magicDmg = GlobalVariables.hero_property[fraction].magicDmg + 10;
                        GlobalVariables.researches[fraction].magicDmg1_boost = 1;
                        button.Enabled = false;
                        button.BackColor = Color.LightSteelBlue;
                    }
                    else
                    {
                        button.Enabled = false;
                    }
                }
                else if (type_researches == "mg2")
                {
                    if (points.magic >= prise && researches.magicDmg1_boost == 1)
                    {
                        GlobalVariables.points[fraction].magic = GlobalVariables.points[fraction].magic - prise;
                        GlobalVariables.hero_property[fraction].magicDmg = GlobalVariables.hero_property[fraction].magicDmg + 20;
                        GlobalVariables.researches[fraction].magicDmg1_boost = 2;
                        button.Enabled = false;
                        button.BackColor = Color.LightSteelBlue;
                    }
                    else
                    {
                        button.Enabled = false;
                    }
                }
                else if (type_researches == "mg3")
                {
                    if (points.magic >= prise && researches.magicDmg1_boost == 2)
                    {
                        GlobalVariables.points[fraction].magic = GlobalVariables.points[fraction].magic - prise;
                        GlobalVariables.hero_property[fraction].magicDmg = GlobalVariables.hero_property[fraction].magicDmg + 20;
                        GlobalVariables.researches[fraction].magicDmg1_boost = 3;
                        button.Enabled = false;
                        button.BackColor = Color.LightSteelBlue;
                    }
                    else
                    {
                        button.Enabled = false;
                    }
                }

            }




        }

        private void ph_buster2_button_Click(object sender, EventArgs e)
        {
            prise = 2;
            type_point = "ph";
            type_researches = "ph2";
            research(ph_buster2_button);
        }

        private void magic1_Click(object sender, EventArgs e)
        {
            prise = 1;
            type_point = "mg";
            type_researches = "mg1";
            research(magic1);
        }

        private void magic2_Click(object sender, EventArgs e)
        {
            prise = 2;
            type_point = "mg";
            type_researches = "mg2";
            research(magic2);
        }

        private void Ph3_Click(object sender, EventArgs e)
        {
            prise = 4;
            type_point = "ph";
            type_researches = "ph3";
            research(Ph3);
        }

        private void Magic3_Click(object sender, EventArgs e)
        {
            prise = 4;
            type_point = "mg";
            type_researches = "mg3";
            research(Magic3);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            prise = 4;
            type_point = "hp";
            type_researches = "hp3";
            research(button11);
        }
    }
}


