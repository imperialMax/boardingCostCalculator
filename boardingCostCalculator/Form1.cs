using System;
using System.Text.RegularExpressions;


namespace boardingCostCalculator
{
    public partial class Form1 : Form
    {
        string fee = "";
        int factor = 0;
        int discount = 0;
        List<string> speciesList = new List<string>();



        public Form1()
        {
            speciesList.Add("cat");
            speciesList.Add("dog");
            speciesList.Add("goat");
            speciesList.Add("koala");
            speciesList.Add("tortoise");
            InitializeComponent();

        }

        private void tbPet_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            string petWeight = tbPet.Text;
            // fee = $20 + speciesRate + if petWeight >= 12 , fee  1.5 per kg over
            //try
            //{

            //}
            //catch 
            //{

            //}

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string species = tbSpecies.Text;
            species.ToLower();
            bool test = speciesList.Contains(species); 
            if (species == "cat")
            {
                int speciesCost = 5;
            }
            if (species == "dog")
            {
                int speciesCost = 5;
            }
            if (species == "goat")
            {
                int speciesCost = 12;
            }
            if (species == "koala")
            {
                int speciesCost = 20;
            }
            if (species == "tortoise")
            {
                int speciesCost = 0;
            }
            if (species == "")
            {
                MessageBox.Show("Please enter a pet.");
            }
            else
            {
                if(test == false)
                {
                    MessageBox.Show("please choose a pet youre supposed to");
                }
                else
                {
                    MessageBox.Show("this worked");
                }
            }




        }

    }
}
