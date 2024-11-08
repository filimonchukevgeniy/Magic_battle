﻿using Newtonsoft.Json.Linq;
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
    public partial class LVL_1 : Form
    {

        private Random _random = new Random();
        private Random _random_scatter = new Random();
        int hero_hp = 100;
        int hero_physical_dmg = 10;
        int hero_magic_dmg = 15;
        int enemy_hp = 800;
        int enemy_physical_dmg = 7;
        int enemy_magic_dmg = 15;
        private int hero_fraction;
        
        private int enemy_generat_number = 2;
        private string enemy_fraction = "";
        double scatter = 0;
        int random_scatter;

        int value = GlobalVariables.hero_fraction_global; // Отримати значення

        public LVL_1()
        {
            InitializeComponent();
            



        }
        
        

        private void battle1_Load(object sender, EventArgs e)
        {
            int enemy_generat_number = GenerateRandomFraction();


            hero_fraction = GlobalVariables.hero_fraction_global;
            ////////////////////////////////////////////////////////////////////
            /// створення головного персонажу і заповнення його статистики
            var hero = GlobalVariables.hero_property[hero_fraction];
            hero_hp = hero.hp;
            hero_physical_dmg = hero.phDmg;
            hero_magic_dmg = hero.magicDmg;
            hero_hp_result_label.Text = hero_hp.ToString();
            hero_ph_dmg_result_label.Text = hero_physical_dmg.ToString();
            hero_magic_dmg_result_label.Text = hero_magic_dmg.ToString();
            hero_name_label.Text = hero.name.ToString();
            hero_image.BackgroundImage = Image.FromFile(hero.image);
            hero_scatter_label.Text = hero.scatter.ToString() + "%";
            /////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////
            /// створення персонажа ворога і заповнення статів в грі
            var enemy = GlobalVariables.property[enemy_generat_number];
            enemy_hp = enemy.fraction_Hp_;
            enemy_physical_dmg = enemy.fraction_Ph_Dmg;
            enemy_magic_dmg = enemy.fraction_Magic_Dmg;
            enemy_hp_label.Text = enemy.fraction_Hp_.ToString();
            enemy_ph_dmg_result_label.Text = enemy.fraction_Ph_Dmg.ToString();
            enemy_magic_dmg_result_label.Text = enemy.fraction_Magic_Dmg.ToString();
            enemy_name_label.Text = enemy.fraction_name.ToString();
            enemy_image.BackgroundImage = Image.FromFile(enemy.fraction_image);
            hero_scatter_label.Text = enemy.fraction_scatter.ToString() + "%";
            ////////////////////////////////////////////////////////////////////////





        }

        private void button1_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////
            random_scatter = GenerateRandomScatterPH_hero();
            enemy_hp = enemy_hp - hero_physical_dmg - random_scatter;       // фізичний урон по ворогу
            enemy_hp_label.Text = enemy_hp.ToString();
            //////////////////////////////////////////////////////////////
            
            //////////////////////////////////////////////////////////////
            random_scatter = GenerateRandomScatterPH_enemy();

            hero_hp = hero_hp - enemy_physical_dmg - random_scatter;         // фізичний урон по герою
            hero_hp_result_label.Text = hero_hp.ToString();
            //////////////////////////////////////////////////////////////
            
            //////////////////////////////////////////////////////////////
            if (hero_hp < 1)
            {
                Defeat form2 = new Defeat();
                form2.Show();
                this.Hide();
            }else if (enemy_hp < 1)                                           // Перевірка Hp гравця і ворога
            {
                Win form2 = new Win();
                form2.Show();
                this.Hide();
            }
            //////////////////////////////////////////////////////////////
        }

        private void button2_Click(object sender, EventArgs e)
        {
            random_scatter = GenerateRandomScatterPH_hero();

            enemy_hp = enemy_hp - hero_magic_dmg - random_scatter;
            enemy_hp_label.Text = enemy_hp.ToString();

            random_scatter = GenerateRandomScatterPH_hero();

            hero_hp = hero_hp - enemy_magic_dmg - random_scatter;
            hero_hp_result_label.Text = hero_hp.ToString();
            if (hero_hp < 1)
            {
                Defeat form2 = new Defeat();
                form2.Show();
                this.Hide();
            }else if (enemy_hp < 1)
            {
                Win form2 = new Win();
                form2.Show();
                this.Hide();
            }
        }
        private int GenerateRandomFraction()
        {
            return _random.Next(0, 3); // Генерує число фракції ворога
        }

        private int GenerateRandomScatterPH_hero()
        {
            hero_fraction = GlobalVariables.hero_fraction_global;
            var hero = GlobalVariables.property[hero_fraction];

            double scatter = (hero.fraction_scatter * hero.fraction_Ph_Dmg) / 100;
            int a = (int)Math.Round(scatter);
            return _random_scatter.Next(-a, a); // Генерує число розбросу урона
        }

        private int GenerateRandomScatterPH_enemy()
        {

            var hero = GlobalVariables.property[enemy_generat_number];

            double scatter = (hero.fraction_scatter * hero.fraction_Ph_Dmg) / 100;
            int a = (int)Math.Round(scatter);
            return _random_scatter.Next(-a, a); // Генерує число розбросу урона
        }

        private int GenerateRandomScatterMagic_hero()
        {
            hero_fraction = GlobalVariables.hero_fraction_global;
            var hero = GlobalVariables.property[hero_fraction];

            double scatter = (hero.fraction_scatter * hero.fraction_Magic_Dmg) / 100;
            int a = (int)Math.Round(scatter);
            return _random_scatter.Next(-a, a); // Генерує число розбросу урона
        }

        private int GenerateRandomScatterMagic_enemy()
        {

            var hero = GlobalVariables.property[enemy_generat_number];

            double scatter = (hero.fraction_scatter * hero.fraction_Magic_Dmg) / 100;
            int a = (int)Math.Round(scatter);
            return _random_scatter.Next(-a, a); // Генерує число розбросу урона
        }
    }
}
