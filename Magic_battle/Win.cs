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
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        private void Back_win_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }

        private void Win_Load(object sender, EventArgs e)
        {

        }
    }
}
