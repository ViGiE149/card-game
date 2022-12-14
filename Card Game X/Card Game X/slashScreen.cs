using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Game_X
{
    public partial class slashScreen : Form
    {
        public slashScreen()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.dark;

        }

        private void slashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();
            Form1 cardFight= new Form1();
            cardFight.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
