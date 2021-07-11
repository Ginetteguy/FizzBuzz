using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Program = new Program();
        }

        private Program Program;

        [Test]
        public void ShouldReturnOne_WhenPassingOne()
        {
            // Arrange
            const int input = 1;

            // Setup
            string result = Program.FizzBuzz(input);

            // Assert
            Assert.AreEqual("1", result);
        }
    }
}