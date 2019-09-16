using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algos.Algorithms
{
    /*
      function isPalindrome(string) {
          string = string.toLowerCase();
          var charactersArr = string.split('');
          var validCharacters = 'abcdefghijklmnopqrstuvwxyz'.split('');
  
          var lettersArr = [];
          charactersArr.forEach(char => {
            if (validCharacters.indexOf(char) > -1) lettersArr.push(char);
          });
  
          return lettersArr.join('') === lettersArr.reverse().join('');
        }
 
        isPalindrome("Madam, I'm Adam");
     */
    class IsPalindrome
    {

        public bool printAlgo(string phrase)
        {
            var result = isThisPalindrome(phrase);
            return result;
        }

        private bool isThisPalindrome(string phrase)
        {
            var str = phrase.ToLower();
            var charactersArr = str.ToCharArray();
            
            var validCharacters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var lettersArr = new List<char>();

            foreach (char c in charactersArr)
            {
                if (validCharacters.Contains(c))
                {
                    lettersArr.Add(c);
                }
            }
            
            var comboForward = string.Join("", lettersArr); // lettersArr.Join();
            lettersArr.Reverse();
            var comboBackward = string.Join("", lettersArr);
            return comboForward == comboBackward;
        }
    }
}
