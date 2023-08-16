using System;

namespace FizzBuzz
{
    /// <summary>
    /// FizzBuzz Kata TDD.
    /// </summary>
    public class Program
    {
        private const string _fizz = "Fizz";
        private const string _buzz = "Buzz";
        private const string _fizzBuzz = "FizzBuzz";
        public string FizzBuzz(int input)
        {
            if (input % 15 == 0)
                return _fizzBuzz;
            if (input % 3 == 0)
                return _fizz;
            if (input % 5 == 0)
                return _buzz;
            return input.ToString();
        }
    }
}
