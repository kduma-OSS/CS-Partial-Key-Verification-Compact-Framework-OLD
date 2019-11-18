namespace DemoApp
{
    partial class Keygen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.testValidationMenuItem = new System.Windows.Forms.MenuItem();
            this.invalidTestMenuItem = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // testValidationMenuItem
            // 
            this.testValidationMenuItem.Text = "Test Validation";
            // 
            // invalidTestMenuItem
            // 
            this.invalidTestMenuItem.Text = "Invalid Test";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.Text = "User Name";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(4, 27);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(233, 21);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.Text = "bob@smith.com";
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(4, 77);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.ReadOnly = true;
            this.seedTextBox.Size = new System.Drawing.Size(233, 21);
            this.seedTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.Text = "Seed";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.Text = "Generated Key";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(4, 127);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.Size = new System.Drawing.Size(233, 51);
            this.keyTextBox.TabIndex = 1;
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Test Validation";
            this.menuItem1.Click += new System.EventHandler(this.testValidationMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Invalid Test";
            this.menuItem2.Click += new System.EventHandler(this.invalidTestMenuItem_Click);
            // 
            // Keygen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.seedTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Keygen";
            this.Text = "Key Generator";
            this.Load += new System.EventHandler(this.Keygen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox seedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.MenuItem testValidationMenuItem;
        private System.Windows.Forms.MenuItem invalidTestMenuItem;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}

