using EveryMatrixTest.Tasks;
using System;

namespace EveryMatrixTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose task:\n1)Arrays merging\n2)Searching for duplicate\n3)Palindrome count");
            var choose = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choose == 1)
            {
                var task = new FirstTask();
                task.Do();
            }
            if (choose == 2)
            {
                var task = new SecondTask();
                task.Do();
            }
            if (choose == 3)
            {
                var task = new ThirdTask();
                task.Do();
            }
            Console.Read();
        }
    }
}
