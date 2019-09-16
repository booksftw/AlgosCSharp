using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Algorithms
{
    /* 
      function reverseWords(string) {
        var wordsArr = string.split(' ');
        var reversedWordsArr = [];
  
        wordsArr.forEach(word => {
        var reversedWord = '';
        for (var i = word.length - 1; i >= 0; i--) {
            reversedWord += word[i];
        };
        reversedWordsArr.push(reversedWord);
        });
  
        return reversedWordsArr.join(' ');
    }
 
    reverseWords('Coding JavaScript');
    */
    class HarmlessRansomNote
    {
        public string PrintAlgo(string word)
        {
            var result = reverseWords(word);

            return result;
        }

        private string reverseWords(string word)
        {
            var wordArr = word.Split();
            var reversedWordsArr = new List<string>();

            foreach (var w in wordArr)
            {
                var reversedWord = "";
                for (int i = w.Length -1; i >= 0; i--)
                {
                    reversedWord += w[i];
                };
                reversedWordsArr.Add(reversedWord);
            }

            return string.Join(" ", reversedWordsArr);
            //return reversedWordsArr.ToString();
        }
    }
}
