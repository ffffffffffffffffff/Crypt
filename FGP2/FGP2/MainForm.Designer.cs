namespace FGP2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.encryptFileButton = new System.Windows.Forms.Button();
            this.FileDecryptionGroupBox = new System.Windows.Forms.GroupBox();
            this.decryptFileProgressBar = new System.Windows.Forms.ProgressBar();
            this.DecryptFileButton = new System.Windows.Forms.Button();
            this.fileOpened2 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.decryptTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptTextBox = new System.Windows.Forms.RichTextBox();
            this.messageBox = new System.Windows.Forms.ListBox();
            this.ECMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.PlainTextLabel = new System.Windows.Forms.Label();
            this.EncryptedTextLabel = new System.Windows.Forms.Label();
            this.clearEncryptBox = new System.Windows.Forms.Button();
            this.clearDecryptBox = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateKeyBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.FakeMessageButton = new System.Windows.Forms.Button();
            this.NewPasswordButton = new System.Windows.Forms.Button();
            this.ECPadGroupBox = new System.Windows.Forms.GroupBox();
            this.FileEncryptionGroupBox = new System.Windows.Forms.GroupBox();
            this.encryptFileProgressBar = new System.Windows.Forms.ProgressBar();
            this.fileOpened = new System.Windows.Forms.Label();
            this.exportPadBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.FileDecryptionGroupBox.SuspendLayout();
            this.ECMessageGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.FileEncryptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // encryptFileButton
            // 
            this.encryptFileButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptFileButton.Location = new System.Drawing.Point(6, 19);
            this.encryptFileButton.Margin = new System.Windows.Forms.Padding(3, 8, 3, 2);
            this.encryptFileButton.Name = "encryptFileButton";
            this.encryptFileButton.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.encryptFileButton.Size = new System.Drawing.Size(114, 36);
            this.encryptFileButton.TabIndex = 0;
            this.encryptFileButton.Text = "Encrypt File";
            this.encryptFileButton.UseVisualStyleBackColor = true;
            this.encryptFileButton.Click += new System.EventHandler(this.OpenEncryptFile_Click);
            // 
            // FileDecryptionGroupBox
            // 
            this.FileDecryptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FileDecryptionGroupBox.Controls.Add(this.decryptFileProgressBar);
            this.FileDecryptionGroupBox.Controls.Add(this.DecryptFileButton);
            this.FileDecryptionGroupBox.Controls.Add(this.fileOpened2);
            this.FileDecryptionGroupBox.Location = new System.Drawing.Point(476, 292);
            this.FileDecryptionGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileDecryptionGroupBox.Name = "FileDecryptionGroupBox";
            this.FileDecryptionGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileDecryptionGroupBox.Size = new System.Drawing.Size(450, 62);
            this.FileDecryptionGroupBox.TabIndex = 7;
            this.FileDecryptionGroupBox.TabStop = false;
            this.FileDecryptionGroupBox.Text = "File Decryption";
            // 
            // decryptFileProgressBar
            // 
            this.decryptFileProgressBar.Location = new System.Drawing.Point(130, 33);
            this.decryptFileProgressBar.Name = "decryptFileProgressBar";
            this.decryptFileProgressBar.Size = new System.Drawing.Size(310, 20);
            this.decryptFileProgressBar.TabIndex = 4;
            // 
            // DecryptFileButton
            // 
            this.DecryptFileButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptFileButton.Location = new System.Drawing.Point(6, 19);
            this.DecryptFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DecryptFileButton.Name = "DecryptFileButton";
            this.DecryptFileButton.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.DecryptFileButton.Size = new System.Drawing.Size(114, 36);
            this.DecryptFileButton.TabIndex = 0;
            this.DecryptFileButton.Text = "Decrypt File";
            this.DecryptFileButton.UseVisualStyleBackColor = true;
            this.DecryptFileButton.Click += new System.EventHandler(this.OpenDecryptFile_Click);
            // 
            // fileOpened2
            // 
            this.fileOpened2.AutoSize = true;
            this.fileOpened2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileOpened2.Location = new System.Drawing.Point(130, 17);
            this.fileOpened2.MaximumSize = new System.Drawing.Size(325, 0);
            this.fileOpened2.Name = "fileOpened2";
            this.fileOpened2.Size = new System.Drawing.Size(36, 13);
            this.fileOpened2.TabIndex = 3;
            this.fileOpened2.Text = "None";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EncryptButton.AutoSize = true;
            this.EncryptButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.Location = new System.Drawing.Point(334, 6);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(120, 30);
            this.EncryptButton.TabIndex = 12;
            this.EncryptButton.Text = "Encrypt ==>";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DecryptButton.AutoSize = true;
            this.DecryptButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptButton.Location = new System.Drawing.Point(476, 6);
            this.DecryptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(120, 30);
            this.DecryptButton.TabIndex = 13;
            this.DecryptButton.Text = "<== Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // decryptTextBox
            // 
            this.decryptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptTextBox.Location = new System.Drawing.Point(476, 40);
            this.decryptTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decryptTextBox.MaxLength = 31000;
            this.decryptTextBox.MinimumSize = new System.Drawing.Size(450, 250);
            this.decryptTextBox.Name = "decryptTextBox";
            this.decryptTextBox.Size = new System.Drawing.Size(450, 250);
            this.decryptTextBox.TabIndex = 15;
            this.decryptTextBox.Text = "";
            // 
            // encryptTextBox
            // 
            this.encryptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.encryptTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptTextBox.Location = new System.Drawing.Point(5, 40);
            this.encryptTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encryptTextBox.MaxLength = 10000;
            this.encryptTextBox.MinimumSize = new System.Drawing.Size(450, 250);
            this.encryptTextBox.Name = "encryptTextBox";
            this.encryptTextBox.Size = new System.Drawing.Size(450, 250);
            this.encryptTextBox.TabIndex = 16;
            this.encryptTextBox.Text = "";
            // 
            // messageBox
            // 
            this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.FormattingEnabled = true;
            this.messageBox.HorizontalScrollbar = true;
            this.messageBox.ItemHeight = 15;
            this.messageBox.Location = new System.Drawing.Point(3, 17);
            this.messageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(440, 94);
            this.messageBox.TabIndex = 17;
            // 
            // ECMessageGroupBox
            // 
            this.ECMessageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ECMessageGroupBox.AutoSize = true;
            this.ECMessageGroupBox.Controls.Add(this.messageBox);
            this.ECMessageGroupBox.Location = new System.Drawing.Point(5, 365);
            this.ECMessageGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ECMessageGroupBox.MinimumSize = new System.Drawing.Size(444, 131);
            this.ECMessageGroupBox.Name = "ECMessageGroupBox";
            this.ECMessageGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ECMessageGroupBox.Size = new System.Drawing.Size(449, 131);
            this.ECMessageGroupBox.TabIndex = 19;
            this.ECMessageGroupBox.TabStop = false;
            this.ECMessageGroupBox.Text = "Messages";
            // 
            // PlainTextLabel
            // 
            this.PlainTextLabel.AutoSize = true;
            this.PlainTextLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainTextLabel.Location = new System.Drawing.Point(144, 10);
            this.PlainTextLabel.Name = "PlainTextLabel";
            this.PlainTextLabel.Size = new System.Drawing.Size(120, 23);
            this.PlainTextLabel.TabIndex = 21;
            this.PlainTextLabel.Text = "Plain Text";
            // 
            // EncryptedTextLabel
            // 
            this.EncryptedTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EncryptedTextLabel.AutoSize = true;
            this.EncryptedTextLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptedTextLabel.Location = new System.Drawing.Point(632, 10);
            this.EncryptedTextLabel.Name = "EncryptedTextLabel";
            this.EncryptedTextLabel.Size = new System.Drawing.Size(172, 23);
            this.EncryptedTextLabel.TabIndex = 22;
            this.EncryptedTextLabel.Text = "Encrypted Text";
            // 
            // clearEncryptBox
            // 
            this.clearEncryptBox.Location = new System.Drawing.Point(5, 10);
            this.clearEncryptBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearEncryptBox.Name = "clearEncryptBox";
            this.clearEncryptBox.Size = new System.Drawing.Size(60, 24);
            this.clearEncryptBox.TabIndex = 23;
            this.clearEncryptBox.Text = "Clear";
            this.clearEncryptBox.UseVisualStyleBackColor = true;
            this.clearEncryptBox.Click += new System.EventHandler(this.clearEncryptBox_Click);
            // 
            // clearDecryptBox
            // 
            this.clearDecryptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearDecryptBox.Location = new System.Drawing.Point(867, 10);
            this.clearDecryptBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearDecryptBox.Name = "clearDecryptBox";
            this.clearDecryptBox.Size = new System.Drawing.Size(60, 24);
            this.clearDecryptBox.TabIndex = 24;
            this.clearDecryptBox.Text = "Clear";
            this.clearDecryptBox.UseVisualStyleBackColor = true;
            this.clearDecryptBox.Click += new System.EventHandler(this.clearDecryptBox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.licenseInfoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.helpToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // licenseInfoToolStripMenuItem
            // 
            this.licenseInfoToolStripMenuItem.Name = "licenseInfoToolStripMenuItem";
            this.licenseInfoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.licenseInfoToolStripMenuItem.Text = "License Info";
            this.licenseInfoToolStripMenuItem.Click += new System.EventHandler(this.licenseInfoToolStripMenuItem_Click);
            // 
            // generateKeyBackgroundWorker
            // 
            this.generateKeyBackgroundWorker.WorkerReportsProgress = true;
            this.generateKeyBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.generateKeyBackgroundWorker_DoWork);
            this.generateKeyBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.generateKeyBackgroundWorker_ProgressChanged);
            this.generateKeyBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.generateKeyBackgroundWorker_Completed);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.MainTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 530);
            this.tabControl1.TabIndex = 30;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.SizeChanged += new System.EventHandler(this.tabControl1_SizeChanged);
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.FakeMessageButton);
            this.MainTabPage.Controls.Add(this.NewPasswordButton);
            this.MainTabPage.Controls.Add(this.ECPadGroupBox);
            this.MainTabPage.Controls.Add(this.ECMessageGroupBox);
            this.MainTabPage.Controls.Add(this.clearEncryptBox);
            this.MainTabPage.Controls.Add(this.FileDecryptionGroupBox);
            this.MainTabPage.Controls.Add(this.FileEncryptionGroupBox);
            this.MainTabPage.Controls.Add(this.encryptTextBox);
            this.MainTabPage.Controls.Add(this.clearDecryptBox);
            this.MainTabPage.Controls.Add(this.EncryptedTextLabel);
            this.MainTabPage.Controls.Add(this.PlainTextLabel);
            this.MainTabPage.Controls.Add(this.EncryptButton);
            this.MainTabPage.Controls.Add(this.DecryptButton);
            this.MainTabPage.Controls.Add(this.decryptTextBox);
            this.MainTabPage.Location = new System.Drawing.Point(4, 25);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(932, 501);
            this.MainTabPage.TabIndex = 1;
            this.MainTabPage.Text = "Encryption/Decryption";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // FakeMessageButton
            // 
            //AL NOTE changed the anchor to allow proper resizing of window.
            this.FakeMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(( System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FakeMessageButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakeMessageButton.Location = new System.Drawing.Point(766, 374);  
            this.FakeMessageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FakeMessageButton.Name = "FakeMessageButton";
            this.FakeMessageButton.Size = new System.Drawing.Size(150, 36);
            this.FakeMessageButton.TabIndex = 32;
            this.FakeMessageButton.Text = "Fake Message";
            this.FakeMessageButton.UseVisualStyleBackColor = true;
            this.FakeMessageButton.Click += new System.EventHandler(this.FakeMessageButton_Click);
            // 
            // NewPasswordButton
            // 
            // AL NOTE changed the anchor to allow proper resizing of window.
            this.NewPasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)( System.Windows.Forms.AnchorStyles.Bottom));
            this.NewPasswordButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordButton.Location = new System.Drawing.Point(482, 374);       
            this.NewPasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewPasswordButton.Name = "NewPasswordButton";      
            this.NewPasswordButton.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.NewPasswordButton.Size = new System.Drawing.Size(200, 36);
            this.NewPasswordButton.TabIndex = 31;
            this.NewPasswordButton.Text = "Re-Enter Password";
            this.NewPasswordButton.UseVisualStyleBackColor = true;
            this.NewPasswordButton.Click += new System.EventHandler(this.NewPassword_Click);
            // 
            // ECPadGroupBox
            // 
            this.ECPadGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ECPadGroupBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECPadGroupBox.Location = new System.Drawing.Point(476, 414);
            this.ECPadGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ECPadGroupBox.Name = "ECPadGroupBox";
            this.ECPadGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ECPadGroupBox.Size = new System.Drawing.Size(450, 82);
            this.ECPadGroupBox.TabIndex = 30;
            this.ECPadGroupBox.TabStop = false;
            // 
            // FileEncryptionGroupBox
            // 
            this.FileEncryptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileEncryptionGroupBox.Controls.Add(this.encryptFileProgressBar);
            this.FileEncryptionGroupBox.Controls.Add(this.encryptFileButton);
            this.FileEncryptionGroupBox.Controls.Add(this.fileOpened);
            this.FileEncryptionGroupBox.Location = new System.Drawing.Point(5, 292);
            this.FileEncryptionGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileEncryptionGroupBox.Name = "FileEncryptionGroupBox";
            this.FileEncryptionGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileEncryptionGroupBox.Size = new System.Drawing.Size(450, 62);
            this.FileEncryptionGroupBox.TabIndex = 5;
            this.FileEncryptionGroupBox.TabStop = false;
            this.FileEncryptionGroupBox.Text = "File Encryption";
            // 
            // encryptFileProgressBar
            // 
            this.encryptFileProgressBar.Location = new System.Drawing.Point(130, 33);
            this.encryptFileProgressBar.Name = "encryptFileProgressBar";
            this.encryptFileProgressBar.Size = new System.Drawing.Size(310, 20);
            this.encryptFileProgressBar.TabIndex = 4;
            // 
            // fileOpened
            // 
            this.fileOpened.AutoSize = true;
            this.fileOpened.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileOpened.Location = new System.Drawing.Point(130, 17);
            this.fileOpened.MaximumSize = new System.Drawing.Size(326, 0);
            this.fileOpened.Name = "fileOpened";
            this.fileOpened.Size = new System.Drawing.Size(36, 13);
            this.fileOpened.TabIndex = 3;
            this.fileOpened.Text = "None";
            // 
            // exportPadBackgroundWorker
            // 
            this.exportPadBackgroundWorker.WorkerReportsProgress = true;
            this.exportPadBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.exportPadBackgroundWorker_DoWork);
            this.exportPadBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.exportPadBackgroundWorker_ProgressChanged);
            this.exportPadBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.exportPadBackgroundWorker_RunWorkerCompleted);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "help.htm";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 562);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(970, 600);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FileDecryptionGroupBox.ResumeLayout(false);
            this.FileDecryptionGroupBox.PerformLayout();
            this.ECMessageGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.MainTabPage.ResumeLayout(false);
            this.MainTabPage.PerformLayout();
            this.FileEncryptionGroupBox.ResumeLayout(false);
            this.FileEncryptionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptFileButton;
        private System.Windows.Forms.GroupBox FileDecryptionGroupBox;
        private System.Windows.Forms.Button DecryptFileButton;
        private System.Windows.Forms.Label fileOpened2;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.RichTextBox decryptTextBox;
        private System.Windows.Forms.RichTextBox encryptTextBox;
        private System.Windows.Forms.ListBox messageBox;
        private System.Windows.Forms.GroupBox ECMessageGroupBox;
        private System.Windows.Forms.Label PlainTextLabel;
        private System.Windows.Forms.Label EncryptedTextLabel;
        private System.Windows.Forms.Button clearEncryptBox;
        private System.Windows.Forms.Button clearDecryptBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker generateKeyBackgroundWorker;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainTabPage;
        private System.Windows.Forms.GroupBox ECPadGroupBox;
        private System.Windows.Forms.ProgressBar decryptFileProgressBar;
        private System.Windows.Forms.GroupBox FileEncryptionGroupBox;
        private System.Windows.Forms.ProgressBar encryptFileProgressBar;
        private System.Windows.Forms.Label fileOpened;
        private System.ComponentModel.BackgroundWorker exportPadBackgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem licenseInfoToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button NewPasswordButton;
        private System.Windows.Forms.Button FakeMessageButton;

    }
}

