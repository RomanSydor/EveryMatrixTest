using System;
using System.Linq;

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
            int? duplacate = null;
            bool isFinded = false;
            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                for (int j = 0; j < array.Length; j++)
                {
                    if (temp == array[j] && i != j)
                    {
                        duplacate = temp;
                        isFinded = true;
                        break;
                    }
                }
                if (isFinded)
                {
                    break;
                }
            }
            return duplacate;
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

        public string[] TimeInput(string[] array, int length) 
        {
            for (int i = 0; i < length; i++)
            {
                array[i] = i.ToString();

                //if (i < 10)
                //{
                //    array[i] += "0";
                //    var ch = array[i].ToCharArray();
                //    Array.Reverse(ch);
                //    array[i] = ch.ToString();
                //}

                if (i < 10)
                {
                    string zero = "0";
                    array[i] = (zero + i).ToString();
                }
                else
                {
                    array[i] = i.ToString();
                }
            }
            return array;
        }
    }
}
