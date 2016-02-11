using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FGP2
{
    class CustomDialog
    {
        public static string ShowPasswordDialog(string text, string caption, string prevPass)
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.Text = caption;
            prompt.ShowIcon = false;
            Label textLabel = new Label() { Left = 50, Top = 20, Width = 200, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200, UseSystemPasswordChar = true };
            textBox.Text = prevPass;
            Button confirmation = new Button() { Text = "OK", Left = 100, Width = 100, Top = 80 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.AcceptButton = confirmation;
            prompt.ActiveControl = textBox;                                           // Puts the cursor in the input text field
            prompt.ShowDialog();
            return textBox.Text;
        }

        public static void ShowAboutDialog()
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.Text = "About";
            Label textLabel = new Label() { Left = 50, Top = 20, Width = 200, Text = "Created by FlexWare Limited" };
            Button confirmation = new Button() { Text = "OK", Left = 100, Width = 100, Top = 80 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.ShowDialog();
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 400;
            prompt.Height = 150;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50, Top = 20, Width = 300, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 300, UseSystemPasswordChar = false };
            Button confirmation = new Button() { Text = "OK", Left = 150, Width = 100, Top = 80 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.AcceptButton = confirmation;
            prompt.ActiveControl = textBox; // Puts the cursor in the input text field
            prompt.ShowDialog();
            return textBox.Text;
        }
    }
}
