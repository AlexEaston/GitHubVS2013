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
namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Index of the operator
        int indexOp;
        //First number prompted
        double nb1 = 0;
        //second number prompted -> String
        string nbr2 = "";

        //Next methods -> Case of the numbers. 
        private void btn0_Click(object sender, EventArgs e)
        {
            if (nb1 == 0)
            {
                tbxRes.Text = tbxRes.Text + "0";
            }
            else
            {
                tbxRes.Text = tbxRes.Text + "0";
                nbr2 += "0";
            }

            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (nb1 == 0)
            {
                tbxRes.Text = tbxRes.Text + "1";
            }
            else
            {
                tbxRes.Text = tbxRes.Text + "1";
                nbr2 += "1";
            }

           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (nb1 == 0)
            {
                tbxRes.Text = tbxRes.Text + "2";
            }
            else
            {
                tbxRes.Text = tbxRes.Text + "2";
                nbr2 += "2";
            }

              
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (nb1 == 0)
            {
                tbxRes.Text = tbxRes.Text + "3";
            }
            else
            {
                tbxRes.Text = tbxRes.Text + "3";
                nbr2 += "3";
            }

            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (nb1 == 0)
            {
                tbxRes.Text = tbxRes.Text + "4";
            }
            else
            {
                tbxRes.Text = tbxRes.Text + "4";
                nbr2 += "4";
            }

            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
            if (nb1 == 0)
            {
                tbxRes.Text = tbxRes.Text + "5";
            }
            else
            {
                tbxRes.Text = tbxRes.Text + "5";
                nbr2 += "5";
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (nb1 == 0)
            {
                tbxRes.Text = tbxRes.Text + "6";
            }
            else
            {
                tbxRes.Text = tbxRes.Text + "6";
                nbr2 += "6";
            }

            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (nb1 == 0)
            {
                tbxRes.Text = tbxRes.Text + "7";
            }
            else
            {
                tbxRes.Text = tbxRes.Text + "7";
                nbr2 += "7";
            }

           
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (nb1 == 0)
            {
                tbxRes.Text = tbxRes.Text + "8";
            }
            else
            {
                tbxRes.Text = tbxRes.Text + "8";
                nbr2 += "8";
            }

            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (nb1 == 0)
            {
                tbxRes.Text = tbxRes.Text + "9";
            }else
            {
                tbxRes.Text = tbxRes.Text + "9";
                nbr2 += "9";
            }

        }
        //Operators 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation("+");
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            operation("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation("/");
        }
        //Result of the current calculation 
        private void btnRes_Click(object sender, EventArgs e)
        {
            double nb2 = 0;
            if (tbxRes.Text.IndexOf("+") != -1) //Do we add ? 
            {
                nb2 = Convert.ToDouble(nbr2);
                tbxRes.Text = Convert.ToString(nb1 + nb2);
                nb1 = Convert.ToDouble(tbxRes.Text);
            }
            if (tbxRes.Text.IndexOf("-") != -1) //Do we substract ? 
            {
                nb2 = Convert.ToInt32(nbr2);
                tbxRes.Text = Convert.ToString(nb1 - nb2);
                nb1 = Convert.ToDouble(tbxRes.Text);
            }
            if (tbxRes.Text.IndexOf("*") != -1) //Do we multiply ? 
            {
                nb2 = Convert.ToInt32(nbr2);
                tbxRes.Text = Convert.ToString(nb1 * nb2);
                nb1 = Convert.ToDouble(tbxRes.Text);
            }
            if (tbxRes.Text.IndexOf("/") != -1) //Do we divide ?
            {
                nb2 = Convert.ToDouble(nbr2);
                if (nb2 != 0)
                {
                    tbxRes.Text = Convert.ToString(nb1 / nb2);
                    nb1 = Convert.ToDouble(tbxRes.Text);
                }
                else //If the user divide by 0 
                {
                    MessageBox.Show("You tried to divide by 0");
                    tbxRes.Text = "";
                    nb1 = 0;
                    nb2 = 0;
                    nbr2 = "";

                }
            }

            nbr2 = "";
        }

        //Set up the operation (add "+","-","*" or "/" on the screen and save the operator) 
        private void operation(string op)
        {
            nb1 = Convert.ToDouble(tbxRes.Text);
            tbxRes.Text = tbxRes.Text + op;
            indexOp = tbxRes.Text.IndexOf(op);
        }
        //Clean the caculation. 
        private void btnClear_Click(object sender, EventArgs e)
        {
            nb1 = 0;
            nbr2 = "";
            tbxRes.Text = "";
        }
    }
}
