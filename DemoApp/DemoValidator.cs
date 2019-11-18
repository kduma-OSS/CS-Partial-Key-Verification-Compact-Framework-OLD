using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PartialKeyVerification;
using PartialKeyVerification.Checksum;
using PartialKeyVerification.Hash;

namespace DemoApp
{
    public partial class DemoValidator : Form
    {
        public string UserName { get; private set; }
        public string Key { get; private set; }

        public DemoValidator(string userName, string key)
        {
            UserName = userName;
            Key = key;
            InitializeComponent();
        }

        private void DemoValidator_Load(object sender, EventArgs e)
        {
            keyTextBox.Text = Key;
            userNameTextBox.Text = UserName;

            ValidateKeys();
        }

        private void ValidateKeys(object sender, EventArgs e)
        {
            ValidateKeys();
        }

        private void ValidateKeys()
        {
            try
            {
                validFirstCheckBox.CheckState = PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(),
                    keyTextBox.Text, 0, 1)
                    ? CheckState.Checked
                    : CheckState.Unchecked;

                validSecondCheckBox.CheckState = PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(),
                    keyTextBox.Text, 1, 2)
                    ? CheckState.Checked
                    : CheckState.Unchecked;

                validThirdCheckBox.CheckState = PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(),
                    keyTextBox.Text, 2, 3)
                    ? CheckState.Checked
                    : CheckState.Unchecked;

                validFourthCheckBox.CheckState = PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(),
                    keyTextBox.Text, 3, 4)
                    ? CheckState.Checked
                    : CheckState.Unchecked;

                seedCheckBox.CheckState = PartialKeyValidator.GetSerialNumberFromKey(keyTextBox.Text) ==
                                          PartialKeyValidator.GetSerialNumberFromSeed(userNameTextBox.Text)
                    ? CheckState.Checked
                    : CheckState.Unchecked;
            }
            catch (Exception)
            {
                validFirstCheckBox.CheckState = CheckState.Unchecked;
                validSecondCheckBox.CheckState = CheckState.Unchecked;
                validThirdCheckBox.CheckState = CheckState.Unchecked;
                validFourthCheckBox.CheckState = CheckState.Unchecked;
                seedCheckBox.CheckState = CheckState.Unchecked;
            }
        }
    }
}