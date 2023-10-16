using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Functional
{
    public static class PersonBuilder
    {
        public static Func<Person, Person> SetName(string name) =>
            p =>
            {
                p.Name = name;
                return p;
            };

        public static Func<Person, Person> SetAge(int age) =>
            p =>
            {
                p.Age = age;
                return p;
            };

        public static Func<Person, Person> SetAddress(string address) =>
            p =>
            {
                p.Address = address;
                return p;
            };
    }
}
