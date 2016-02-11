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
    public partial class EntropyForm : Form
    {
        public string userEntropy;

        public EntropyForm()
        {
            InitializeComponent();
        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            if (entropyTextBox.Text.Length > 5)
            {
                userEntropy = entropyTextBox.Text;
                this.DialogResult = DialogResult.OK;
            }
        }



    }
}
