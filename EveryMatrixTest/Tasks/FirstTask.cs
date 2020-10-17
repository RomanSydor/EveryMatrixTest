using EveryMatrixTest.Models;
using EveryMatrixTest.Services;
using EveryMatrixTest.SortAlgorithms;
using System;
using System.Collections.Generic;

namespace EveryMatrixTest.Tasks
{
    class FirstTask
    {
        public void Do() 
        {
            var _service = new ArrayService<int>();
            var _bubbleSort = new BubbleSort();
            var _arrayModel1 = new ArrayModel<int>();
            var _arrayModel2 = new ArrayModel<int>();

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"{i + 1} array generation \nEnter the range \nFrom: ");
                var from = int.Parse(Console.ReadLine());
                Console.Write("To: ");
                var to = int.Parse(Console.ReadLine());
                Console.Write("Length: ");
                var length = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    _arrayModel1.Arr = new int[length];
                    _service.RandomInputArray(_arrayModel1.Arr, ref length, from, to);
                    _bubbleSort.BubbleSorting(_arrayModel1.Arr);
                    Console.WriteLine("\nSorted array: ");
                    _service.ShowArray(_arrayModel1.Arr);
                }
                if (i == 1)
                {
                    _arrayModel2.Arr = new int[length];
                    _service.RandomInputArray(_arrayModel2.Arr, ref length, from, to);
                    _bubbleSort.BubbleSorting(_arrayModel2.Arr);
                    Console.WriteLine("\nSorted array: ");
                    _service.ShowArray(_arrayModel2.Arr);
                }

                Console.WriteLine();
                Console.WriteLine("Press 'ENTER'");
                Console.ReadLine();
            }

            Console.WriteLine("Array 1");
            _service.ShowArray(_arrayModel1.Arr);

            Console.WriteLine("\nArray 2");
            _service.ShowArray(_arrayModel2.Arr);

            Console.WriteLine("\nPress 'ENTER' to merge them");
            Console.ReadLine();

            var firstIndex = 0;
            var secondIndex = 0;
            var merged = new List<int>();

            for(var i = 0; i <= _arrayModel1.Arr.Length + _arrayModel2.Arr.Length; i++)
            {

                if ((_arrayModel1.Arr[firstIndex] >= _arrayModel2.Arr[secondIndex]))
                {
                    merged.Add(_arrayModel2.Arr[secondIndex]);
                    if (secondIndex != _arrayModel2.Arr.Length - 1)
                    {
                        secondIndex++;
                        continue;
                    }
                }
                else 
                {
                    merged.Add(_arrayModel1.Arr[firstIndex]);
                    if (firstIndex != _arrayModel1.Arr.Length - 1)
                    {
                        firstIndex++;
                        continue;
                    }
                }
                if (firstIndex == _arrayModel1.Arr.Length - 1)
                {
                    for (int s = secondIndex; s < _arrayModel2.Arr.Length; s++)
                    {
                        merged.Add(_arrayModel2.Arr[s]);
                    }
                    break;
                }
                if (secondIndex == _arrayModel2.Arr.Length - 1)
                {
                    for (int f = firstIndex; f < _arrayModel1.Arr.Length; f++)
                    {
                        merged.Add(_arrayModel1.Arr[f]);
                    }
                    break;
                }
            }

            Console.WriteLine("RESULT");
            foreach (var item in merged)
            {
                Console.Write($"{item.ToString()} ");
            }
        }
    }
}
