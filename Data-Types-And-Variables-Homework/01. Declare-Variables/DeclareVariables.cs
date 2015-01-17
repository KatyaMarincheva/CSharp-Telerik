using System;

class DeclareVariables
{
    static void Main()
    {
        ushort numberOne = 52130;
        sbyte numberTwo = -115;
        int numberThree = 4825932;
        byte numberFour = 97;
        short numberFive = -10000;

        // the .GetType().Name method gets the type of a variable
        Console.WriteLine("{0} {1} \n{2} {3} \n{4} {5} \n{6} {7} \n{8} {9}\n", numberOne.GetType().Name, numberOne, numberTwo.
            GetType().Name, numberTwo, numberThree.GetType().Name, numberThree, numberFour.GetType().Name, numberFour, numberFive.GetType().Name, numberFive);

        Console.WriteLine("Data type information: \n\nInt16 -> alias of short \nUInt16 -> alias of ushort \nInt32 -> alias of int \nUInt32 -> alias of uint \nInt64 -> alias of long \nUInt64 -> alias of ulong\n");
    }
}
