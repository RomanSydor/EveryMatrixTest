using EveryMatrixTest.Services;

namespace EveryMatrixTest.SortAlgorithms
{
    class BubbleSort
    {
        private ArrayService<int> _service = new ArrayService<int>();

        public int[] BubbleSorting(int[] array)
        {
            for (var j = 0; j < array.Length; j++)
            {
                for (var i = 0; i < array.Length - 1 - j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        _service.Swap(ref array[i], ref array[i + 1]);
                    }
                }
            }
            return array;
        }
    }
}
