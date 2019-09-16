using System;
using System.Collections.Generic;
using Algos.Algorithms;

namespace Algos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var fizzBuzz = new FizzBuzz();  // start of js udemy algo
            var harmlessRansomNote = new HarmlessRansomNote();
            var isPalinDrome = new IsPalindrome();
            var reverseWords = new ReverseWords();
            var caesarCiepher = new CaesarCiepher();
            var reverseArrayInPlace = new ReverseArrayInPlace(); // end of js udemy algo
            var linearSearch = new LinearSearch(); // https://www.geeksforgeeks.org/linear-search/
            var binarySearch = new BinarySearch(); // https://www.geeksforgeeks.org/binary-search/
            var jumpSearch = new JumpSearch(); // https://www.geeksforgeeks.org/jump-search/
            var interpolationSearch = new InterpolationSearch(); //  https://www.geeksforgeeks.org/interpolation-search/

            int x = 18; // Element to be searched 
            var result = interpolationSearch.printAlgo(x);
        }
    }
}
