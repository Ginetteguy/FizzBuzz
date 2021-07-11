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
            if (input % 15 == 0)
                return "FizzBuzz";
            if (input % 3 == 0)
                return "Fizz";
            if (input % 5 == 0)
                return "Buzz";
            return input.ToString();
        }
    }
}
