using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ACOTIN_POS_APPLICATION
{
    public partial class Activity4_Transfer : Form
    {
        public Activity4_Transfer()
        {
            InitializeComponent();
        }

        private void A_Gravy_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Set background color
            this.BackColor = Color.Goldenrod;

            double price;

            foodBRdbtn.Checked = false;

            A_ChickenMcDoBox.Checked = true;
            A_BFFFriesBox.Checked = true;
            A_DrinksBox.Checked = true;
            A_RiceBox.Checked = true;
            A_Gravy.Checked = true;

            B_ApplePieBox.Checked = false;
            B_BFFFriesBox.Checked = false;
            B_BurgerMcDoBox.Checked = false;
            B_ChickenSandwichBox.Checked = false;
            B_QuarterPounderBox.Checked = false;

            priceTxtBox.Text = "720.00";
            discountAmountTxtbox.Text = "144.00";
            price = Convert.ToDouble(priceTxtBox.Text);

            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Set background color
            this.BackColor = Color.Goldenrod;

            foodARdbtn.Checked = false;

            A_ChickenMcDoBox.Checked = false;
            A_BFFFriesBox.Checked = false;
            A_DrinksBox.Checked = false;
            A_RiceBox.Checked = false;
            A_Gravy.Checked = false;

            B_ApplePieBox.Checked = true;
            B_BFFFriesBox.Checked = true;
            B_BurgerMcDoBox.Checked = true;
            B_ChickenSandwichBox.Checked = true;
            B_QuarterPounderBox.Checked = true;

            priceTxtBox.Text = "450.00";
            discountAmountTxtbox.Text = "67.50";

            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Leave empty or add functionality if needed
        }
    }
}
