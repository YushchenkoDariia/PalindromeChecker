using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;  // Потрібно для використання Regex

namespace PalindromeChecker
{
    public partial class Form1 : Form
    {
        private PalindromeChecker checker;  // Оголошення змінної

        public Form1()
        {
            InitializeComponent();
            checker = new PalindromeChecker();  // Ініціалізація змінної
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            if (checker.IsPalindrome(input))
            {
                lblResult.Text = "Це паліндром!";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResult.Text = "Це не паліндром.";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}