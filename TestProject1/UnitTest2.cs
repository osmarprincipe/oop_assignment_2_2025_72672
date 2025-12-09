using Xunit;
using oop_assignment_2_2025_72672.Models;

namespace oop_assignment_2_2025_72672.Tests
{
    public class ExamQuestion2_Tests
    {
        //Question 2A
        [Fact]
        public void SafeDivide_ValidNumbers_ReturnsResult()
        {
            var result = ExamQuestion2.SafeDivide(10, 2);
            Assert.Equal("5", result);
        }

        [Fact]
        public void SafeDivide_DivideByZero_ReturnsErrorMessage()
        {
            var result = ExamQuestion2.SafeDivide(10, 0);
            Assert.Equal("Cannot divide by zero.", result);
        }

        //Question 2B
        [Fact]
        public void ParseNumber_ValidInput_ReturnsSameString()
        {
            var result = ExamQuestion2.ParseNumber("123");
            Assert.Equal("123", result);
        }

        [Fact]
        public void ParseNumber_InvalidInput_ReturnsErrorMessage()
        {
            var result = ExamQuestion2.ParseNumber("abc");
            Assert.Equal("Invalid number entered.", result);
        }

        //Question 2C
        [Fact]
        public void RegisterUser_ValidAge_ReturnsSuccess()
        {
            var result = ExamQuestion2.RegisterUser(25);
            Assert.Equal("Registration successful.", result);
        }

        [Fact]
        public void RegisterUser_TooYoung_ReturnsError()
        {
            var result = ExamQuestion2.RegisterUser(15);
            Assert.Equal("User must be at least 18 to register.", result);
        }
    }
}
