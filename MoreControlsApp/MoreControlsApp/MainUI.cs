using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreControlsApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string selectedFoodItem = "";
            if (periRadioButton.Checked)
            {
                selectedFoodItem = periRadioButton.Text;
            }
            if (chocolateRadioButton.Checked)
            {
                selectedFoodItem = chocolateRadioButton.Text;
            }
            if (dalRadioButton.Checked)
            {
                selectedFoodItem = dalRadioButton.Text;
            }
            if (mirindaRadioButton.Checked)
            {
                selectedFoodItem = mirindaRadioButton.Text;
            }

            MessageBox.Show(selectedFoodItem, "Selected Food Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showCheckButton_Click(object sender, EventArgs e)
        {

        }

        private void showComboButton_Click(object sender, EventArgs e)
        {

        }
    }
}
