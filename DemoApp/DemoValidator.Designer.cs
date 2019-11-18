namespace DemoApp
{
    partial class DemoValidator
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
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seedCheckBox = new System.Windows.Forms.CheckBox();
            this.validFirstCheckBox = new System.Windows.Forms.CheckBox();
            this.validSecondCheckBox = new System.Windows.Forms.CheckBox();
            this.validThirdCheckBox = new System.Windows.Forms.CheckBox();
            this.validFourthCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.Text = "Key";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(3, 75);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(216, 51);
            this.keyTextBox.TabIndex = 7;
            this.keyTextBox.TextChanged += new System.EventHandler(this.ValidateKeys);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(3, 28);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(216, 21);
            this.userNameTextBox.TabIndex = 5;
            this.userNameTextBox.Text = "bob@smith.com";
            this.userNameTextBox.TextChanged += new System.EventHandler(this.ValidateKeys);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.Text = "Results";
            // 
            // seedCheckBox
            // 
            this.seedCheckBox.ThreeState = true;
            this.seedCheckBox.Checked = true;
            this.seedCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.seedCheckBox.Location = new System.Drawing.Point(4, 154);
            this.seedCheckBox.Name = "seedCheckBox";
            this.seedCheckBox.Size = new System.Drawing.Size(215, 20);
            this.seedCheckBox.TabIndex = 10;
            this.seedCheckBox.Text = "Equal seeds";
            this.seedCheckBox.Click += new System.EventHandler(this.ValidateKeys);
            this.seedCheckBox.LostFocus += new System.EventHandler(this.ValidateKeys);
            // 
            // validFirstCheckBox
            // 
            this.validFirstCheckBox.ThreeState = true;
            this.validFirstCheckBox.Checked = true;
            this.validFirstCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.validFirstCheckBox.Location = new System.Drawing.Point(4, 180);
            this.validFirstCheckBox.Name = "validFirstCheckBox";
            this.validFirstCheckBox.Size = new System.Drawing.Size(215, 20);
            this.validFirstCheckBox.TabIndex = 11;
            this.validFirstCheckBox.Text = "1st key is valid";
            this.validFirstCheckBox.Click += new System.EventHandler(this.ValidateKeys);
            this.validFirstCheckBox.LostFocus += new System.EventHandler(this.ValidateKeys);
            // 
            // validSecondCheckBox
            // 
            this.validSecondCheckBox.ThreeState = true;
            this.validSecondCheckBox.Checked = true;
            this.validSecondCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.validSecondCheckBox.Location = new System.Drawing.Point(5, 206);
            this.validSecondCheckBox.Name = "validSecondCheckBox";
            this.validSecondCheckBox.Size = new System.Drawing.Size(214, 20);
            this.validSecondCheckBox.TabIndex = 12;
            this.validSecondCheckBox.Text = "2nd key is valid";
            this.validSecondCheckBox.Click += new System.EventHandler(this.ValidateKeys);
            this.validSecondCheckBox.LostFocus += new System.EventHandler(this.ValidateKeys);
            // 
            // validThirdCheckBox
            // 
            this.validThirdCheckBox.ThreeState = true;
            this.validThirdCheckBox.Checked = true;
            this.validThirdCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.validThirdCheckBox.Location = new System.Drawing.Point(4, 232);
            this.validThirdCheckBox.Name = "validThirdCheckBox";
            this.validThirdCheckBox.Size = new System.Drawing.Size(215, 20);
            this.validThirdCheckBox.TabIndex = 13;
            this.validThirdCheckBox.Text = "3rd key is valid";
            this.validThirdCheckBox.Click += new System.EventHandler(this.ValidateKeys);
            this.validThirdCheckBox.LostFocus += new System.EventHandler(this.ValidateKeys);
            // 
            // validFourthCheckBox
            // 
            this.validFourthCheckBox.ThreeState = true;
            this.validFourthCheckBox.Checked = true;
            this.validFourthCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.validFourthCheckBox.Location = new System.Drawing.Point(3, 258);
            this.validFourthCheckBox.Name = "validFourthCheckBox";
            this.validFourthCheckBox.Size = new System.Drawing.Size(216, 20);
            this.validFourthCheckBox.TabIndex = 14;
            this.validFourthCheckBox.Text = "4th key is valid";
            this.validFourthCheckBox.Click += new System.EventHandler(this.ValidateKeys);
            this.validFourthCheckBox.LostFocus += new System.EventHandler(this.ValidateKeys);
            // 
            // DemoValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.validFourthCheckBox);
            this.Controls.Add(this.validThirdCheckBox);
            this.Controls.Add(this.validSecondCheckBox);
            this.Controls.Add(this.validFirstCheckBox);
            this.Controls.Add(this.seedCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "DemoValidator";
            this.Text = "Validation Demo";
            this.Load += new System.EventHandler(this.DemoValidator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox seedCheckBox;
        private System.Windows.Forms.CheckBox validFirstCheckBox;
        private System.Windows.Forms.CheckBox validSecondCheckBox;
        private System.Windows.Forms.CheckBox validThirdCheckBox;
        private System.Windows.Forms.CheckBox validFourthCheckBox;
    }
}