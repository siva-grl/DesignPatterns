# DesignPatterns
Builder Design Pattern
	1. Builder design pattern is used to create complex object (a object which is having multiple arguments) into step by step

	Builder Types:
		1. Fluent Builder
			i)		A Fluent Builder is a variation of the Builder design pattern that focuses on providing a more fluent and expressive way to construct 
			complex objects. It's a design pattern that enhances the readability and maintainability of the code by allowing you to chain method 
			calls together to build an object step by step, creating a more natural and intuitive API.
			ii)		In a Fluent Builder, each method typically returns the builder instance itself, which allows you to chain multiple method calls together
			in a single statement. This chaining of method calls can make the code more self-explanatory and improve code readability.

			Example : Fluent/PersonBuilder.cs

			i)		The Person class represents an object that we want to construct.
			ii)		The PersonBuilder class is a Fluent Builder for constructing Person objects.
			iii)		Each method in the PersonBuilder class returns the builder instance itself, allowing method calls to be chained together.
			iv)		The Build method finalizes the construction process and returns the fully constructed Person object.

			Using a Fluent Builder pattern like this makes it easier to create complex objects by providing a clear and expressive way to set various properties and attributes 
			of the object during construction. It can improve code readability and reduce the chances of making mistakes when building objects with many optional parameters 
			or configurations


		2. Fluent builder Inheritance with recursive Generics
			i)		Fluent builder inheritance with recursive generics can be a powerful way to create a hierarchy of builders for constructing complex 
			object structures with nested properties and subcomponents. In this pattern, each builder class is responsible for constructing a part
			of the overall object structure and can be chained together to create a complete object. Recursive generics allow each builder to work
			with its specific part of the object hierarchy while maintaining a consistent fluent interface.

			Example : FluentWithGenerics/PersonBuilder.cs

			i)		Person and Address are classes representing the objects to be constructed.
			ii)		PersonBuilder is a base class for building Person objects using recursive generics.
			iii)		AddressBuilder is a builder for the Address part of the object hierarchy. It takes a reference to the parent PersonBuilder to maintain the fluent interface
			iv)		The Lives property allows chaining the AddressBuilder methods to set address-related properties
			v)		The BuildAddress method finalizes the address construction and returns to the parent PersonBuilder

		3. Stepwise builder
			i)		A Stepwise Builder is a design pattern used to construct complex objects incrementally, one step at a time

			Example : Stepwise/ProductBuilder.cs

			i)		The Product class represents an object that you want to construct.
			ii)		The ProductBuilder class is a Stepwise Builder for constructing Product objects.
			iii)		Each method in the builder corresponds to setting a specific attribute or property of the Product.
			iv)		The builder's Build method finalizes the construction process and returns the fully constructed Product object.

		3. Functional builder
			i)		Functional Builder typically relies on functions (lambdas or delegates) and composition to construct objects. This pattern is often used in functional programming languages like Haskell, 
			but it can also be applied in languages like C#.

			Example : Functional/PersonBuilder.cs

			i)		The Person class represents an object that you want to construct.
			ii)		The PersonBuilder class contains static methods that return functions (lambdas) that modify a Person object and return the modified object.
			iii)		The AndThen extension method composes these functions to create a chain of modifications.
			iv)		We create a createPerson function that combines the individual modification functions to construct a Person object.
			v)		Finally, we apply the createPerson function to an empty Person object to build the complete Person instance.

