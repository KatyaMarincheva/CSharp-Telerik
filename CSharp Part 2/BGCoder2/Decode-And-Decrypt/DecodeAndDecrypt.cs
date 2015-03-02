// Requirements:
/* Input:
 * the only line - a single string – the cyphered message
 * •	All symbols in the message will have ASCII codes in the range [65; 127]
 * 
 * To do:
 * 
 * Encrypt function actually works both ways 
 * Encrypt("ABCDE", "PQR") = "PRTMU" and Encrypt("PRTMU", "PQR") = "ABCDE"
o	Where the fist parameter of Encrypt is the message and the second is the cypher
 * 
 * The Encode function is also relatively easy to reverse – just take the numbers and print the symbol after each number the corresponding … number … of times.
 * 
 * 
 * Output:
 * Print exactly one line – the original message (decrypted and decoded)
 * •	The original message for any encrypted message will always contain only capital English letters
 * •	The original message will be no longer than 1500 symbols
 * */

using System;
using System.Collections.Generic;
using System.Text;

class DecodeAndDecrypt
{
    static int cypherL = 0;
    static void Main()
    {
        // input
        string cypheredMessage = Console.ReadLine();

        // cypher length
        cypherL = int.Parse(GetCypherLength(cypheredMessage));
        //Console.WriteLine(cypherL);

        // decode
        string decodedString = Decode(cypheredMessage);
        //Console.WriteLine(decodedString);

        // get cypher
        string cypher = GetCypher(decodedString);
        //Console.WriteLine(cypher);

        // get decoded message
        string decodedMessage = GetDecodedMessage(decodedString);

        // decrypt
        Console.WriteLine(Decrypt(decodedMessage, cypher));

    }

    // get cypher length
    private static string GetCypherLength(string input)
    {
        var cypher = new List<int>();
        for (int i = input.Length - 1; i > 0; i--)
        {
            char currChar = input[i];
            if (char.IsDigit(currChar))
            {
                cypher.Add(currChar - '0');
            }
            else
            {
                break;
            }
        }
        cypher.Reverse();
        var result = new StringBuilder();
        foreach (int t in cypher)
        {
            result.Append(t);
        }
        return result.ToString();
    }

    // get cypher
    private static string GetCypher(string input)
    {
        string cypher = input.Substring(input.Length - cypherL, cypherL);
        return cypher;
    }

    // get decoded message
    private static string GetDecodedMessage(string input)
    {
        string decodedMessage = input.Substring(0, input.Length - cypherL);
        return decodedMessage;
    }

    // decode input, skip cypher length digits in decoded message
    private static string Decode(string encodedInput)
    {
        var result = new StringBuilder();
        var count = 0;
        foreach (char c in encodedInput)
        {
            if (char.IsDigit(c))
            {
                count *= 10;
                count += c - '0';
            }
            else
            {
                if (count == 0)
                {
                    result.Append(c);
                }
                else
                {
                    result.Append(c, count);
                    count = 0;
                }
            }
        }
        return result.ToString();
    }

    // decrypt decoded message with the decoded cypher
    private static string Decrypt(string cypheredMessage, string cypher)
    {
        var messageTextBuilder = new StringBuilder(cypheredMessage);
        int longer = Math.Max(cypheredMessage.Length, cypher.Length);
        for (int index = 0; index < longer; index++)
        {
            int indexInMessage = index % cypheredMessage.Length;
            int indexInCypher = index % cypher.Length;
            int charInMessageOffset = messageTextBuilder[indexInMessage] - 'A';
            int charInCypherOffset = cypher[indexInCypher] - 'A';
            messageTextBuilder[indexInMessage] = (char)('A' + (charInMessageOffset ^ charInCypherOffset));
        }
        return messageTextBuilder.ToString();
    }
}


