// Problem 5. Boolean Variable

// Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
// Print it on the console.

using System;

class BooleanVariable
{
    static void Main()
    {
        bool isFemale = true;

        if (isFemale)
        {
            Console.WriteLine("The gender is female.");
        }
        else if (!isFemale)
        {
            Console.WriteLine("The gender is male.");
        }
    }
}

