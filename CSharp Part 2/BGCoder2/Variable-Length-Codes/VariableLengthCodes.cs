using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class VariableLengthCodes
{
    static void Main()
    {
        // input coded text
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            
        string binary = "";

        for (int i = 0; i < numbers.Length; i++)
        {
            binary += Convert.ToString(numbers[i], 2).PadLeft(8, '0');
        }

        string[] bins = binary.Split('0');

        // create dictionary
        Dictionary<string, char> dictionary = new Dictionary<string, char>();
        int L = int.Parse(Console.ReadLine());
        string[] lines = new string[L];

        for (int k = 0; k < lines.Length; k++)
        {
            string line = Console.ReadLine();
            char value = line[0];
            string temp = new String('1', int.Parse(line.Substring(1)));
            dictionary.Add(temp, value);
        }

        // build decoded text
        string result = "";

        for (int l = 0; l < bins.Length; l++)
        {
            if (dictionary.ContainsKey(bins[l]))
            {
                char currChar = dictionary[bins[l]];
                result += currChar;
            }
        }


        Console.WriteLine(result);
        //foreach (KeyValuePair<string, char> pair in dictionary)
        //{
        //    Console.WriteLine("{0}, {1}",
        //    pair.Key,
        //    pair.Value);
        //}
    }
}

