using Xunit;
using System.Collections.Generic;
using oop_assignment_2_2025_72672.Models;

namespace ExamQuestions.Tests
{
    public class ExamQuestion3Tests
    {
        [Fact]
        public void CalculateAverageRating_ReturnsCorrectAverage()
        {
            var ratings = new List<int> { 5, 4, 4, 5, 3 };
            double result = ExamQuestion3.CalculateAverageRating(ratings);

            Assert.Equal(4.2, result, 1);
        }

        [Fact]
        public void CalculateAverageRating_EmptyList_ReturnsNaN()
        {
            var ratings = new List<int>();
            double result = ExamQuestion3.CalculateAverageRating(ratings);

            Assert.True(double.IsNaN(result));
        }

        [Fact]
        public void Keyboard_HasHigherAverageThanLaptop()
        {
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop",     new List<int>{ 5, 4, 4, 5, 3 }),
                ("Headphones", new List<int>{ 4, 3, 5 }),
                ("Keyboard",   new List<int>{ 5, 5, 5, 4 }),
                ("Mouse",      new List<int>{ 3, 3, 4 })
            };

            double laptopAvg = ExamQuestion3.CalculateAverageRating(products[0].Ratings);
            double keyboardAvg = ExamQuestion3.CalculateAverageRating(products[2].Ratings);

            Assert.True(keyboardAvg > laptopAvg);
        }
    }
}
