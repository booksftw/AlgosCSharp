using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Algorithms
{
    class LinearSearch
    {


        public int printAlgo(int[] arr, int x)
        {
            var result = linearSearch(arr, x);
            return result;
        }

        private int linearSearch(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
    }
}
