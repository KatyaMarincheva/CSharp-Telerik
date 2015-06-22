using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiverseCommunication
{
    internal class MultiverseCommunication
    {
        private static void Main()
        {
            string input = Console.ReadLine();

            // creating dictionary
            var letters = new Dictionary<string, char>();
            letters.Add("CHU", '0');
            letters.Add("TEL", '1');
            letters.Add("OFT", '2');
            letters.Add("IVA", '3');
            letters.Add("EMY", '4');
            letters.Add("VNB", '5');
            letters.Add("POQ", '6');
            letters.Add("ERI", '7');
            letters.Add("CAD", '8');
            letters.Add("K-A", '9');
            letters.Add("IIA", 'A');
            letters.Add("YLO", 'B');
            letters.Add("PLA", 'C');

            // using the dictionary to convert the input string to hexadecimal digits
            StringBuilder hexNum = new StringBuilder();

            for (int i = 0; i < input.Length; i += 3)
            {
                hexNum.Append(letters[input.Substring(i, 3)]);
            }

            string hNum = hexNum.ToString();

            // hex digits in 13-based numeral system to decimal
            ulong decNum = 0;
            for (int i = 0; i < hNum.Length; i++)
            {
                if (hNum[i] > '9') // if a char digit is > '9', it can only be 'A', 'B', etc. 
                //from the hexadecimal numeral system
                {
                    decNum += (ulong)(hNum[i] - '7') * (ulong)Math.Pow(13, (hNum.Length - 1 - i));
                    // example: 'A' = 65 (ASCII code); '7' = 55; hence 'A' - '7' = 10, 
                    // which is exactly the decimal representation of the digit A
                }
                else
                {
                    decNum += (ulong)(hNum[i] - '0') * (ulong)Math.Pow(13, (hNum.Length - 1 - i));
                    // example: '9' = 57 (ASCII code); '0' = 48; hence '9' - '0' = 9, 
                    // which is exactly the decimal value of the digit 9
                }
            }

            Console.WriteLine(decNum);
        }
    }
}
