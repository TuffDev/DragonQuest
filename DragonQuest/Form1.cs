using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonQuest
{
    public partial class Form1 : Form
    {
        private int timer = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (timer <= 3)
            {
                NotificationLabel.Visible = true;
                NotificationLabel.Text = "A WILD DRAGON HAS APPEARED!!! FIGHT OR DIE!";
            }
            NotificationLabel.Visible = false;
            NotificationTimer.Enabled = false;
            timer = 0;
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            timer++;

        }
    }
}
