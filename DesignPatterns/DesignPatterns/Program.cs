//using DesignPatterns.Builder.FluentWithGenerics;
//using DesignPatterns.Builder.Stepwise;
//using DesignPatterns.Builder.Fluent;
using DesignPatterns.Builder.Functional;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Builder design pattern

            //1. Fluent builder
            //Person person = new PersonBuilder()
            //.SetName("John")
            //.SetAge(30)
            //.SetAddress("123 Main St")
            //.Build();

            //Console.WriteLine(person);

            //2. Fluent builder inheritance with recursive generics
            //Person person = new PersonBuilder()
            //.SetName("John")
            //.SetAge(30)
            //.Lives.At("123 Main St")
            //      .In("Example City")
            //      .WithState("Example State")
            //      .WithZipCode("12345")
            //      .BuildAddress()
            //.Build();

            //Console.WriteLine(person);

            //3. Stepwise builder

            //Product product = new ProductBuilder()
            //.SetName("Widget")
            //.SetPrice(19.99m)
            //.SetDescription("A versatile widget for various purposes.")
            //.SetStock(100)
            //.Build();

            //Console.WriteLine(product);

            //4. Functional builder
            //var createPerson = PersonBuilder.SetName("John")
            //.AndThen(PersonBuilder.SetAge(30))
            //.AndThen(PersonBuilder.SetAddress("123 Main St"));

            //var person = createPerson(new Person());

            //Console.WriteLine(person);

        }
    }
}
