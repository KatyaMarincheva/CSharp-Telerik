// Problem 5. Boolean Variable

// Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
// Print it on the console.

using System;

class BooleanVariable
{
    static void Main()
    {
        bool isFemale = true;

        if (isFemale) // if isFemale is true, if the gender is female
        {
            Console.WriteLine("The gender is female.");
        }
        else if (!isFemale) // if isFemale is false, if the gender is not female
        {
            Console.WriteLine("The gender is male.");
        }
    }
}

