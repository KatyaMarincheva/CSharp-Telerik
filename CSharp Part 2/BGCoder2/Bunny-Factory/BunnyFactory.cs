using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class Program
{
    static void Main()
    {
        // input
        List<int> numbers = new List<int>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            int number = int.Parse(input);
            numbers.Add(number);
        }

        int i = 0;

        while (true)
        {
            StringBuilder temp = new StringBuilder();

            if (i >= numbers.Count)
            {
                break;
            }

            int startSum = 0;
            BigInteger sum = 0;
            BigInteger product = 1;
            for (int j = 0; j <= i; j++)
            {
                startSum += numbers[j];
            }
            if (startSum >= numbers.Count - i)
            {
                break;
            }

            for (int j = i + 1; j <= startSum + i; j++) // added to  i + 1
            {
                sum += numbers[j];
                product *= numbers[j];
            }
            temp.Append(sum);
            temp.Append(product);

            for (int j = startSum + i + 1; j < numbers.Count; j++)
            {
                temp.Append(numbers[j]);
            }

            numbers.Clear();

            for (int j = 0; j < temp.Length; j++)
            {
                if (temp[j] != '0' && temp[j] != '1')
                {
                    numbers.Add(int.Parse(temp[j].ToString()));
                }
            }
            i++;
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}