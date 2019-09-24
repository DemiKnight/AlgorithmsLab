using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1_Ex6
{
    public partial class Form1 : Form
    {
        enum Operation
        {
            add,
            subtract,
            multiply,
            divide
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Char[] arrayExpression;
            Double number1= 0, number2=0;
            StringBuilder tempNumber = new StringBuilder();
            Operation operationType = Operation.add;

            arrayExpression = TextBoxExpression.Text.Replace(" ", "").ToCharArray();

            foreach (Char characterSel in arrayExpression)
            {
                Double tempDouble;
                if (double.TryParse(Convert.ToString(characterSel), out tempDouble))
                {
                    tempNumber.Append(tempDouble);
                }
                else
                {
                    number1 = Double.Parse(tempNumber.ToString());
                    tempNumber.Clear();

                    switch (characterSel)
                    {
                        case '+':
                            operationType = Operation.add;
                            break;
                        case '-':
                            operationType = Operation.subtract;
                            break;
                        case '*':
                            operationType = Operation.multiply;
                            break;
                        case '/':
                            operationType = Operation.divide;
                            break;
                    }
                }
                number2 = tempDouble;
            }

            switch (operationType)
            {
                case Operation.add:
                    TextBoxResult.Text = Convert.ToString(number1+number2);
                    break;
                case Operation.subtract:
                    TextBoxResult.Text = Convert.ToString(number1 - number2);
                    break;
                case Operation.multiply:
                    TextBoxResult.Text = Convert.ToString(number1 * number2);
                    break;
                case Operation.divide:
                    TextBoxResult.Text = Convert.ToString(number1 / number2);
                    break;
            }
        }

    }
}
