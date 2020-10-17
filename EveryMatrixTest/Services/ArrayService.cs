using System;

namespace EveryMatrixTest.Services
{
    class ArrayService<T>
    {

        public void Swap(ref int element1, ref int element2)
        {
            var swap = element1;
            element1 = element2;
            element2 = swap;
        }

        public int? DuplicateCheck(int[] array) 
        {
            if (array.Length < 1)
            {
                return null;
            }
            int slow = array[0];
            int fast = array[array[0]];

            while (fast != slow)
            {
                slow = array[slow];
                fast = array[array[fast]];
            }

            slow = 0;
            while (fast != slow)
            {
                slow = array[slow];
                fast = array[fast];
            }
            return slow;
        }

        public void ShowArray(T[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public int[] RandomInputArray(int[] array, ref int length, int from, int to)
        {
            var rnd = new Random();

            for (var i = 0; i < length; i++)
            {
                array[i] = rnd.Next(from, to);
            }
            return array;
        }

        public void ManuallyInputArray(int[] array, ref int length)
        {
            var check = false;
            Console.WriteLine("Input array: ");
            for (var i = 0; i < length; i++)
            {
                do
                {
                    try
                    {
                        Console.Write($"{i + 1})");
                        array[i] = int.Parse(Console.ReadLine());
                        check = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input!");
                        check = true;
                    }
                } while (check);
            }
        }
    }
}
