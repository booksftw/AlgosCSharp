using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Algorithms
{
    class FizzBuzz
    {
        /* JS
        function fizzBuzz(num)
        {
            for (var i = 1; i <= num; i++)
            {
                if (i % 15 === 0) console.log('FizzBuzz');
                else if (i % 3 === 0) console.log('Fizz');
                else if (i % 5 === 0) console.log('Buzz');
                else console.log(i);
            }
        } 
        */
        public string printAlgo(int num)
        {
            var fizzBuzz = getFizzBuzz(num);
            return fizzBuzz;
        }

        private string getFizzBuzz(int num)
        {
            string result = "Something went wrong";

            for (int i = 0; i <= num; i++)
            {
                if (i % 15 == 0) result = "FizzBuzz";
                else if (i % 3 == 0) result = "Fizz";
                else if (i % 5 == 0) result = "Buzz";
                else result = num.ToString();
            }

            return result;
        }
    }
}
