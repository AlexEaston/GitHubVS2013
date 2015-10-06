using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Alexis ROTH C00209683
namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Var that contains every changes in every way. 
        double changeEurUsd = 1.1139;
        double changeUsdEur = 0.8979;
        double changeEurGbp = 0.7233;
        double changeGbpEur = 1.3825;
        double changeGbpUsd = 1.5397;
        double changeUsdGbp = 0.6495;
        //Stores the result
        string result; 
        /// <summary>
        /// Convert the sum by currency 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (tbxIn.Text == "" || cbFrom.Text == "" || cbTo.Text == "") //If one of the field is empty
            {
                MessageBox.Show("Can't convert, lack of informations");
            }
            else
            {
                //Initialize the sum string and the 2 currencies. 
                double sum = Convert.ToDouble(tbxIn.Text);
                string currencyFrom = cbFrom.Text;
                string currencyTo = cbTo.Text;
                
                if (cbFrom.Text == "EUR") //If the first currency is EUR
                {
                    if (cbTo.Text == "USD") //If the second one is USD 
                    {
                        result = Convert.ToString(Convert.ToDouble(tbxIn.Text) * changeEurUsd);
                    }
                    if (cbTo.Text == "GBP") //If the second one is GBP
                    {
                        result = Convert.ToString(Convert.ToDouble(tbxIn.Text) * changeEurGbp);
                    }
                }
                if (cbFrom.Text == "USD") //If the first currency is USD
                {
                    if (cbTo.Text == "EUR") //If the second one is EUR
                    {
                        result = Convert.ToString(Convert.ToDouble(tbxIn.Text) * changeUsdEur);
                    }
                    if (cbTo.Text == "GBP") //If the second one is GBP 
                    {
                        result = Convert.ToString(Convert.ToDouble(tbxIn.Text) * changeUsdGbp);
                    }
                }
                if (cbFrom.Text == "GBP") //If the currency is GBP 
                {
                    if (cbTo.Text == "USD") //If the second one is USD
                    {
                        result = Convert.ToString(Convert.ToDouble(tbxIn.Text) * changeGbpUsd);
                    }
                    if (cbTo.Text == "EUR") //If the second one is EUR
                    {
                        result = Convert.ToString(Convert.ToDouble(tbxIn.Text) * changeGbpEur);
                    }
                }
                if (cbFrom.Text == cbTo.Text) //If the user just get the same currency "From" and "To"
                {
                    result = tbxIn.Text;
                }
                tbxOut.Text = result;
            }
        }
        /// <summary>
        /// Clear all the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxIn.Text = "";
            tbxOut.Text = "";
            cbFrom.Text = "";
            cbTo.Text = "";
        }
    }
}
