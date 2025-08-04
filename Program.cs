using System.ComponentModel.DataAnnotations;

namespace Assignment5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is" +
                "a palindrome or not: ");
            Console.WriteLine();
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPalindrome = true;
            bool notPalindrome = false;


            if (number < 0)
            {
                Console.WriteLine("A negative number cannot be a palindrome.");
                return;
            }
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0) // Loop to reverse the number
            {
                int digit = number % 10; // Get the last digit
                reversedNumber = (reversedNumber * 10) + digit; // Append it to the reversed number
                number /= 10; // Remove the last digit from the original number
            }
            
            if (originalNumber == reversedNumber) //check if the original number is a palindrome
            {
                Console.WriteLine($"{isPalindrome}");
            }
            else
            {
                Console.WriteLine($"{notPalindrome}");
            }
        }
    }
}
