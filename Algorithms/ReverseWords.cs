using System;
using System.Linq;
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
    public class ReverseWords
    {
        public object printAlgo(string words)
        {
            var result = reverseTheWords(words);
            return result;
        }

        private string reverseTheWords(string words)
        {
            var wordsArr = words.Split(" ");
            string result = "";

            for (int x = 0; x < wordsArr.Length; x++)
            {
                var word = wordsArr[x];
                var lettersOfWord = word.ToCharArray();
                for (int i = lettersOfWord.Length - 1; i >= 0; i--)
                {
                    char l = word[i];
                    result += l;
                }
                
                if (x != wordsArr.Length)
                {
                    result += " ";
                }
            }
            return result;
        }
    }
}
