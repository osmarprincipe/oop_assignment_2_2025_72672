using Xunit;
using oop_assignment_2_2025_72672.Models;

namespace TestProject1
{
    public class ExamQuestion4_Tests
    {
        //Question 4A 

        [Fact]
        public void FormatFiveDigits_PadsWithZeros()
        {
            string result = ExamQuestion4.FormatFiveDigits(42);
            Assert.Equal("00042", result);
        }

        [Fact]
        public void FormatFiveDigits_AlreadyFiveDigits_NoChange()
        {
            string result = ExamQuestion4.FormatFiveDigits(12345);
            Assert.Equal("12345", result);
        }

        //Question 4B

        [Fact]
        public void FormatPrice_FormatsWithEuroSymbolAndTwoDecimals()
        {
            string result = ExamQuestion4.FormatPrice(1234.5);
            Assert.Equal("€1,234.50", result);
        }

        [Fact]
        public void FormatPrice_FormatsSmallValuesCorrectly()
        {
            string result = ExamQuestion4.FormatPrice(50);
            Assert.Equal("€50.00", result);
        }
    }
}
