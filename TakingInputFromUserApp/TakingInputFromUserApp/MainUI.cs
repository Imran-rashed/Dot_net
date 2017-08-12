using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakingInputFromUserApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //string message = messageTextBox.Text;
            //messageTextBox.Text = "";
            ////messageTextBox.Text = String.Empty;
            ////messageTextBox.Text = string.Empty;
            ////messageTextBox.Clear();
            ////MessageBox.Show(message, "Your Given Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //messageLabel.Text = message;

            int number = Convert.ToInt32(messageTextBox.Text);
            messageTextBox.Clear();
            messageLabel.Text = number.ToString();

            int sum = 0;

            numbersListBox.Items.Clear();

            for (int i = 1; i <= number; i++)
            {
                numbersListBox.Items.Add(i);
                sum += i;
            }
            sumLabel.Text = sum.ToString();
        }
    }
}
