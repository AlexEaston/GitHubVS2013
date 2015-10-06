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
                    if (cbOut.Text == "GBP")
                    {
                        try
                        {
                            tbOut.Text = Convert.ToString(Convert.ToDouble(tbIn.Text) * 0.79);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Please enter a number with this format : 0,00");
                        }

                    }
                }
                if (cbIn.Text == "GBP")
                {
                    if (cbOut.Text == "EUR")
                    {
                        try
                        {
                            tbOut.Text = Convert.ToString(Convert.ToDouble(tbIn.Text) / 0.79);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Please enter a number with this format : 0,00");
                        }
                    }
                }
                if (cbIn.Text == "C°")
                {
                    if (cbOut.Text == "F°")
                    {
                        try
                        {
                            tbOut.Text = Convert.ToString((Convert.ToDouble(tbIn.Text) * (9 / 5)) + 32);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Please enter a number with this format : 0,00");
                        }
                    }
                }
                if (cbIn.Text == "F°")
                {
                    if (cbOut.Text == "C°")
                    {
                        try
                        {
                            tbOut.Text = Convert.ToString((Convert.ToDouble(tbIn.Text) - 32) * 5 / 9);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Please enter a number with this format : 0,00");
                        }
                    }
                }
                if (cbIn.Text == "inches")
                {
                    if (cbOut.Text == "feet")
                    {
                        try
                        {
                            tbOut.Text = Convert.ToString(Convert.ToDouble(tbIn.Text) / 12);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Please enter a number with this format : 0,00");
                        }
                    }
                }
                if (cbIn.Text == "feet")
                {
                    if (cbOut.Text == "inches")
                    {
                        try
                        {
                            tbOut.Text = Convert.ToString(Convert.ToDouble(tbIn.Text) * 12);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Please enter a number with this format : 0,00");
                        }
                    }
                }
                if (cbIn.Text == cbOut.Text)
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
        /// When you choose the first unit, the output unit will be affected to the out combobox. 
        /// Converts will always make sense.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIn.Text == "EUR" || cbIn.Text == "GBP") //EUR or GBP selected
            {
                cbOut.Items.Clear();
                cbOut.Text = "";
                cbOut.Items.Add("EUR");
                cbOut.Items.Add("GBP");
            }
            if (cbIn.Text == "inches" || cbIn.Text == "feet") //Inches or feet selected
            {
                cbOut.Items.Clear();
                cbOut.Text = "";
                cbOut.Items.Add("inches");
                cbOut.Items.Add("feet");
            }
            if (cbIn.Text == "F°" || cbIn.Text == "C°") //F° or C° selected
            {
                cbOut.Items.Clear();
                cbOut.Text = "";
                cbOut.Items.Add("C°");
                cbOut.Items.Add("F°");
            }
        }
    }
}
