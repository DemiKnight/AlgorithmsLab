using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1_Ex4_Portfolio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MessageColourBox.ForeColor = (ColorCheckBox.Checked ? Color.Red : Color.Black);

            /*
             * 
             * if (MessageColourBox.ForeColor == Color.Black)
             * {
             *      MessageColourBox.ForeColor = Color.Red;
             * } 
             * else 
             * {
             *      MessageColourBox.ForeColor = Color.Black
             * }
             * 
             */
        }
    }
}
