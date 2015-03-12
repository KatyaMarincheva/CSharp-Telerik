// Requirements:
/* Input:
 * first line - a single string – the message
 * second line - a single string - the cypher
 * 
 * •	All symbols in the message will be capital English letters
 * 
 * •	Тhe message and the cypher will be no more than 1500 symbols each
 * 
 * To do:
 * get INPUT
 * 
 * define a function Encrypt
 * 
 * o	If the cypher string is shorter than the message, using it symbols loops to the beginning of the cypher.  
 * 
 *     static string Encrypt(string word, string key)
    {
        StringBuilder cipher = new StringBuilder();
        for (int i = 0; i < word.Length; i++)
            cipher.Append((char)(word[i] ^ key[i % key.Length]));
        return cipher.ToString();
    }
 * 
 * (char)((code of char-message ^ code of char-cypher) + 65) = encrypted char
 * o	If the message string is shorter than the cypher, some of its symbols will be encoded several times, until all of the cypher symbols are used.
 * 
 * define a function Encode
 * "aaaabbbccccaa" -> "4a3b4caa"
 * only if 2a.Length < aa.Length
 * 
 * Output:
 * Print exactly one line – the cyphered message
 * o	The encrypted message is called cypherText
 * o	Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher
 * 
 */

using System;
using System.Text;
// C# Part 2 - 2013/2014 @ 14 Sept 2013 - Evening
// 4. Encode and Encrypt
class EncodeAndEncrypt
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine();
        string cypher = Console.ReadLine();
        var cypherText = Encrypt(message, cypher) + cypher;
        var compressedCypherText = Encode(cypherText) + cypher.Length;
        Console.WriteLine(compressedCypherText);
    }
    private static string Encode(string message)
    {
        var encodedTextBuilder = new StringBuilder(message.Length);
        int indexInMessage = 0;
        while (indexInMessage < message.Length)
        {
            char currentSymbol = message[indexInMessage];
            int scanIndex = indexInMessage + 1;
            int repeatLength = 1;
            while (scanIndex < message.Length &&
            message[scanIndex] == currentSymbol)
            {
                repeatLength++;
                scanIndex++;
            }
            indexInMessage = scanIndex;
            if (repeatLength > 2)
            {
                encodedTextBuilder.Append(repeatLength);
                encodedTextBuilder.Append(currentSymbol);
            }
            else
            {
                encodedTextBuilder.Append(new string(currentSymbol, repeatLength));
            }
        }
        return encodedTextBuilder.ToString();
    }
    private static string Encrypt(string message, string cypher)
    {
        var cypherTextBuilder = new StringBuilder(message);
        int longer = Math.Max(message.Length, cypher.Length);
        for (int index = 0; index < longer; index++)
        {
            int indexInMessage = index % message.Length;
            int indexInCypher = index % cypher.Length;
            int charInMessageOffset = cypherTextBuilder[indexInMessage] - 'A';
            int charInCypherOffset = cypher[indexInCypher] - 'A';
            cypherTextBuilder[indexInMessage] = (char)('A' + (charInMessageOffset ^ charInCypherOffset));
        }
        return cypherTextBuilder.ToString();
    }
}