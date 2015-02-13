//Problem 2. Float or Double?

// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
// Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;
using System.Collections.Generic; // contains (allows the use of) the List<T> Class
using System.Linq;  //allows the use of the String.Contains() method
using System.Globalization; //allows the use of the CultureInfo Class 
using System.Threading; // because I wanted to use the Thread.Sleep() method, and pause the program at times 

class FloatOrDoubleAutomated
{
    static void Main()
    {
        // sets custom floating point/ decimal number format (00.00 instead of 00,00)
        // overrides the local floating point/ decimal number format settings of the user's computer
        CultureInfo en = new CultureInfo("en-US");

        Console.SetWindowSize(110, 30); // sets console window size (width, height)
        Console.SetBufferSize(110, 146); // sets console buffer size (width, height)

        Console.WriteLine("This is my initial list of variables. \nI have stored them into a list of type string variables.\n");

        Thread.Sleep(1000); // pauses the program so that the next print comes with a given delay

        // below I initialize 3 lists, one stores the numbers from the "Problem 2. Float or Double?"
        // the remainig two will be storing the floats and the doubles respectively
        List<string> input = new List<string>() { "34.567839023", "12.345", "8923.1234857", "3456.091", "-3456.091" };
        List<float> floats = new List<float>();
        List<double> doubles = new List<double>();

        Thread.Sleep(1000);

        // prints all numbers from the above list, displays their type; for the time being they are all stored as type string variables
        foreach (string inputString in input) // loops over all strings in the input list
        {
            Console.WriteLine("{0} {1}", inputString.GetType().Name, inputString);
        }

        Thread.Sleep(1000);

        Console.WriteLine("\nFurther my program will: ");
        Console.WriteLine("* use the GetType() method to obtain the data type of the initially stored input strings; \n* get the lenght of each string in the initial input list; \n* Convert.ToSingle() all strings with Length <= 8 (including the decimal point), \nas they will obviously not get rounded if stored in type float (Single) variables;");
        Console.WriteLine("* Convert.ToDouble() all strings with Length > 8, \nso that they can be stored without rounding, in type double variables; \n* use again the GetType() method to display the data type of all variables \nafter they have been added to their appropriate type float (Single) or type double lists.");

        Thread.Sleep(5000);

        foreach (string inputString in input)
        {
            bool contains = inputString.Contains('-'); // checks whether a value from the above input list is negative or positive
            // the point is, this algorithm uses the string length as a criterium 
            // whether to store the number into a type float or double variable, 
            // so the minus sign has to be taken into consideration when calculating length of negative numbers
            
            // positive numbers with a string length <= 8 will be stored into type float variables
            if (inputString.Length <= 8 && contains == false)
            {
                float floatNumber = Convert.ToSingle(inputString); // converts input string to float
                floats.Add(floatNumber); // adds the float to the floats list

                // displays all resulting floats, as well as their type
                Console.WriteLine("\n{0} {1}", floatNumber.GetType().Name, floatNumber); 

                Thread.Sleep(1000);
            }

            // positive numbers with a string length > 8 will be stored into type double variables
            else if (inputString.Length > 8 && contains == false)
            {
                double doubleNumber = Convert.ToDouble(inputString); // converts input string to double
                doubles.Add(doubleNumber); // adds the double to the doubles list

                // displays all resulting doubles, as well as their type
                Console.WriteLine("\n{0} {1}", doubleNumber.GetType().Name, doubleNumber);

                Thread.Sleep(1000);
            }

            // negative numbers with a string length <= 9 (including the minus sign) will be stored into type float variables
            if (inputString.Length <= 9 && contains == true)
            {
                float floatNumber = Convert.ToSingle(inputString);
                floats.Add(floatNumber); // adds the float to the floats list

                // displays all resulting floats, as well as their type
                Console.WriteLine("\n{0} {1}", floatNumber.GetType().Name, floatNumber);

                Thread.Sleep(1000);
            }

            // negative numbers with a string length > 9 (including the minus sign) will be stored into type double variables
            else if (inputString.Length > 9 && contains == true)
            {
                double doubleNumber = Convert.ToDouble(inputString);
                doubles.Add(doubleNumber); // adds the double to the doubles list

                // displays all resulting doubles, as well as their type
                Console.WriteLine("\n{0} {1}", doubleNumber.GetType().Name, doubleNumber);

                Thread.Sleep(1000);
            }
        }
        Console.WriteLine("\nNow, please, test if the above algorithm works for any floating-point type number. \nPlease type below any positive or negative number of a total of up to 15 digits, \nexcluding the \"-\" sign, and press Enter:\n");

    Start: // the program can be restarted from this point on, so that you can enter and test the program on multiple input numbers
        Console.WriteLine();
        string inputNumber = Console.ReadLine(); // reads the input from the console

        bool negative = inputNumber.Contains('-'); // I need one more negative/positive check bool, 
        // as the previous one was created inside another foreach loop and is no llonger accessible
        
        try // tries to convert input string into float/ double /decimal
        {
            // positive numbers with a string length <= 8 will be stored into type float variables
            if (inputNumber.Length <= 8 && negative == false)
            {
                float floatNumberOut = Convert.ToSingle(inputNumber); //converts input string to float

                // displays the resulting float, as well as its type
                Console.WriteLine("\n{0} {1}", floatNumberOut.GetType().Name, floatNumberOut);

                Thread.Sleep(1000);
            }

            // positive numbers with a string length > 8 will be stored into type double variables
            else if (inputNumber.Length > 8 && inputNumber.Length <= 15 && negative == false)
            {
                double doubleNumberOut = Convert.ToDouble(inputNumber); //converts input string to double

                // displays the resulting double, as well as its type
                Console.WriteLine("\n{0} {1}", doubleNumberOut.GetType().Name, doubleNumberOut);
            }

            // negative numbers with a string length <= 9 (including the minus sign) will be stored into type float variables
            if (inputNumber.Length <= 9 && negative == true)
            {
                float negFloatNumberOut = Convert.ToSingle(inputNumber); //converts input string to float

                // displays the resulting float, as well as its type
                Console.WriteLine("\n{0} {1}", negFloatNumberOut.GetType().Name, negFloatNumberOut);
            }

            // negative numbers with a string length > 9 (including the minus sign) will be stored into type double variables
            else if (inputNumber.Length > 9 && inputNumber.Length <= 16 && negative == true)
            {
                double negDoubleNumberOut = Convert.ToDouble(inputNumber); //converts input string to double

                // displays the resulting double, as well as its type
                Console.WriteLine("\n{0} {1}\n ", negDoubleNumberOut.GetType().Name, negDoubleNumberOut);
            }

            // negative numbers with a string length > 16 (including the minus sign) will be stored into type decimal variables
            else if (inputNumber.Length > 16 && negative == true)
            {
                decimal negDecimalNumberOut = Convert.ToDecimal(inputNumber); //converts input string to decimal

                // displays the resulting decimal, as well as its type
                Console.WriteLine("\nYou have entered a number of more than 15 digits. \nTo avoid rounding the input number, instead of storiing it in one of the above floating.point variables, \nthis program has chosen to store the input number into a decimal type variable: \n\n{0} {1}\n ", negDecimalNumberOut.GetType().Name, negDecimalNumberOut);
            }

            // positive numbers with a string length > 15 will be stored into type decimal variables
            else if (inputNumber.Length > 15 && negative == false)
            {
                decimal DecimalNumberOut = Convert.ToDecimal(inputNumber); //converts input string to decimal

                // displays the resulting decimal, as well as its type
                Console.WriteLine("\nYou have entered a number of more than 15 digits. \nTo avoid rounding the input number, instead of storing it in one of the above floating.point variables, \nthis program has chosen to store the input number into a decimal type variable: \n\n{0} {1}\n ", DecimalNumberOut.GetType().Name, DecimalNumberOut);
            }
        }
        catch (Exception)  // catches the exception (not-number input) and prompts user to enter new input number
        {
            Console.WriteLine("\nThe input string is not a valid number. Please, try again! \nPlease, type below any positive or negative number between {0} and {1}, with or without a floating/decimal point in it, and press Enter:\n", decimal.MinValue, decimal.MaxValue);

            goto Start; // restarts the program from the above defined Start point, 
            // in case the user wants to keep testing the program
        }
        // interactive code: accepts Yes and No input, ignores case and length of answer
        Console.WriteLine("Would you like to try again? Y/N: \n");
        string result = Console.ReadLine();
        if (result.Equals("y", StringComparison.OrdinalIgnoreCase) || result.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            goto Start;
        }
        else if (result.Equals("n", StringComparison.OrdinalIgnoreCase) || result.Equals("no", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("\nThank you for testing my program!\n");
            Console.ReadKey();
        }
    }
}

