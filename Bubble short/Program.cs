using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_short
{

    class Program
    {

        static void Main(string[] args)
        {

            int[] arrayToSort = { 45, 6, 12, 51, 4, 23, 31 };

            bool sorted = false;

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(Convert.ToString(arrayToSort[i]) + " ");
            }

            Console.ReadKey();


            /*
            * while (!sorted)
            * {
            *      sorted = true
            *      loop through array
            *      {
            *          if (out of order)
            *          {
            *              swap
            *              sorted = false
            *          }
            *     }
            * }
            */

            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    
                    {
                        if (arrayToSort[i] > arrayToSort[i + 1])
                        {
                            int first = i;
                            int second = i + 1;

                            second = arrayToSort[i +1];
                            first = arrayToSort[i];

                            arrayToSort[i] = second;
                            arrayToSort[i + 1] = first;
                            
                            sorted = false;
                        }
                    }
                }
                for (int i = 0; i < arrayToSort.Length; i++)
                {
                    Console.Write(Convert.ToString(arrayToSort[i]) + " ");
                }
                Console.ReadKey();
            }
        }
    }
}
