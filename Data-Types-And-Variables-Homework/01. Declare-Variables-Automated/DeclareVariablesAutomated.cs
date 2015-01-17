using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class DeclareVariablesAutomated
{
    static void Main()
    {
        Console.SetWindowSize(120, 41);
        Console.SetBufferSize(120, 146);

        List<int> intNumbers1 = new List<int> { 52130, -115, 4825932, 97, -10000 };
        List<int> byteNumbers = new List<int>();
        List<int> sbyteNumbers = new List<int>();
        List<int> shortNumbers = new List<int>();
        List<int> ushorNumbers = new List<int>();

        Console.WriteLine("This is my initial list of variables. \nI have stored them into an int List.\n");

        foreach (int intNumber1 in intNumbers1)
        {
            Console.WriteLine("{0} {1}", intNumber1.GetType().Name, intNumber1);
        }

        Thread.Sleep(1000);

        Console.WriteLine("\nFurther my program will: ");
        Console.WriteLine("* use the GetType() method to obtain the data type of the initially stored numbers; \n* use the Convert class with the appropriate respective ToByte(), etc. methods \nto automatically sieve the initially stored numbers into their respective byte, sbyte, short, ushort lists");
        Console.WriteLine("* use again the GetType() method to display the data type of the numbers after they have been added \nto their appropriate data type lists.");

        Thread.Sleep(5000);

        foreach (int intNumber1 in intNumbers1)
        {
            try
            {
                byte byteNumber = Convert.ToByte(intNumber1);
                byteNumbers.Add(byteNumber);
                Console.WriteLine("\n{0} {1}", byteNumber.GetType().Name, byteNumber);
            }
            catch (Exception)
            {
                continue;
            }
        }

        Thread.Sleep(1000);

        List<int> intNumbers2 = intNumbers1.Except(byteNumbers).ToList();

        foreach (int intNumber2 in intNumbers2)
        {
            try
            {
                sbyte sbyteNumber = Convert.ToSByte(intNumber2);
                sbyteNumbers.Add(sbyteNumber);
                Console.WriteLine("\n{0} {1}", sbyteNumber.GetType().Name, sbyteNumber);
            }
            catch (Exception)
            {
                continue;
            }
        }
        Console.WriteLine();

        Thread.Sleep(1000);

        List<int> intNumbers3 = intNumbers2.Except(sbyteNumbers).ToList();

        foreach (int intNumber3 in intNumbers3)
        {
            try
            {
                short shortNumber = Convert.ToInt16(intNumber3);
                shortNumbers.Add(shortNumber);
                Console.WriteLine("{0} {1}", shortNumber.GetType().Name, shortNumber);
            }
            catch (Exception)
            {
                continue;
            }
        }
        Console.WriteLine();

        Thread.Sleep(1000);

        List<int> intNumbers4 = intNumbers3.Except(shortNumbers).ToList();

        foreach (int intNumber4 in intNumbers4)
        {
            try
            {
                ushort ushortNumber = Convert.ToUInt16(intNumber4);
                ushorNumbers.Add(ushortNumber);
                Console.WriteLine("{0} {1}", ushortNumber.GetType().Name, ushortNumber);
            }
            catch (Exception)
            {
                continue;
            }
        }
        Console.WriteLine();

        Thread.Sleep(2000);

        Console.WriteLine("One of the initially stored numbers has remained into the initial int List and is still declared as an integer, as this is it's most appropriate data type:");
        List<int> intNumbersFinal = intNumbers4.Except(ushorNumbers).ToList();

        Thread.Sleep(2000);

        foreach (int numberFinal in intNumbersFinal)
        {
            Console.WriteLine("\n{0} {1}", numberFinal.GetType().Name, numberFinal);
        }
        Console.WriteLine();

        Console.WriteLine("Data type information: \n\nInt16 -> alias of short \nUInt16 -> alias of ushort \nInt32 -> alias of int \nUInt32 -> alias of uint \nInt64 -> alias of long \nUInt64 -> alias of ulong");

        Console.WriteLine("\nNow, please, test if the above algorithm works for any integral type number. \nPlease type below a number between -9223372036854775808 and 18446744073709551615, and press Enter:\n");

    Start:

        string inputNumber = Convert.ToString(Console.ReadLine());

        bool negative = inputNumber.Contains('-');

        try
        {
            byte byteNumberOut = Convert.ToByte(inputNumber);

            Console.WriteLine("\n{0} {1}\n", byteNumberOut.GetType().Name, byteNumberOut);
        }
        catch (Exception)
        {
            try
            {
                sbyte sbyteNumberOut = Convert.ToSByte(inputNumber);

                Console.WriteLine("\n{0} {1}\n", sbyteNumberOut.GetType().Name, sbyteNumberOut);
            }
            catch (Exception)
            {
                try
                {
                    short shortNumberOut = Convert.ToInt16(inputNumber);

                    Console.WriteLine("\n{0} {1}\n", shortNumberOut.GetType().Name, shortNumberOut);

                }
                catch (Exception)
                {
                    try
                    {
                        ushort ushortNumberOut = Convert.ToUInt16(inputNumber);

                        Console.WriteLine("\n{0} {1}\n", ushortNumberOut.GetType().Name, ushortNumberOut);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            int intNumberOut = Convert.ToInt32(inputNumber);

                            Console.WriteLine("\n{0} {1}\n", intNumberOut.GetType().Name, intNumberOut);
                        }
                        catch (Exception)
                        {
                            try
                            {
                                uint uintNumberOut = Convert.ToUInt32(inputNumber);

                                Console.WriteLine("\n{0} {1}\n", uintNumberOut.GetType().Name, uintNumberOut);
                            }
                            catch (Exception)
                            {
                                try
                                {
                                    long longNumberOut = Convert.ToInt64(inputNumber);

                                    Console.WriteLine("\n{0} {1}\n", longNumberOut.GetType().Name, longNumberOut);
                                }
                                catch (Exception)
                                {
                                    try
                                    {
                                        ulong ulongNumberOut = Convert.ToUInt64(inputNumber);

                                        Console.WriteLine("\n{0} {1}\n", ulongNumberOut.GetType().Name, ulongNumberOut);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("\nThe input string is not a valid integral type number or is too big to be stored into an integral type variable. \n(please also note that computer memory cannot store numbers smaller than -9223372036854775808 \nor bigger than 18446744073709551615 in an integral type variable, and you will need to store them in type decimal or string variables). \nPlease try again. Please type below a number between -9223372036854775808 and 18446744073709551615, \nand press Enter:\n");
                                        goto Start;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
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
