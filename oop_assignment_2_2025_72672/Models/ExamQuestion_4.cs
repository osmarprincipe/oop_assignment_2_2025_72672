using oop_assignment_2_2025_72672.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace oop_assignment_2_2025_72672.Models
{
    public static class ExamQuestion4
    {
        public static void Run()
        {
            Console.WriteLine("Exam Question 4 executed.");

            // Question 4A examples
            Console.WriteLine("4A:");
            Console.WriteLine(FormatFiveDigits(42));   
            Console.WriteLine(FormatFiveDigits(123));  

            // Question 4B examples
            Console.WriteLine("4B:");
            Console.WriteLine(FormatPrice(1234.5)); 
            Console.WriteLine(FormatPrice(50));     
            Console.WriteLine(new string('*', 40));
        }

        //Question 4A
        public static string FormatFiveDigits(int number)
        {
            
            return number.ToString("D5");
        }

        //Question 4B
        public static string FormatPrice(double price)
        {
            return price.ToString("€#,0.00", CultureInfo.InvariantCulture);
        }
    }
}
