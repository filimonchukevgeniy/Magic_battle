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


        public LVL_1()
        {
            InitializeComponent();
            
        }

        private void battle1_Load(object sender, EventArgs e)
        {
            enemy_hp_label.Text = enemy_hp.ToString();
            hero_hp_result_label.Text = hero_hp.ToString();
            enemy_ph_dmg_result_label.Text = enemy_physical_dmg.ToString();
            enemy_magic_dmg_result_label.Text = enemy_magic_dmg.ToString();
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            enemy_hp = enemy_hp - hero_physical_dmg;
            enemy_hp_label.Text = enemy_hp.ToString();
            if (enemy_hp<1)
            {
                Win form2 = new Win();
                form2.Show();
                this.Hide();
            }
            hero_hp = hero_hp - enemy_physical_dmg;
            hero_hp_result_label.Text = hero_hp.ToString();
            if (hero_hp < 1)
            {
                Defeat form2 = new Defeat();
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
