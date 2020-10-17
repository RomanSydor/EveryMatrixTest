using System;
using System.Collections.Generic;

namespace EveryMatrixTest.Tasks
{
    class FirstTask
    {
        public void Do() 
        {
            int[] array1 = new int[4] { 3, 5, 9, 10 };
            int[] array2 = new int[6] { 1, 7, 8, 12, 14, 16 };

            var firstIndex = 0;
            var secondIndex = 0;
            var merged = new List<int>();

            for(var i = 0; i <= array1.Length + array2.Length; i++)
            {

                if ((array1[firstIndex] >= array2[secondIndex]))
                {
                    merged.Add(array2[secondIndex]);
                    if (secondIndex != array2.Length - 1)
                    {
                        secondIndex++;
                        continue;
                    }
                }
                else 
                {
                    merged.Add(array1[firstIndex]);
                    if (firstIndex != array1.Length - 1)
                    {
                        firstIndex++;
                        continue;
                    }
                }
                if (firstIndex == array1.Length - 1)
                {
                    for (int s = secondIndex; s < array2.Length; s++)
                    {
                        merged.Add(array2[s]);
                    }
                    break;
                }
                if (secondIndex == array2.Length - 1)
                {
                    for (int f = firstIndex; f < array1.Length; f++)
                    {
                        merged.Add(array1[f]);
                    }
                    break;
                }
            }

            Console.WriteLine("Array 1: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine("\nArray 2: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine("\nRESULT");
            foreach (var item in merged)
            {
                Console.Write($"{item.ToString()} ");
            }
        }
    }
}
