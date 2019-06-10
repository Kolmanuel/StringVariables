using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int integerAnswer;

            firstNumber = 10;
            secondNumber = 32;

            integerAnswer = firstNumber + secondNumber;

            MessageBox.Show(integerAnswer.ToString());
        }

        private void btnAddFloats_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float floatAnswer;
            //int integerAnswer;
            int integerAns = 20;

            firstNumber = 10.5F;
            secondNumber = 32.5F;

            //Integer can be stored in Float without conversion.
            floatAnswer = firstNumber + secondNumber + integerAns;
            MessageBox.Show(floatAnswer.ToString());

            //Float cannot be stored in Integer without first converting it.
            //integerAnswer = (int)firstNumber + (int)secondNumber;
            //MessageBox.Show(integerAnswer.ToString());



        }
    }
}
