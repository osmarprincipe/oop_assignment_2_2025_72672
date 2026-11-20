using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace oop_assignment_2_2025_72672.Models
{
    public static class ExamQuestion1
    {
        public static void Run()
        {
            Console.WriteLine("Exam Question 1 executed.");

            // Question 1A demo
            SampleQuestionAMethod();

            // Question 1B demo
            SampleQuestionBMethod();

            Console.WriteLine(new string('*', 40));
        }

        //  Question 1A  
        public static void SampleQuestionAMethod()
        {
            Console.WriteLine("Question 1A - Regex sample");
            Console.WriteLine(ValidateIrishMobile("0899988776"));
            Console.WriteLine(ValidateIrishMobile("0812345678"));
        }

        public static bool ValidateIrishMobile(string phone)
        {
            var pattern = @"^(083|085|089)\d{7}$";
            var regex = new Regex(pattern);
            return regex.IsMatch(phone);
        }

        //  Question 1B 
        public static void SampleQuestionBMethod()
        {
            Console.WriteLine("Question 1B - Discount sample");

            Console.WriteLine($"Bronze: {GetDiscountPercentage("Bronze")}%");
            Console.WriteLine($"Silver: {GetDiscountPercentage("Silver")}%");
            Console.WriteLine($"VIP: {GetDiscountPercentage("VIP")}%");
            Console.WriteLine($"Unknown: {GetDiscountPercentage("Random")}%");
        }

        public static int GetDiscountPercentage(string level)
        {
            if (string.IsNullOrWhiteSpace(level))
            {
                return 0;
            }


            level = level.Trim();

            switch (level)
            {
                case "Bronze": return 1;
                case "Silver": return 5;
                case "Gold": return 10;
                case "Platinum": return 15;
                case "Diamond": return 20;
                case "Elite": return 25;
                case "VIP": return 30;
                default: return 0;   // unknown level
            }
        }
    }
}
