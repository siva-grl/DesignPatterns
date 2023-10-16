using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FluentWithGenerics
{
    public abstract class PersonBuilder<TSelf>
    where TSelf : PersonBuilder<TSelf>
    {
        internal Person person = new Person();

        public TSelf SetName(string name)
        {
            person.Name = name;
            return (TSelf)this;
        }

        public TSelf SetAge(int age)
        {
            person.Age = age;
            return (TSelf)this;
        }

        public AddressBuilder<TSelf> Lives => new AddressBuilder<TSelf>((TSelf)this);

        public Person Build()
        {
            return person;
        }
    }

    public class PersonBuilder : PersonBuilder<PersonBuilder>
    {
    }
}
