using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FluentWithGenerics
{
    public class AddressBuilder<TSelf>
     where TSelf : PersonBuilder<TSelf>
    {
        private readonly TSelf personBuilder;
        private Address address = new Address();

        public AddressBuilder(TSelf personBuilder)
        {
            this.personBuilder = personBuilder;
        }

        public AddressBuilder<TSelf> At(string street)
        {
            address.Street = street;
            return this;
        }

        public AddressBuilder<TSelf> In(string city)
        {
            address.City = city;
            return this;
        }

        public AddressBuilder<TSelf> WithState(string state)
        {
            address.State = state;
            return this;
        }

        public AddressBuilder<TSelf> WithZipCode(string zipCode)
        {
            address.ZipCode = zipCode;
            return this;
        }

        public TSelf BuildAddress()
        {
            personBuilder.person.Address = address;
            return personBuilder;
        }
    }
}
