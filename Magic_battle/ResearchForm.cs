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
            if (GlobalVariables.hero_fraction_global == 0)
            {
                if (GlobalVariables.researches[0].hp1_boost == 0)
                {
                    GlobalVariables.hero_property[0].hp = GlobalVariables.hero_property[0].hp + 40;
                    GlobalVariables.researches[0].hp1_boost = 1;
                    HP_buster1_button.Enabled = false;
                    HP_buster1_button.BackColor = Color.LightSteelBlue;
                }
            }
            else
            {
                HP_buster1_button.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void HP_buster2_button_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.hero_fraction_global == 0)
            {
                if (GlobalVariables.researches[0].hp1_boost == 1)
                {
                    GlobalVariables.hero_property[0].hp = GlobalVariables.hero_property[0].hp + 40;
                    GlobalVariables.researches[0].hp1_boost = 2;
                    HP_buster2_button.Enabled = false;
                    HP_buster2_button.BackColor = Color.LightSteelBlue;
                }
            }
        }

        private void ResearchForm_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.hero_fraction_global == 0)
            {
                if (GlobalVariables.researches[0].phDmg1_boost == 0)
                {
                    GlobalVariables.hero_property[0].phDmg = GlobalVariables.hero_property[0].phDmg + 5;
                    GlobalVariables.researches[0].phDmg1_boost = 1;
                    ph_buster1_button.Enabled = false;
                    ph_buster1_button.BackColor = Color.LightSteelBlue;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}


