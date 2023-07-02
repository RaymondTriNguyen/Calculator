using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            textBoxFirst.KeyPress += textBoxFirst_KeyPress;
            textBoxSecond.KeyPress += textBoxSecond_KeyPress;
        }

     

        private void textBoxFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !='.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(textBoxFirst.Text);
            double numTwo = double.Parse(textBoxSecond.Text);
            double result = numOne + numTwo;
            resultNotVar.Text = result.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void subtract_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(textBoxFirst.Text);
            double numTwo = double.Parse(textBoxSecond.Text);
            double result = numOne - numTwo;
            resultNotVar.Text = result.ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(textBoxFirst.Text);
            double numTwo = double.Parse(textBoxSecond.Text);
            double result = numOne * numTwo;
            resultNotVar.Text = result.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(textBoxFirst.Text);
            double numTwo = double.Parse(textBoxSecond.Text);
            double result = numOne / numTwo;
            resultNotVar.Text = result.ToString();
        }

        private void textBoxFirst_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
