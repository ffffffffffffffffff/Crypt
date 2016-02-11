namespace FGP2
{
    partial class ProductRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// The contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.productKeyTextBox = new System.Windows.Forms.TextBox();
            this.productKeyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.laterButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This product is not registered. Please enter the product key below to register.";
            // 
            // productKeyTextBox
            // 
            this.productKeyTextBox.Location = new System.Drawing.Point(112, 84);
            this.productKeyTextBox.Name = "productKeyTextBox";
            this.productKeyTextBox.Size = new System.Drawing.Size(268, 20);
            this.productKeyTextBox.TabIndex = 2;
            // 
            // productKeyLabel
            // 
            this.productKeyLabel.AutoSize = true;
            this.productKeyLabel.Location = new System.Drawing.Point(17, 87);
            this.productKeyLabel.Name = "productKeyLabel";
            this.productKeyLabel.Size = new System.Drawing.Size(65, 13);
            this.productKeyLabel.TabIndex = 2;
            this.productKeyLabel.Text = "Product Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(112, 49);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(268, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(175, 149);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(90, 23);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // laterButton
            // 
            this.laterButton.Location = new System.Drawing.Point(290, 149);
            this.laterButton.Name = "laterButton";
            this.laterButton.Size = new System.Drawing.Size(90, 23);
            this.laterButton.TabIndex = 4;
            this.laterButton.Text = "Later";
            this.laterButton.UseVisualStyleBackColor = true;
            this.laterButton.Click += new System.EventHandler(this.laterButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(112, 117);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 7;
            // 
            // ProductRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 206);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.laterButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productKeyLabel);
            this.Controls.Add(this.productKeyTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductRegistration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productKeyTextBox;
        private System.Windows.Forms.Label productKeyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button laterButton;
        private System.Windows.Forms.Label warningLabel;
    }
}