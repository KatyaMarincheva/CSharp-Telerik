// Problem 6. Strings and Objects

// Declare two string variables and assign them with Hello and World.
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).


using System;

class StringsAndObjects
{
    static void Main()
    {
        Console.SetWindowSize(27, 13);
        Console.SetBufferSize(27, 13);

        string hi = "Hello";
        string name = "World!";
        object concatenation = string.Concat(hi, " ", name); // String.Concat Method - 
        // Concatenates one or more instances of String, or the String representations of the values of one or more instances of Object.

        string greating = (string)concatenation; //type casting - casts the object into string
        Console.WriteLine(greating);
        Console.ReadLine();
    }

}
