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

        [Test]
        public void ShouldReturnTwo_WhenPassingTwo()
        {
            // Arrange
            const int input = 2;

            // Setup
            string result = Program.FizzBuzz(input);

            // Assert
            Assert.AreEqual("2", result);
        }

        [Test]
        public void ShouldReturnFizz_WhenPassingThree()
        {
            // Arrange
            const int input = 3;

            // Setup
            string result = Program.FizzBuzz(input);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void ShouldReturnFizz_WhenPassingSix()
        {
            // Arrange
            const int input = 6;

            // Setup
            string result = Program.FizzBuzz(input);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void ShouldReturnBuzz_WhenPassingFive()
        {
            // Arrange
            const int input = 5;

            // Setup
            string result = Program.FizzBuzz(input);

            // Assert
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void ShouldReturnBuzz_WhenPassingTen()
        {
            // Arrange
            const int input = 10;

            // Setup
            string result = Program.FizzBuzz(input);

            // Assert
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void ShouldReturnFizzBuzz_WhenPassingFifteen()
        {
            // Arrange
            const int input = 15;

            // Setup
            string result = Program.FizzBuzz(input);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void ShoulReturnSixteen_WhenPassingSixteen()
        {
            // Arrange
            const int input = 16;

            // Setup
            string resultat = Program.FizzBuzz(input);

            // Assert
            Assert.AreEqual("16", resultat);
        }

        [Test]
        public void ShouldReturnSeventeen_WhenPassingSeventeen()
        {
            // Arrange
            const int input = 17;

            // Setup
            string resultat = Program.FizzBuzz(input);

            // Assert
            Assert.AreEqual("17", resultat);

        }

        [Test]
        public void ShouldReturnNineteen_WhenPassingNineteen()
        {
            // Arrange
            const int input = 19;

            // Setup
            string resultat = Program.FizzBuzz(input);

            // Assert
            Assert.AreEqual("19", resultat);
        }
    }
}