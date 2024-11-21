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
    
    public partial class Login : Form
    {
        string name;
        string password;

        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            name = name_textBox.Text;
            password = password_textBox.Text;
            text_label.Visible = true;
            text_label.Text = "Вітаю " + name +" Ваш пароль: " + password;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
