// Requirements:
/* Input:
 * first line - a single string – the search word
 * second line - a single INTEGER NUMBER L <= 100 – the number of paragraphs in the text
 * on each of the next L lines there will be a single string – the text in the respective paragraph
 * - NO LONGER than 1000 characters
 * paragraphs can contain ENGLISH LETTERS (upper- and lower-case)
 * Each symbol in the original text will have an ASCII CODE from 0 to 255
 * , SPACES and PUNCTUATION:
 * (",", ".", "(", ")", ";", "-", "!", "?" )
 * 
 * To do:
 * get INPUT
 * 
 * find the number of occurrences of a search word (as a separate word) in every paragraph (case-insensitive search)
 * calculate: RELEVANCE INDEX of a paragraph - the number of occurrences of that search word in that paragraph. 
 * 
 * creating a new ORDERED TEXT - ordering the paragraphs in that new text by relevance index 
 * 
 * all letters of all occurrences of the search word must be made UPPERCASE in the resulting ordered text 
 * 
 * any PUNCTUATION should be removed and words should be separated by a single SPACE in the resulting ordered text
 * 
 * Output:
 * Print exactly L LINES – the paragraphs with 
 * REMOVED PUNCTUATION, 
 * each two words separated by a single SPACE 
 * and the words matching the search word converted to UPPERCASE.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class RelevanceIndex
{
    static void Main()
    {
        // input
        string word = Console.ReadLine().ToLower();

        int L = int.Parse(Console.ReadLine());
        
        string[] input = new string[L];

        for (int i = 0; i < L; i++)
        {
            input[i] = Console.ReadLine();
        }

        //build dictionary
        Dictionary<string, int> dOutput = new Dictionary<string, int>();
        char[] delimiter = new char[] { ' ', ',', '.', '(', ')', ';', '-', '!', '?' };
        foreach (string str in input)
        {
            string[] paragraph = str.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            for (int i = 0; i < paragraph.Length; i++)
            {
                if (paragraph[i].ToLower() == word)
                {
                    count++;
                    paragraph[i] = paragraph[i].ToUpper();
                }
            }
            string finalParagraph = string.Join(" ", paragraph);

            dOutput.Add(finalParagraph, count);
        }

        // sort dictionary by value descending
        var items = from pair in dOutput
                    orderby pair.Value descending
                    select pair;

        // print dictionary keys
        foreach (KeyValuePair<string, int> pair in items)
        {
            Console.WriteLine(pair.Key);
        }
    }
}

