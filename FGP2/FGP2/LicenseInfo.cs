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
    public partial class LicenseInfo : Form
    {
        public LicenseInfo()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Product_Key.Length > 0)
                productKeyLabel.Text = Properties.Settings.Default.Product_Key;
            else
                productKeyLabel.Text = "N/A";

            if (Properties.Settings.Default.Activation_Date.Length > 0)
                activationDateLabel.Text = Properties.Settings.Default.Activation_Date;
            else
                activationDateLabel.Text = "N/A";

        }
    }
}
