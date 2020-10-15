using EveryMatrixTest.Models;
using EveryMatrixTest.Services;
using System;

namespace EveryMatrixTest.Tasks
{
    class SecondTask
    {
        public void Do() 
        {
            var _service = new ArrayService<int>();
            var _arrayModel = new ArrayModel<int>();

            Console.Write("Length: ");
            var length = int.Parse(Console.ReadLine());

            _arrayModel.Arr = new int[length];
            _service.ManuallyInputArray(_arrayModel.Arr, ref length);

            int? dupl = _service.DuplicateCheck(_arrayModel.Arr);
            Console.WriteLine();
            _service.ShowArray(_arrayModel.Arr);

            if (dupl == null)
            {
                Console.WriteLine("\nThere is no duplicates");
            }
            else
            {
                Console.WriteLine($"\nDuplicate: {dupl}");
            }
        }
    }
}
