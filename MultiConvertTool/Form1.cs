using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Alexis ROTH C00209683
namespace MultiConvertTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //String arrays that stores data for Combo boxes 
        string[] currencies = { "EUR", "GBP" };
        string[] temperatures = { "C°", "F°" };
        string[] lengths = { "inches", "feet" };

        /// <summary>
        /// Clears all fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbIn.Text = "";
            tbOut.Text = "";
            cbIn.Text = "";
            cbOut.Text = "";
        }
        /// <summary>
        /// Convert the currency, the temperature or the length prompted by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (tbIn.Text != "" || cbIn.Text != "" || cbOut.Text != "")
            {

                if (cbIn.Text == "EUR")
                {
                    if (cbOut.Text == "GBP") // EUR -> GBP
                    {
                        try
                        {
                            tbOut.Text = Convert.ToString(Convert.ToDouble(tbIn.Text) * 0.79);
                        }
                        catch (FormatException) //If user doesn't type a number
                        {
                            MessageBox.Show("Please enter a number with this format : 0,00");
                        }

                    }
                }
                if (cbIn.Text == "GBP")
                {
                    if (cbOut.Text == "EUR") // GBP -> EUR
                    {
                        try
                        {
                            tbOut.Text = Convert.ToString(Convert.ToDouble(tbIn.Text) / 0.79);
                        }
                        catch (FormatException) //If user doesn't type a number
                        {
                            MessageBox.Show("Please enter a number with this format : 0,00");
                        }
                    }
                }
                if (cbIn.Text == "C°")
                {
                    if (cbOut.Text == "F°") //C° -> F° 
                    {
                        try
                        {
                            tbOut.Text = Convert.ToString((Convert.ToDouble(tbIn.Text) * (9 / 5)) + 32);
                        }
                        catch (FormatException) //If user doesn't type a number
                        {
                            MessageBox.Show("Please enter a number with this format : 0,00");
                        }
                    }
                }
                if (cbIn.Text == "F°")
                {
                    if (cbOut.Text == "C°") //F° -> C°
                    {
                        try
                        {
                            tbOut.Text = Convert.ToString((Convert.ToDouble(tbIn.Text) - 32) * 5 / 9);
                        }
                        catch (FormatException) //If user doesn't type a number
                        {
                            MessageBox.Show("Please enter a number with this format : 0,00");
                        }
                    }
                }
                if (cbIn.Text == "inches")
                {
                    if (cbOut.Text == "feet") //inches -> feet
                    {
                        try
                        {
                            tbOut.Text = Convert.ToString(Convert.ToDouble(tbIn.Text) / 12);
                        }
                        catch (FormatException) //If user doesn't type a number
                        {
                            MessageBox.Show("Please enter a number with this format : 0,00");
                        }
                    }
                }
                if (cbIn.Text == "feet")
                {
                    if (cbOut.Text == "inches") //feet -> inches
                    {
                        try
                        {
                            tbOut.Text = Convert.ToString(Convert.ToDouble(tbIn.Text) * 12);
                        }
                        catch (FormatException) //If user doesn't type a number
                        {
                            MessageBox.Show("Please enter a number with this format : 0,00");
                        }
                    }
                }
                if (cbIn.Text == cbOut.Text) //If user choose the same unit "in" and "out" 
                {
                    tbOut.Text = tbIn.Text;
                }
            }
            else
            {
                MessageBox.Show("One of the fields is empty.");
            }
        }
        /// <summary>
        /// The currency is chosen in the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbIn.Text = "";
            cbOut.Text = "";
            cbIn.Items.Clear();
            cbOut.Items.Clear();
            for (int i = 0; i < currencies.Length; i++)
            {
                cbIn.Items.Add(currencies[i]);
            }
            for (int i = 0; i < currencies.Length; i++)
            {
                cbOut.Items.Add(currencies[i]);
            }
        }
        /// <summary>
        /// The length is chosen in the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbIn.Text = "";
            cbOut.Text = "";
            cbIn.Items.Clear();
            cbOut.Items.Clear();
            for (int i = 0; i < lengths.Length; i++)
            {
                cbIn.Items.Add(lengths[i]);
            }
            for (int i = 0; i < lengths.Length; i++)
            {
                cbOut.Items.Add(lengths[i]);
            }
        }
        /// <summary>
        /// The temperature is chosen in the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbIn.Text = "";
            cbOut.Text = "";
            cbIn.Items.Clear();
            cbOut.Items.Clear();
            for (int i = 0; i < temperatures.Length; i++)
            {
                cbIn.Items.Add(temperatures[i]);
            }
            for (int i = 0; i < temperatures.Length; i++)
            {
                cbOut.Items.Add(temperatures[i]);
            }
        }
    }
}
