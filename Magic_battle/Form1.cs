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
    public partial class Form1 : Form
    {
        private int hero_fraction = 0;
        int value = GlobalVariables.hero_fraction_global; // Отримати значення
       
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LVL_1 form2 = new LVL_1(); 
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hero_fraction = GlobalVariables.hero_fraction_global;


            if (hero_fraction == 0) //if fire
            {
                
                select_fraction_button.BackgroundImage = Image.FromFile(@"assets\fire_element.png");
            }
            else if (hero_fraction == 1) // if water
            {
                
                select_fraction_button.BackgroundImage = Image.FromFile(@"assets\water_element.png");
            }
            else if (hero_fraction == 2) // if air
            {
                
                select_fraction_button.BackgroundImage = Image.FromFile(@"assets\air_element.png");
            }
            else if (hero_fraction == 3)// if earth
            {
                
                select_fraction_button.BackgroundImage = Image.FromFile(@"assets\earth_element.png");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            hero_fraction = GlobalVariables.hero_fraction_global;


            if  (hero_fraction == 0)
            {
                hero_fraction = 1;
                select_fraction_button.BackgroundImage = Image.FromFile(@"assets\water_element.png");
            }else if(hero_fraction == 1)
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

            GlobalVariables.hero_fraction_global = hero_fraction;
        }
    }
}
