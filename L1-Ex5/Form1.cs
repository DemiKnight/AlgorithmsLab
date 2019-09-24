using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1_Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            switch(CheckListOperator.CheckedIndices[0])
            {
                case 0: //+
                    TextBoxResult.Text = Convert.ToString(Convert.ToDouble(TextBoxNumber1.Text) + Convert.ToDouble(TextBoxNumber2.Text));
                    break;
                case 1: //-
                    TextBoxResult.Text = Convert.ToString(Convert.ToDouble(TextBoxNumber1.Text) - Convert.ToDouble(TextBoxNumber2.Text));
                    break;
                case 2: //*
                    TextBoxResult.Text = Convert.ToString(Convert.ToDouble(TextBoxNumber1.Text) * Convert.ToDouble(TextBoxNumber2.Text));
                    break;
                case 3: // '/
                    TextBoxResult.Text = Convert.ToString(Convert.ToDouble(TextBoxNumber1.Text) / Convert.ToDouble(TextBoxNumber2.Text));
                    break;
                case 4: //^
                    double totalCal = Convert.ToDouble(TextBoxNumber1.Text);

                    for(int index = 1; index < Convert.ToInt16(TextBoxNumber2.Text); index++)
                    {
                        totalCal *= Convert.ToDouble(TextBoxNumber1.Text);
                    }
                    TextBoxResult.Text = Convert.ToString(totalCal);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckListOperator.SelectedIndex = 0;
        }
    }
}
