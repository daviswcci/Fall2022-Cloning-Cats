using Fall2022_Cloning_Cats;
// Cloning Cats!
// Objects in C#

// Object references.

// Variable -> container for an object. 
Console.WriteLine("Reference Types:");
var Dez = new Cat();
var newDez = Dez; // we now have 2 variables referring to the same object.
// this is different than having two instances of these objects
Dez.Name = "Destructicon";
Console.WriteLine(Dez.Name);
Console.WriteLine(newDez.Name);

// This is an example of value types
Console.WriteLine("Value Types:");
var num1 = 15;
var num2 = num1;

num1 = 47;
Console.WriteLine(num1);
Console.WriteLine(num2); // based on previous example, we expect num2 to be the value 47

// Reference types vs. Value types
// Reference type stores a reference to some kind of value in memory. These, for the most part, will be all 
// classes we create and more complex 'objects'

// Value type stores the actual value in memory. These are the primitive types we've been using so far
// (bool, int, string, char, etc.)

// Cloning objects
Console.WriteLine("Cloned Objects:");
var Hammy = new Cat("Hammy", 5, false);
var newHammy = (Cat)Hammy.Clone();
Hammy.Name = "Thiccie";
Console.WriteLine(Hammy.Name);
Console.WriteLine(newHammy.Name); // unlike our original example, these two lines will print different names

// == operator works (equality operator) 
var Alani = new Cat("Alani", 2, false);
var AlaniClone = (Cat)Alani.Clone();
Console.WriteLine(Alani == AlaniClone); // comparing the location in memory of these two objects
//Console.WriteLine(Alani.Equals(AlaniClone)); // based on our definition, this should be true.

var anotherNum = 29;
var anotherNumClone = anotherNum;
Console.WriteLine(anotherNum == anotherNumClone);

// Interfaces that support the above ideas

// overloading operators