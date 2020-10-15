using EveryMatrixTest.Models;
using EveryMatrixTest.Services;
using EveryMatrixTest.SortAlgorithms;
using System;
using System.Linq;

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

            int[] merged = _arrayModel1.Arr.Concat(_arrayModel2.Arr).ToArray();

            _bubbleSort.BubbleSorting(merged);

            Console.WriteLine("RESULT");
            _service.ShowArray(merged);
        }
    }
}
