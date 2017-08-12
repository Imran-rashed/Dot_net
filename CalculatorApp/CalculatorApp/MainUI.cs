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
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            resultTextBox.Text = Add(firstNumber, secondNumber).ToString();
        }

        private int Add(int firstNo, int secondNo)
        {
            return firstNo + secondNo;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            resultTextBox.Text = Subtract(firstNumber, secondNumber).ToString();

        }

        private int Subtract(int firstno, int secondno)
        {
            return firstno - secondno;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            resultTextBox.Text = Multiply(firstNumber, secondNumber).ToString();
        }

        private int Multiply(int firstno,int secondno)
        {
            return firstno*secondno;
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            resultTextBox.Text = Divide(firstNumber, secondNumber).ToString();
        
        }
        private int Divide(int firstno, int secondno)
        {
            return firstno/secondno;
        }
    }
}
