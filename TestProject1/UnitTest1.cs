using Xunit;
using oop_assignment_2_2025_72672.Models;

namespace oop_assignment_2_2025_72672.Tests
{
    public class ExamQuestion1_Tests
    {

        // Question 1a
        [Fact]
        public void ValidateIrishMobile_ValidNumbers_ReturnTrue()
        {
            Assert.True(ExamQuestion1.ValidateIrishMobile("0831234567"));
            Assert.True(ExamQuestion1.ValidateIrishMobile("0899988776"));
        }

        [Fact]
        public void ValidateIrishMobile_InvalidNumbers_ReturnFalse()
        {
            Assert.False(ExamQuestion1.ValidateIrishMobile("0812345678"));   
            Assert.False(ExamQuestion1.ValidateIrishMobile("083 1234567")); 
            Assert.False(ExamQuestion1.ValidateIrishMobile("08312345678")); 
        }

        // Question 1b

        [Theory]
        [InlineData("Bronze", 1)]
        [InlineData("Silver", 5)]
        [InlineData("Gold", 10)]
        [InlineData("Platinum", 15)]
        [InlineData("Diamond", 20)]
        [InlineData("Elite", 25)]
        [InlineData("VIP", 30)]
        public void GetDiscountPercentage_ValidLevels_ReturnsCorrectValue(string level, int expected)
        {
            var result = ExamQuestion1.GetDiscountPercentage(level);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("Unknown")]
        public void GetDiscountPercentage_InvalidLevels_ReturnsZero(string level)
        {
            var result = ExamQuestion1.GetDiscountPercentage(level);
            Assert.Equal(0, result);
        }
    }
}
