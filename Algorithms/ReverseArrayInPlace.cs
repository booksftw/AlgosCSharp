using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Algorithms
{
    /* 
      function reverseArrayInPlace(arr) {
          for (var i = 0; i < arr.length / 2; i++) {
            var tempVar = arr[i];
            arr[i] = arr[arr.length - 1 - i];
            arr[arr.length - 1 - i] = tempVar;
          }
  
          return arr;
        }
 
        reverseArrayInPlace([1, 2, 3, 4, 5, 6, 7, 8]);
    */
    public class ReverseArrayInPlace
    {

        public List<int> printAlgo(List<int> arr)
        {
            var result = reverseArrayInPlace(arr);
            return result;
        }

        private List<int> reverseArrayInPlace(List<int> arr)
        {
            for (int i = 0; i < arr.Count / 2; i++)
            {
                var tempVar = arr[i];
                arr[i] = arr[arr.Count - 1 - i];
                arr[arr.Count - 1 - i] = tempVar;
            }
            return arr;
        }
    }
}
