using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FGP2
{
    public partial class ProductRegistration : Form
    {
        /// <summary>
        /// Product key validation result
        /// </summary>
        public bool isValid { get; set; }

        /// <summary>
        /// Product registration form where user can enter the product key and user name 
        /// </summary>
        public ProductRegistration()
        {
            InitializeComponent();
            //registerButton.DialogResult = DialogResult.OK;
            laterButton.DialogResult = DialogResult.Cancel;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (productKeyTextBox.Text.Length == 0)
            {
                //warningLabel.Text = "Please enter the Product Key";
                MessageBox.Show("Please enter the Product Key", "Warning", MessageBoxButtons.OK);
                productKeyTextBox.Focus();
                //return;
            }

            else if (userNameTextBox.Text.Length == 0)
            {
                //warningLabel.Text = "Please enter the User Name";

                MessageBox.Show("Please enter the User Name", "Warning", MessageBoxButtons.OK);
                userNameTextBox.Focus();
                //return;
            }
            else
            {
                // Clear the warning
                warningLabel.Text = "";


                // Save the product key and username
                Properties.Settings.Default.Product_Key = productKeyTextBox.Text;
                Properties.Settings.Default.User_Name = userNameTextBox.Text;

                // Save the activation date
                DateTime now = DateTime.Now;
                string date = now.ToString(@"d/M/yyyy");
                Properties.Settings.Default.Activation_Date = date;

                // Save the settings to persist across application sessions
                Properties.Settings.Default.Save();

                // Validate the license
                isValid = new LicenseCheck().isValidProductKey();
                this.Close();
            }
        }

        private void laterButton_Click(object sender, EventArgs e)
        {
            isValid = false;
            this.Close();
        }



    }
}
