using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Fizzing
    {
        public static string FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "fizzbuzz";
            }
            else if (number % 3 == 0)
            {
                return "fizz";
            }
            else if (number % 5 == 0)
            {
                return "buzz";
            }
            else
                return ($"The number {number} is not divisible by 3 or 5.");
        }
    }
}
