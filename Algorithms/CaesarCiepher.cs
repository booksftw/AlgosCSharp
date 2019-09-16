using System;
using System.Collections.Generic;
using System.Linq;

namespace Algos.Algorithms
{
    //function caesarCipher(str, num)
    //{
    //    num = num % 26;
    //    var lowerCaseString = str.toLowerCase();
    //    var alphabet = 'abcdefghijklmnopqrstuvwxyz'.split('');
    //    var newString = '';

    //    for (var i = 0; i < lowerCaseString.length; i++)
    //    {
    //        var currentLetter = lowerCaseString[i];
    //        if (currentLetter === ' ')
    //        {
    //            newString += currentLetter;
    //            continue;
    //        }
    //        var currentIndex = alphabet.indexOf(currentLetter);
    //        var newIndex = currentIndex + num;
    //        if (newIndex > 25) newIndex = newIndex - 26;
    //        if (newIndex < 0) newIndex = 26 + newIndex;
    //        if (str[i] === str[i].toUpperCase())
    //        {
    //            newString += alphabet[newIndex].toUpperCase();
    //        }
    //        else newString += alphabet[newIndex];
    //    };

    //    return newString;
    //}
    //caesarCipher('Zoo Keeper', 2);
    public class CaesarCiepher
    {

        public string printAlgo(string str, int num)
        {
            var result = caesarCiepherWord(str, num);
            return result;
        }

        private string caesarCiepherWord(string str, int userInputNum)
        {
            var num = userInputNum % 26;
            var lowerCaseString = str.ToLower();
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray().ToList();
            var result = "";

            for (int i = 0; i < lowerCaseString.Length; i++)
            {
                var currentLetter = lowerCaseString[i].ToString();
                if (currentLetter == " ")
                {
                    result += currentLetter;
                    continue;
                }
                char currentChar = currentLetter[0];
                var currentIndex = alphabet.IndexOf(currentChar);
                var newIndex = currentIndex + num;
                if (newIndex > 25)
                {
                    newIndex = newIndex - 26;
                }
                if (str[i].ToString() == str[i].ToString().ToUpper() )
                {
                    result += alphabet[newIndex].ToString().ToUpper();
                }
                else
                {
                    result += alphabet[newIndex];
                }
        }

            return result;
        }
    }
}