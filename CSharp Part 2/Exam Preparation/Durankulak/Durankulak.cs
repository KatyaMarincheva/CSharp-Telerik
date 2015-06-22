using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var DurankulakNumbers = new Dictionary<string, int>();
            int numSystemBase = 168;


            // Fill up to 26:
            int count = 0;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                DurankulakNumbers.Add(i.ToString(), count);
                count++;
            }

            count = DurankulakNumbers.Count;
            // Console.WriteLine(count);

            // Fill up to 168:

            for (char i = 'a'; i <= 'f'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    DurankulakNumbers.Add(i.ToString() + j.ToString(), count);
                    count++;
                    if (DurankulakNumbers.Count == numSystemBase) break;
                }
            }
            /*
 // Print test:
         foreach (var item in DurankulakNumbers)
            {
                Console.WriteLine(item.Key +"\t"+ item.Value);
            }
            */

            // Logic:
            string input = Console.ReadLine();

            // build number-string, match it with DurankulakNumbers keys, if a match 
            // - convert the respective DurankulakNumbers value number from 168-base to 10-base
            var currDDigit = new StringBuilder();
            BigInteger result = 0;
            foreach (var c in input)
            {
                currDDigit.Append(c);
                if (DurankulakNumbers.ContainsKey(currDDigit.ToString()))
                {
                    int currDigit = DurankulakNumbers[currDDigit.ToString()];
                    result *= 168;
                    result += currDigit;
                    currDDigit.Clear();
                }
            }
            Console.WriteLine(result);            
        }
    }
}
