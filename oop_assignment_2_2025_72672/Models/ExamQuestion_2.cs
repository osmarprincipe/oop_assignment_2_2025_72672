using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2_2025_72672.Models
{
    public static class ExamQuestion2
    {
        public static void Run()
        {
            Console.WriteLine("Exam Question 2 executed.");

            // 2A examples
            Console.WriteLine("2A:");
            Console.WriteLine(SafeDivide(10, 0));

            // 2B examples
            Console.WriteLine("2B:");
            Console.WriteLine(ParseNumber("123"));
            Console.WriteLine(ParseNumber("abc"));

            // 2C examples
            Console.WriteLine("2C:");
            Console.WriteLine(RegisterUser(25));
            Console.WriteLine(RegisterUser(15));

            Console.WriteLine(new string('*', 40));

        }

        // Question 2.A
        public static string SafeDivide(int a, int b)
        {
            try
            {
                int result = a / b;
                return result.ToString();
            }
            catch (DivideByZeroException)
            {
                return "Cannot divide by zero.";
            }
        }

        // Question 2.B
        public static string ParseNumber(string input)
        {
            try
            {
                int value = int.Parse(input);
                return value.ToString();
            }
            catch (FormatException)
            {
                return "Invalid number entered.";
            }
            catch (OverflowException)
            {
                return "Invalid number entered.";
            }
        }

        // Question 2.C 

        public static string RegisterUser(int age)
        {
            try
            {
                if (age < 18)
                {
                    throw new ArgumentOutOfRangeException(nameof(age),
                        "User must be at least 18 to register.");
                }

                return "Registration successful.";
            }
            catch (ArgumentOutOfRangeException)
            {
                return "User must be at least 18 to register.";
            }
        }
    }
}
