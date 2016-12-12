using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIteratorExample
{
    class DataStorage : IEnumerable
    {
        string[] places;
        List<int> numbers;
        string greeting; 

        public DataStorage()
        {
            //Note we are using string and int literals for this example.
            places = new string[] { "Auckland", "Wellington", "Dunedin", "Christchurch" };
            numbers = new List<int>() { 10, 12, 14, 18, 9 };
            greeting = "Hello everyone";
        }

        public IEnumerator GetEnumerator()
        {
            yield return greeting;
            //This foreach works because Arrays also inherit from IEnumerable
            foreach(var place in places)
            {
                //This foreach works because Lists also inherit from IEnumerable
                foreach (var number in numbers)
                {
                    yield return place + " " + number;
                }
            }
        }
    }
}
