using System;

namespace EveryMatrixTest.Tasks
{
    class SecondTask
    {
        public void Do()
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9 };

            int? duplicate = null;
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

            duplicate = slow;
            Console.WriteLine("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine($"\nDuplicate: {duplicate}");
        }
    }
}
