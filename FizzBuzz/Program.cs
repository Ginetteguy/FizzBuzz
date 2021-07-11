using System;

namespace FizzBuzz
{
    /// <summary>
    /// FizzBuzz Kata TDD.
    /// </summary>
    public class Program
    {
        public string FizzBuzz(int input)
        {
            if (input == 3)
                return "Fizz";
            return input.ToString();
        }
    }
}
