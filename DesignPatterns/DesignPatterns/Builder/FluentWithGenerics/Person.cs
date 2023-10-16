using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FluentWithGenerics
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Age} years old, living at {Address}";
        }
    }
}
