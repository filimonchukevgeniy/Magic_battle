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
        private Random _random_scatter = new Random();
        int hero_hp;
        int hero_physical_dmg;
        int hero_magic_dmg;
        int enemy_hp;
        int enemy_physical_dmg;
        int enemy_magic_dmg;
        private int hero_fraction;
        
        private int enemy_generat_number = 2;
        private string enemy_fraction = "";
        double scatter = 0;
        int random_scatter;


        private Timer timer;
        private string imageIndex = "im1";
        private int cycleCount = 0;
        int image_type = 0;
        int image_type2 = 0;
        int dmg_indicator = 0;


        int value = GlobalVariables.hero_fraction_global; // Отримати значення

        public LVL_1()
        {
            InitializeComponent();


            timer = new Timer();
            timer.Interval = 50; // Інтервал 500 мс
            timer.Tick += Timer_Tick;  

        }
        
        

        private void battle1_Load(object sender, EventArgs e)
        {
            GlobalVariables.enemy_generat_number = GenerateRandomFraction();
            enemy_generat_number = GlobalVariables.enemy_generat_number;    


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
            var enemy = GlobalVariables.property[GlobalVariables.enemy_generat_number];
            enemy_hp = enemy.fraction_Hp_;
            enemy_physical_dmg = enemy.fraction_Ph_Dmg;
            enemy_magic_dmg = enemy.fraction_Magic_Dmg;
            enemy_hp_label.Text = enemy.fraction_Hp_.ToString();
            enemy_ph_dmg_result_label.Text = enemy.fraction_Ph_Dmg.ToString();
            enemy_magic_dmg_result_label.Text = enemy.fraction_Magic_Dmg.ToString();
            enemy_name_label.Text = enemy.fraction_name.ToString();
            enemy_image.BackgroundImage = Image.FromFile(enemy.fraction_image);
            enemy_scatter_label.Text = enemy.fraction_scatter.ToString() + "%";
            ////////////////////////////////////////////////////////////////////////





        }

        private void button1_Click(object sender, EventArgs e)
        {
            dmg_indicator = 1;
            battle_reload(this, EventArgs.Empty);

            cycleCount = 0;  // Обнуляємо лічильник циклів
            imageIndex = "im1";  // Починаємо з першого зображення
            image_type = 1;
            timer.Start();   // Запускаємо таймер

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dmg_indicator = 2;
            battle_reload(this, EventArgs.Empty);

            cycleCount = 0;  // Обнуляємо лічильник циклів
            imageIndex = "im1";  // Починаємо з першого зображення
            image_type = 2;
            timer.Start();   // Запускаємо таймер

        }

        private void battle_reload(object sender, EventArgs e)
        {
            int random_chance = 0;
            
            var enemy_ch = GlobalVariables.property[GlobalVariables.enemy_generat_number];
            Console.WriteLine("enemy"+ GlobalVariables.enemy_generat_number);
            if (dmg_indicator == 1)
            {
                
                random_scatter = GenerateRandomScatterPH_hero();
                enemy_hp = enemy_hp - hero_physical_dmg - random_scatter;       // фізичний урон по ворогу
                enemy_hp_label.Text = enemy_hp.ToString();

                if (enemy_ch.fraction_Ph_Dmg > enemy_ch.fraction_Magic_Dmg)
                {
                    
                    random_chance = GenerateChanceHit();
                    if (random_chance <= 6)
                    {
                        random_scatter = GenerateRandomScatterPH_enemy();
                        hero_hp = hero_hp - enemy_physical_dmg - random_scatter;         // фізичний урон по герою
                        hero_hp_result_label.Text = hero_hp.ToString();
                        image_type2 = 1;
                    }else if(random_chance >= 7)
                    {
                        random_scatter = GenerateRandomScatterMagic_enemy();
                        hero_hp = hero_hp - enemy_magic_dmg - random_scatter;
                        hero_hp_result_label.Text = hero_hp.ToString();
                        image_type2 = 2;
                    }
                }else if(enemy_ch.fraction_Magic_Dmg >= enemy_ch.fraction_Ph_Dmg)
                {
                    
                    random_chance = GenerateChanceHit();
                    if (random_chance <= 6)
                    {
                        random_scatter = GenerateRandomScatterMagic_enemy();
                        hero_hp = hero_hp - enemy_magic_dmg - random_scatter;
                        hero_hp_result_label.Text = hero_hp.ToString();
                        image_type2 = 2;
                    }
                    else if (random_chance >= 7)
                    {
                        random_scatter = GenerateRandomScatterPH_enemy();
                        hero_hp = hero_hp - enemy_physical_dmg - random_scatter;         // фізичний урон по герою
                        hero_hp_result_label.Text = hero_hp.ToString();
                        image_type2 = 1;
                    }
                }

                              
                if (hero_hp < 1)
                {
                    Defeat form2 = new Defeat();
                    form2.Show();
                    this.Hide();
                }
                else if (enemy_hp < 1)                                           // Перевірка Hp гравця і ворога
                {
                    Win form2 = new Win();
                    form2.Show();
                    this.Hide();
                }
            }else if(dmg_indicator == 2)
            {
                random_scatter = GenerateRandomScatterPH_hero();

                enemy_hp = enemy_hp - hero_magic_dmg - random_scatter;
                enemy_hp_label.Text = enemy_hp.ToString();

                if (enemy_ch.fraction_Ph_Dmg > enemy_ch.fraction_Magic_Dmg)
                {
                    
                    random_chance = GenerateChanceHit();
                    if (random_chance <= 6)
                    {
                        random_scatter = GenerateRandomScatterPH_enemy();
                        hero_hp = hero_hp - enemy_physical_dmg - random_scatter;         // фізичний урон по герою
                        hero_hp_result_label.Text = hero_hp.ToString();
                        image_type2 = 1;
                    }
                    else if (random_chance >= 7)
                    {
                        random_scatter = GenerateRandomScatterMagic_enemy();
                        hero_hp = hero_hp - enemy_magic_dmg - random_scatter;
                        hero_hp_result_label.Text = hero_hp.ToString();
                        image_type2 = 2;
                    }
                }
                else if (enemy_ch.fraction_Magic_Dmg >= enemy_ch.fraction_Ph_Dmg)
                {
                    
                    random_chance = GenerateChanceHit();
                    if (random_chance <= 6)
                    {
                        random_scatter = GenerateRandomScatterMagic_enemy();
                        hero_hp = hero_hp - enemy_magic_dmg - random_scatter;
                        hero_hp_result_label.Text = hero_hp.ToString();
                        image_type2 = 2;
                    }
                    else if (random_chance >= 7)
                    {
                        random_scatter = GenerateRandomScatterPH_enemy();
                        hero_hp = hero_hp - enemy_physical_dmg - random_scatter;         // фізичний урон по герою
                        hero_hp_result_label.Text = hero_hp.ToString();
                        image_type2 = 1;
                    }
                }
                

                if (hero_hp < 1)
                {
                    Defeat form2 = new Defeat();
                    form2.Show();
                    this.Hide();
                }
                else if (enemy_hp < 1)
                {
                    Win form2 = new Win();
                    form2.Show();
                    this.Hide();
                }
            }
            Console.WriteLine(random_chance);
        }

        private int GenerateRandomFraction()
        {
            return _random.Next(0, 4); // Генерує число фракції ворога
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
        private int GenerateChanceHit()
        {
            return _random_scatter.Next(1, 10); // Генерує число виду урону
            
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if(image_type == 1) {
                if (imageIndex == "im1")
                {
                    pictureBox1.Visible = true;
                    imageIndex = "im2";
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox1.Image = Image.FromFile(GlobalVariables.Image_for_battle[0].im1); // Змінюємо зображення
                }
                else if (imageIndex == "im2")
                {
                    imageIndex = "im3";
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox1.Image = Image.FromFile(GlobalVariables.Image_for_battle[0].im2); // Змінюємо зображення
                }
                else if (imageIndex == "im3")
                {
                    imageIndex = "im4";
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox1.Image = Image.FromFile(GlobalVariables.Image_for_battle[0].im3); // Змінюємо зображення
                }
            }
            else if(image_type == 2){
                if (imageIndex == "im1")
                {
                    pictureBox1.Visible = true;
                    imageIndex = "im2";
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox1.Image = Image.FromFile(GlobalVariables.Image_for_battle[1].im1); // Змінюємо зображення
                }
                else if (imageIndex == "im2")
                {
                    imageIndex = "im3";
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox1.Image = Image.FromFile(GlobalVariables.Image_for_battle[1].im2); // Змінюємо зображення
                }
                else if (imageIndex == "im3")
                {
                    imageIndex = "im4";
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox1.Image = Image.FromFile(GlobalVariables.Image_for_battle[1].im3); // Змінюємо зображення
                }
               
              
            }

            if (image_type2 == 1)
            {
                if (imageIndex == "im2")
                {
                    pictureBox2.Visible = true;
                    

                    Image img = Image.FromFile(GlobalVariables.Image_for_battle[0].im1);
                    img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.Image = img; // Змінюємо зображення
                }
                else if (imageIndex == "im3")
                {
                    Image img = Image.FromFile(GlobalVariables.Image_for_battle[0].im2);
                    img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.Image = img; // Змінюємо зображення
                }
                else if (imageIndex == "im4")
                {
                    Image img = Image.FromFile(GlobalVariables.Image_for_battle[0].im3);
                    img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.Image = img; // Змінюємо зображення
                }
                
            }
            else if (image_type2 == 2)
            {
                if (imageIndex == "im2")
                {
                    pictureBox2.Visible = true;
                    
                    Image img = Image.FromFile(GlobalVariables.Image_for_battle[1].im1);
                    img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.Image = img;// Змінюємо зображення
                }
                else if (imageIndex == "im3")
                {
                    Image img = Image.FromFile(GlobalVariables.Image_for_battle[1].im2);
                    img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.Image = img; // Змінюємо зображення
                }
                else if (imageIndex == "im4")
                {
                    Image img = Image.FromFile(GlobalVariables.Image_for_battle[1].im3);
                    img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox2.Image = img; // Змінюємо зображення
                }
                
            }

            

            if (imageIndex == "im4") // Кожен раз, коли зображення обійшло цикл
            {
                cycleCount++;
                if (cycleCount >= 3) // Якщо цикл пройдено тричі
                {
                    timer.Stop(); // Зупиняємо таймер
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                }
            }


        }
    }
}
