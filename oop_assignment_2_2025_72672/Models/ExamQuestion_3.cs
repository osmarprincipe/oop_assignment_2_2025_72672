using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2_2025_72672.Models
{
    public static class ExamQuestion3
    {
        public static void Run()
        {
            Console.WriteLine("Exam Question 3 executed.");

            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop",     new List<int>{ 5, 4, 4, 5, 3 }),
                ("Headphones", new List<int>{ 4, 3, 5 }),
                ("Keyboard",   new List<int>{ 5, 5, 5, 4 }),
                ("Mouse",      new List<int>{ 3, 3, 4 })
            };

            ProcessProducts(products);
            Console.WriteLine(new string('*', 40));
        }


        public static void ProcessProducts(List<(string Name, List<int> Ratings)> products)
        {
            double highestAvg = double.MinValue;
            string topProduct = "";

            foreach (var product in products)
            {
                double avg = CalculateAverageRating(product.Ratings);

                if (double.IsNaN(avg))
                {
                    Console.WriteLine($"{product.Name}: No ratings available");
                }
                else
                {
                    Console.WriteLine($"{product.Name}: Average Rating = {avg:F1}");
                    if (avg > highestAvg)
                    {
                        highestAvg = avg;
                        topProduct = product.Name;
                    }
                }
            }

            if (highestAvg > 0)
            {
                Console.WriteLine(
                    $"\nThe top-rated product is {topProduct} with an average rating of {highestAvg:F1}"
                );
            }
        }


        public static double CalculateAverageRating(List<int> ratings)
        {
            if (ratings == null || ratings.Count == 0)
                return double.NaN; // signals "no ratings"

            return ratings.Average();
        }
    }
}
