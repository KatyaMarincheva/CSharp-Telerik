using System;

class KaspichaniaBoats
{
    static void Main()
    {
        string userInput = Console.ReadLine();
        int size = int.Parse(userInput);
        int width = size * 2 + 1;
        int height = 6 + ((size - 3) / 2) * 3;

        int begginingDotsCount = (width - 3) / 2;

        int middleDotsCount = 0; // (width - 3) / 4;

        string firstLineDots = new String('.', (width - 1) / 2);
        Console.WriteLine("{0}*{0}", firstLineDots);

        for (int row = 0; row < size - 1; row++)
        {
            string begginingDots = new String('.', begginingDotsCount);
            string middleDots = new String('.', middleDotsCount);

            Console.WriteLine("{0}*{1}*{1}*{0}", begginingDots, middleDots);
            begginingDotsCount--;
            middleDotsCount++;
        }

        string onlyStarsLine = new String('*', width);
        Console.WriteLine(onlyStarsLine);
        begginingDotsCount++;
        middleDotsCount--;
        for (int row = 0; row < size / 2; row++)
        {
            string begginingMidDots = new String('.', begginingDotsCount);
            string middleDots = new String('.', middleDotsCount);
            begginingDotsCount++;
            middleDotsCount--;
            Console.WriteLine("{0}*{1}*{1}*{0}", begginingMidDots, middleDots);
        }
        string lastLineDots = new String('.', (width - size) / 2);
        string lastLineStars = new String('*', size);
        Console.WriteLine("{0}{1}{0}", lastLineDots, lastLineStars);
    }
}

