using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPP_PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        const string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        const string digits = "0123456789";
        const string symbols = "!@#$%^&?*()_-+=<>";

        public PasswordGenerator()
        {
            InitializeComponent();

            len8.CheckedChanged += checkedChanged;
            len8_14.CheckedChanged += checkedChanged;
            len14_20.CheckedChanged += checkedChanged;
            lenInput.TextChanged += checkedChanged;
            useUppCase.CheckedChanged += checkedChanged;
            useLowCase.CheckedChanged += checkedChanged;
            useDigits.CheckedChanged += checkedChanged;
            useSymbols.CheckedChanged += checkedChanged;
        }

        private void GeneratePassword()
        {
            generatedPassword.Enabled = true;

            StringBuilder unmixedPassword = new StringBuilder();
            string allSymbols = "";
            int i = 0;
            int length;
            Random rnd = new Random();

            if (len8.Checked) length = 8;
            else if (len8_14.Checked) length = rnd.Next(8, 14);
            else if (len14_20.Checked) length = rnd.Next(14, 20);
            else
            {
                if (!int.TryParse(lenInput.Text, out length)) return;
                else length = int.Parse(lenInput.Text);
            }

            if (useUppCase.Checked)
            {
                unmixedPassword.Append(uppercaseLetters[rnd.Next(uppercaseLetters.Length)]);
                allSymbols += uppercaseLetters;
                i++;
            }
            if (useLowCase.Checked)
            {
                unmixedPassword.Append(lowercaseLetters[rnd.Next(lowercaseLetters.Length)]);
                allSymbols += lowercaseLetters;
                i++;
            }
            if (useDigits.Checked)
            {
                unmixedPassword.Append(digits[rnd.Next(digits.Length)]);
                allSymbols += digits;
                i++;
            }
            if (useSymbols.Checked)
            {
                unmixedPassword.Append(symbols[rnd.Next(symbols.Length)]);
                allSymbols += symbols;
                i++;
            }

            for (int i1 = i; i1 <= length; i1++) unmixedPassword.Append(allSymbols[rnd.Next(allSymbols.Length)]);

            char[] mixedPassword = unmixedPassword.ToString().ToCharArray();
            for (int j = mixedPassword.Length - 1; j > 0; j--)
            {
                int k = rnd.Next(j + 1);
                char temp = mixedPassword[j];
                mixedPassword[j] = mixedPassword[k];
                mixedPassword[k] = temp;
            }
            
            generatedPassword.Text = new string(mixedPassword);
        }

        private void lenInput_MouseClick(object sender, MouseEventArgs e)
        {
            len8.Checked = false;
            len8_14.Checked = false;
            len14_20.Checked = false;
        }

        private void checkedChanged(object sender, EventArgs e)
        {
            if (lenInput.Text != "" && (len8.Checked || len8_14.Checked || len14_20.Checked)) lenInput.Text = "";
            if (len8.Checked || len8_14.Checked || len14_20.Checked || lenInput.Text != "")
            {
                if (useUppCase.Checked || useLowCase.Checked || useDigits.Checked || useSymbols.Checked)
                {
                    generatePassword.Enabled = true;
                }
                else generatePassword.Enabled = false;
            } 
            else generatePassword.Enabled = false;
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            generatedPassword.Enabled = false;
            generatePassword.Enabled = false;
        }

        private void generatePassword_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }
    }
}
