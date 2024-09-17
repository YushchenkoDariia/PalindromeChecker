using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PalindromeChecker
{
    public class PalindromeChecker
    {
 
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            // Очистка рядка від зайвих символів
            string cleanedInput = CleanInput(input);

            // Порівняння очищеного рядка з його реверсією
            return cleanedInput.Equals(ReverseString(cleanedInput), StringComparison.OrdinalIgnoreCase);
        }

        // Метод для очищення введеного рядка від пробілів, розділових знаків та інших символів
        private string CleanInput(string input)
        {
            return Regex.Replace(input, @"[^\p{L}\p{Nd}]+", "").ToLower();
        }

        // Метод для реверсії рядка
        private string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }



}
