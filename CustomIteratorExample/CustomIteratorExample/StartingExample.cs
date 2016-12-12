using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIteratorExample
{
    class StartingExample : IEnumerable
    {
        string firstName;
        string lastName;
        int age;
        string[] address;
        public StartingExample(string firstName, string lastName, int age, string [] address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.address = address;
    
        }
        public IEnumerator GetEnumerator()
        {
            //notice that we are yield returning two data types (string and int)
            //this is a reason to use var as the data type for the temporary variable
            //in a foreach loop
            yield return firstName;
            yield return lastName;
            yield return age;
            for(int i = 0; i < address.Count();i++)
            {
                yield return address[i];
            }
            yield return "Done";

        }
    }
}
