using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Our first example
            string name = "Andrew";
            string lastName = "Llewellyn";
            int myAge = 38;
            string[] myAddress = new string[] { "123", "Fake Street", "there is no way", "I would use my real address", "Waukesha", "WI", "53186", "USA" };
            StartingExample firstExample = new StartingExample(name, lastName, myAge, myAddress);
            //note the use of var as the type for the temporary variable in the foreach loop
            foreach(var item in firstExample)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();


            //A second example
            DataStorage storage = new DataStorage();
            foreach(var item in storage)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
