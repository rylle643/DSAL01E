using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACOTIN_POS_APPLICATION
{
    public partial class Activity1 : Form
    {
        public Activity1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Load += (s, e) =>
            {
                this.Scale(new SizeF(2f, 2f));
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Big Mac";
            priceTxtbox.Text = "167.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Quarter Pounder";
            priceTxtbox.Text = "255.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            
            itemnameTextbox.Text = "Burger McDo";
            priceTxtbox.Text = "47.00";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Chicken McDo with McSpaghetti";
            priceTxtbox.Text = "251.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Chicken McDo with Rice";
            priceTxtbox.Text = "150.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Crispy Chicken Fillet with Rice";
            priceTxtbox.Text = "134.00";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Coke McFloat";
            priceTxtbox.Text = "59.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "McFlurry with Oreo Cookies";
            priceTxtbox.Text = "69.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Hot Fudge Sundae";
            priceTxtbox.Text = "55.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "McCafé Americano";
            priceTxtbox.Text = "79.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "McCafé Premium Hot Chocolate";
            priceTxtbox.Text = "130.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "McCafé Iced Mocha";
            priceTxtbox.Text = "140.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Cheesy Eggdesal";
            priceTxtbox.Text = "42.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Sausage McMuffin with Egg";
            priceTxtbox.Text = "82.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Egg McMuffin";
            priceTxtbox.Text = "73.00";
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Clear();
            priceTxtbox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
