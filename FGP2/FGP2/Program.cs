using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FGP2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check if the license is valid
            if (new LicenseCheck().isValidProductKey())
            {
                System.Diagnostics.Debug.WriteLine("Valid product key");
                Application.Run(new MainForm());
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Invalid product key");

                // Open the product registration form
                using (var form = new ProductRegistration())
                {
                    form.ShowDialog();
                    
                    if (form.isValid)
                    {
                        MessageBox.Show("Thank you for registering!", "Registration Complete", MessageBoxButtons.OK);
                        Application.Run(new MainForm());
                    }
                    else
                    {
                        MessageBox.Show("The product key is invalid. Please try again.", 
                            "Registration Error", 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        Application.Exit();
                    }

                    
                }
            }
        }
    }
}
