using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace _15122022HomeExercise
{
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        private void buttonGeneratePassword_Click(object sender, EventArgs e)
        {
            textBoxPasswords.Clear();
            string __PasswordLong = "";
            string __Password = "";
            int __PasswordLength = (int)numericUpDownPasswordLength.Value;
            int __PasswordNumber = (int)numericUpDownPasswordNumber.Value;
            Random __Random = new Random();
            if (checkBoxUpperCase.Checked || checkBoxLowerCase.Checked || checkBoxNumeric.Checked || checkBoxSpecial.Checked)
            {
                if (checkBoxUpperCase.Checked)
                {
                    for (int i = 65; i < 91; i++)
                    {
                        __PasswordLong += Convert.ToChar(i);
                    }
                }
                if (checkBoxLowerCase.Checked)
                {
                    for (int i = 97; i < 123; i++)
                    {
                        __PasswordLong += Convert.ToChar(i);
                    }
                }
                if (checkBoxNumeric.Checked)
                {
                    for (int i = 48; i < 57; i++)
                    {
                        __PasswordLong += Convert.ToChar(i);
                    }
                }
                if (checkBoxSpecial.Checked)
                {
                    for (int i = 33; i < 48; i++)
                    {
                        __PasswordLong += Convert.ToChar(i);
                    }
                    for (int i = 58; i < 65; i++)
                    {
                        __PasswordLong += Convert.ToChar(i);
                    }
                    for (int i = 91; i < 97; i++)
                    {
                        __PasswordLong += Convert.ToChar(i);
                    }
                    for (int i = 123; i < 127; i++)
                    {
                        __PasswordLong += Convert.ToChar(i);
                    }
                }
                for (int i = 0; i < __PasswordNumber; i++)
                {
                    __Password = "";
                    while ((checkBoxUpperCase.Checked && !__Password.Any(char.IsUpper)) || (checkBoxLowerCase.Checked && !__Password.Any(char.IsLower)) || (checkBoxNumeric.Checked && !__Password.Any(char.IsDigit)) || (checkBoxSpecial.Checked && __Password.All(char.IsLetterOrDigit)))
                    {
                        __Password = "";
                        for (int j = 0; j < __PasswordLength; j++)
                        {
                            __Password += __PasswordLong[__Random.Next(__PasswordLong.Length)];
                        }
                    }
                    textBoxPasswords.Text += __Password;
                    textBoxPasswords.Text += "\r\n\r\n";
                }
            }
            else
            {
                MessageBox.Show("Please choose at least one options!");
            }
        }
    }
}
