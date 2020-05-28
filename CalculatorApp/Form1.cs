using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        bool operatorPressed = false;
        string operation = "";
        string lastOperation = "";
        double value = 0;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(InputBox.Text == "0")
            {
                InputBox.Clear();
            }
            InputBox.Text += button.Text;
        }

        private void ClearEntryOperator_Click(object sender, EventArgs e)
        {
            InputBox.Text = "0";
        }

        private void operatorClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string doOperation = "";

            if (!string.IsNullOrWhiteSpace(InputBox.Text))
            {



                if (operatorPressed)
                {
                    lastOperation = operation;
                    operation = button.Text;
                    doOperation = lastOperation;
                }
                else
                {
                    operation = button.Text;
                    doOperation = operation;
                }

                if (value != 0)
                {

                    switch (doOperation)
                    {
                        case "+":
                            DisplayBox.Text = (value + Convert.ToDouble(InputBox.Text)).ToString();
                            break;
                        case "-":
                            DisplayBox.Text = (value - Convert.ToDouble(InputBox.Text)).ToString();
                            break;
                        case "*":
                            DisplayBox.Text = (value * Convert.ToDouble(InputBox.Text)).ToString();
                            break;
                        case "/":
                            DisplayBox.Text = (value / Convert.ToDouble(InputBox.Text)).ToString();
                            break;

                    }
                    value = Convert.ToDouble(DisplayBox.Text);
                    DisplayBox.Text += operation;
                    operatorPressed = true;
                    InputBox.Text = "";

                }
                else
                {

                    value = Convert.ToDouble(InputBox.Text);
                    operatorPressed = true;
                    InputBox.Text = "";
                    DisplayBox.Text = value.ToString() + operation;

                }
            }

        }

        private void EqualsOperator_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    InputBox.Text = (value + Convert.ToDouble(InputBox.Text)).ToString();
                    break;
                case "-":
                    InputBox.Text = (value - Convert.ToDouble(InputBox.Text)).ToString();
                    break;
                case "*":
                    InputBox.Text = (value * Convert.ToDouble(InputBox.Text)).ToString();
                    break;
                case "/":
                    InputBox.Text = (value / Convert.ToDouble(InputBox.Text)).ToString();
                    break;

            }
            value = 0;
            operatorPressed = false;
            DisplayBox.Text = "";
        }

        private void ClearOperator_Click(object sender, EventArgs e)
        {
            InputBox.Text = "0";
            DisplayBox.Text = "";
            operatorPressed = false;
            value = 0;
            operation = "";
        }

        private void decimalClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!InputBox.Text.Contains(".")) 
            {
                InputBox.Text += button.Text;
            }
        }
    }
}
