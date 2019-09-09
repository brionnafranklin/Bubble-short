using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_short
{

    class Program
    {
        static int swaps = 0;
        static int loops = 0;
        static void Main(string[] args)
        {

            int[] arrayToSort = { 14, 65, 63, 1, 54, 89, 84, 9, 98, 57, 71, 18, 21, 84, 69, 28, 11, 83, 13, 42, 64, 58, 78, 82, 13, 9, 96, 14, 39, 89, 40, 32, 51, 85, 48, 40, 23, 15, 94, 93, 35, 81, 1, 9, 43, 39, 15, 17, 97, 52 };

            

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(Convert.ToString(arrayToSort[i]) + " ");

            }
            Console.WriteLine();
            Console.ReadKey();
            CocktailShakerSort(arrayToSort);

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(Convert.ToString(arrayToSort[i]) + " ");
            }

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("swaps: " + swaps);
            Console.WriteLine("loops: " + loops);
            Console.ReadKey();
        }

        public static void CocktailShakerSort(int[] arrayToSort)
        {
            bool sorted = false;

            int length = arrayToSort.Length - 1;
            int start = 0;
            while (!sorted)
            {

                sorted = true;
                for (int i = start; i < length; i++)
                {

                    {
                        if (arrayToSort[i] > arrayToSort[i + 1])
                        {
                            int first = i;
                            int second = i + 1;

                            second = arrayToSort[i + 1];
                            first = arrayToSort[i];

                            arrayToSort[i] = second;
                            arrayToSort[i + 1] = first;

                            sorted = false;
                            swaps++;
                        }
                        loops++;

                    }

                }
                length--;
                for (int i = length; i >start; i--)
                {

                    {
                        if (arrayToSort[i] < arrayToSort[i - 1])
                        {
                            int first = i;
                            int second = i - 1;

                            second = arrayToSort[i - 1];
                            first = arrayToSort[i];

                            arrayToSort[i] = second;
                            arrayToSort[i - 1] = first;

                            sorted = false;
                            swaps++;
                        }
                        loops++;

                    }

                }
                start++;
            }

        }
        /*
        public static void OptimizedBubbleSort(int[] arrayToSort)
        {
            bool sorted = false;

            int length = arrayToSort.Length - 1;

            while (!sorted)
            {
                

                sorted = true;
                for (int i = 0; i < length; i++)
                {

                    {
                        if (arrayToSort[i] > arrayToSort[i + 1])
                        {
                            int first = i;
                            int second = i + 1;

                            second = arrayToSort[i + 1];
                            first = arrayToSort[i];

                            arrayToSort[i] = second;
                            arrayToSort[i + 1] = first;

                            sorted = false;
                            swaps++;
                        }
                        loops++;
                        
                    }
                    
                }
                length--;
            }

        }
        
        public static void BubbleSort(int[] arrayToSort)
        {
            bool sorted = false;

            

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

                            second = arrayToSort[i + 1];
                            first = arrayToSort[i];

                            arrayToSort[i] = second;
                            arrayToSort[i + 1] = first;

                            sorted = false;
                            swaps++;
                        }
                        loops++;
                    }

                }

            }
            
        }
        */
    }
}
