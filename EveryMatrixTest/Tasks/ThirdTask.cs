using EveryMatrixTest.Models;
using EveryMatrixTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryMatrixTest.Tasks
{
    class ThirdTask
    {
        public void Do() 
        {
            var _service = new ArrayService<string>();
            var _hours = new ArrayModel<string>();
            var _minutes = new ArrayModel<string>();

            _hours.Arr = new string[24];
            _minutes.Arr = new string[60];

            _service.TimeInput(_hours.Arr, 24);
            _service.TimeInput(_minutes.Arr, 60);

            //Search for fitting hours

            List<string> hours = new List<string>();

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    if (i == 2 && j == 4)
                    {
                        break;
                    }
                    hours.Add($"{i}{j}");
                }
            }


            List<string> minutes = new List<string>();

            foreach (var hour in hours)
            {
                minutes.Add(new string(hour.Reverse().ToArray()));
            }

            List<string> result = new List<string>();

            for (int i = 0; i < hours.Count; i++)
            {
                result.Add($"{hours[i]}:{minutes[i]}");
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Count: {result.Count}");
        }
    }
}
