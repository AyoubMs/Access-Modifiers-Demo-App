using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Person
    {
        public string FirstName { get; set; }

        public string _ssn;

        public string SSN
        {
            get
            {
                return $"***-**-{_ssn.Substring(_ssn.Length - 4)}";
            }
            set
            {
                _ssn = value;
            }
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName}");
        }
    }
}
