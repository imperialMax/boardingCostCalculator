using System;


namespace boardingCostCalculator
{
    public partial class Form1 : Form
    {
        string fee = "";
        int factor = 0;
        int discount = 1;
        int speciesCost = 0;
        int stayDays = 0;
        decimal decimalWeightCost = 0;
        decimal stayDiscount = 1;
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

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //daily rate
            string species = tbSpecies.Text;
            species.ToLower();
            bool test = speciesList.Contains(species); 
            // weight
            string weight = tbPet.Text;
            string stay = tbLength.Text;

            //dumping discount
            if (species == "")
            {
                MessageBox.Show("Please enter a pet.");
            }
            else
            {
                if(test == false)
                {
                    MessageBox.Show("please choose an allowed pet");
                }
                else
                {
                    // this calculates the final one
                    if (species == "cat")
                    {
                        speciesCost = 5;
                    }
                    if (species == "dog")
                    {
                        speciesCost = 5;
                    }
                    if (species == "goat")
                    {
                        speciesCost = 12;
                    }
                    if (species == "koala")
                    {
                        speciesCost = 20;
                    }
                    if (species == "tortoise")
                    {
                        speciesCost = 0;
                    }

                }
            }
            try
            {
                decimal numWeight = Convert.ToDecimal(weight);
                if (numWeight >= 12) 
                {
                    int intWeightCost = Convert.ToInt32(weight);
                    intWeightCost = intWeightCost - 12;
                    decimalWeightCost = Convert.ToDecimal(intWeightCost);
                    decimalWeightCost = Decimal.Multiply(decimalWeightCost, 1.50m);
                    decimalWeightCost = decimal.Add(decimalWeightCost, 1.50m); /// heres the final one
                    //lblOutput.Text = decimalWeightCost.ToString();
                }

            }
            catch
            {
                MessageBox.Show("this is the problem here");
            }
            try
            {

                stayDays = Convert.ToInt32(stay);
                if (stayDays > 10)
                {
                    stayDiscount = 0.10m;
                }
                lblOutput.Text = stayDiscount.ToString();

                
            }
            catch
            {
                MessageBox.Show("please enter a whole number with no spaces or special characters");
            }

            // staydiscount, decimalweightcost, speciescost
            try
            {   
                
                decimal costPerDay = stayDays * speciesCost;
                decimal totalBefore = costPerDay + decimalWeightCost;
                decimal total = totalBefore * stayDiscount + 20;
                lblOutput.Text = total.ToString();
            }
            catch
            {
                MessageBox.Show("Please Try Again");
            }
        }
        
    }
}
