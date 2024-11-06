using Newtonsoft.Json.Linq;
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

        int hero_hp = 100;
        int hero_physical_dmg = 10;
        int hero_magic_dmg = 15;
        int enemy_hp = 800;
        int enemy_physical_dmg = 7;
        int enemy_magic_dmg = 15;
        private int hero_fraction;
        
        private int enemy_generat_number = 2;
        private string enemy_fraction = "";

        int value = GlobalVariables.hero_fraction_global; // Отримати значення

        public LVL_1()
        {
            InitializeComponent();
            



        }
        private int GenerateRandomFraction()
        {
            return _random.Next(0, 3); // Генерує число від 0 до 10 включно
        }

        private void battle1_Load(object sender, EventArgs e)
        {
            int enemy_generat_number = GenerateRandomFraction();

            enemy_hp_label.Text = enemy_hp.ToString();
            hero_hp_result_label.Text = hero_hp.ToString();
            enemy_ph_dmg_result_label.Text = enemy_physical_dmg.ToString();
            enemy_magic_dmg_result_label.Text = enemy_magic_dmg.ToString();
            enemy_hp_label.Text = _random.ToString();


            hero_fraction = GlobalVariables.hero_fraction_global;
            if(hero_fraction == 0)
            {
                var hero = GlobalVariables.property[0];
                hero_hp = hero.fraction_Hp_;
                hero_physical_dmg = hero.fraction_Ph_Dmg;
                hero_magic_dmg = hero.fraction_Magic_Dmg;
                hero_hp_result_label.Text = hero.fraction_Hp_.ToString();
                hero_ph_dmg_result_label.Text = hero.fraction_Ph_Dmg.ToString();
                hero_magic_dmg_result_label.Text = hero.fraction_Magic_Dmg.ToString();
                hero_name_label.Text = hero.fraction_name.ToString();
                hero_image.BackgroundImage = Image.FromFile(hero.fraction_image);

                
            }else if (hero_fraction == 1)
            {
                var hero = GlobalVariables.property[1];
                hero_hp = hero.fraction_Hp_;
                hero_physical_dmg = hero.fraction_Ph_Dmg;
                hero_magic_dmg = hero.fraction_Magic_Dmg;
                hero_hp_result_label.Text = hero.fraction_Hp_.ToString();
                hero_ph_dmg_result_label.Text = hero.fraction_Ph_Dmg.ToString();
                hero_magic_dmg_result_label.Text = hero.fraction_Magic_Dmg.ToString();
                hero_name_label.Text = hero.fraction_name.ToString();
                hero_image.BackgroundImage = Image.FromFile(hero.fraction_image);
            }
            else if (hero_fraction == 2)
            {
                var hero = GlobalVariables.property[2];
                hero_hp = hero.fraction_Hp_;
                hero_physical_dmg = hero.fraction_Ph_Dmg;
                hero_magic_dmg = hero.fraction_Magic_Dmg;
                hero_hp_result_label.Text = hero.fraction_Hp_.ToString();
                hero_ph_dmg_result_label.Text = hero.fraction_Ph_Dmg.ToString();
                hero_magic_dmg_result_label.Text = hero.fraction_Magic_Dmg.ToString();
                hero_name_label.Text = hero.fraction_name.ToString();
                hero_image.BackgroundImage = Image.FromFile(hero.fraction_image);
            }
            else if (hero_fraction == 3)
            {
                var hero = GlobalVariables.property[3];
                hero_hp = hero.fraction_Hp_;
                hero_physical_dmg = hero.fraction_Ph_Dmg;
                hero_magic_dmg = hero.fraction_Magic_Dmg;
                hero_hp_result_label.Text = hero.fraction_Hp_.ToString();
                hero_ph_dmg_result_label.Text = hero.fraction_Ph_Dmg.ToString();
                hero_magic_dmg_result_label.Text = hero.fraction_Magic_Dmg.ToString();
                hero_name_label.Text = hero.fraction_name.ToString();
                hero_image.BackgroundImage = Image.FromFile(hero.fraction_image);
            }


            


            if (enemy_generat_number == 0)
            {
                var enemy = GlobalVariables.property[0];
                enemy_hp = enemy.fraction_Hp_;
                enemy_physical_dmg = enemy.fraction_Ph_Dmg;
                enemy_magic_dmg = enemy.fraction_Magic_Dmg;
                enemy_hp_label.Text = enemy.fraction_Hp_.ToString();
                enemy_ph_dmg_result_label.Text = enemy.fraction_Ph_Dmg.ToString();
                enemy_magic_dmg_result_label.Text = enemy.fraction_Magic_Dmg.ToString();
                enemy_name_label.Text = enemy.fraction_name.ToString();
                enemy_image.BackgroundImage = Image.FromFile(enemy.fraction_image);

            }
            else if(enemy_generat_number == 1)
            {
                var enemy = GlobalVariables.property[1];
                enemy_hp = enemy.fraction_Hp_;
                enemy_physical_dmg = enemy.fraction_Ph_Dmg;
                enemy_magic_dmg = enemy.fraction_Magic_Dmg;
                enemy_hp_label.Text = enemy.fraction_Hp_.ToString();
                enemy_ph_dmg_result_label.Text = enemy.fraction_Ph_Dmg.ToString();
                enemy_magic_dmg_result_label.Text = enemy.fraction_Magic_Dmg.ToString();
                enemy_name_label.Text = enemy.fraction_name.ToString();
                enemy_image.BackgroundImage = Image.FromFile(enemy.fraction_image);
            }
            else if (enemy_generat_number == 2)
            {
                var enemy = GlobalVariables.property[2];
                enemy_hp = enemy.fraction_Hp_;
                enemy_physical_dmg = enemy.fraction_Ph_Dmg;
                enemy_magic_dmg = enemy.fraction_Magic_Dmg;
                enemy_hp_label.Text = enemy.fraction_Hp_.ToString();
                enemy_ph_dmg_result_label.Text = enemy.fraction_Ph_Dmg.ToString();
                enemy_magic_dmg_result_label.Text = enemy.fraction_Magic_Dmg.ToString();
                enemy_name_label.Text = enemy.fraction_name.ToString();
                enemy_image.BackgroundImage = Image.FromFile(enemy.fraction_image);

            }
            else if (enemy_generat_number == 3)
            {
                var enemy = GlobalVariables.property[3];
                enemy_hp = enemy.fraction_Hp_;
                enemy_physical_dmg = enemy.fraction_Ph_Dmg;
                enemy_magic_dmg = enemy.fraction_Magic_Dmg;
                enemy_hp_label.Text = enemy.fraction_Hp_.ToString();
                enemy_ph_dmg_result_label.Text = enemy.fraction_Ph_Dmg.ToString();
                enemy_magic_dmg_result_label.Text = enemy.fraction_Magic_Dmg.ToString();
                enemy_name_label.Text = enemy.fraction_name.ToString();
                enemy_image.BackgroundImage = Image.FromFile(enemy.fraction_image);

            }

        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            enemy_hp = enemy_hp - hero_physical_dmg;
            enemy_hp_label.Text = enemy_hp.ToString();
            
            hero_hp = hero_hp - enemy_physical_dmg;
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

        private void button2_Click(object sender, EventArgs e)
        {
            enemy_hp = enemy_hp - hero_magic_dmg;
            enemy_hp_label.Text = enemy_hp.ToString();
            if (enemy_hp < 1)
            {
                Win form2 = new Win();
                form2.Show();
                this.Hide();
            }
            hero_hp = hero_hp - enemy_magic_dmg;
            hero_hp_result_label.Text = hero_hp.ToString();
            if (hero_hp < 1)
            {
                Defeat form2 = new Defeat();
                form2.Show();
                this.Hide();
            }
        }
    }
}
