using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FactorialRecursion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            txtBxResult.Text = Factorial(Convert.ToInt16(txtBxStart.Text)).ToString();
        }

        private int Factorial(int intValue)
        {
            int intReturnValue;
            txtBxSteps.Text += ("Compute " + intValue.ToString() + "!\r\n");
            if (intValue == 0)
                intReturnValue = 1;
            else
                intReturnValue=intValue*Factorial(intValue-1);
            txtBxSteps.Text+=(intValue.ToString()+"! = "+intReturnValue.ToString()+"\r\n";
            return intReturnValue;
        }
    }
}
