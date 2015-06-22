using System;

class DiamondTrolls
{
    static void Main()
    {
        string userInput = Console.ReadLine();
        int size = int.Parse(userInput);
        int width = size * 2 + 1;
        int height = 6 + ((size - 3) / 2) * 3;

        int begginingMidDotsCount = (width - 3) / 4;

        int middleDotsCount = (width - 3) / 4;
        string firstLineDots = new String('.', (width - size) / 2);
        string firstLineStars = new String('*', size);
        Console.WriteLine("{0}{1}{0}", firstLineDots, firstLineStars);

        for (int row = 0; row < size / 2; row++)
        {
            string begginingMidDots = new String('.', begginingMidDotsCount);
            string middleDots = new String('.', middleDotsCount);
            begginingMidDotsCount--;
            middleDotsCount++;     
            Console.WriteLine("{0}*{1}*{1}*{0}", begginingMidDots, middleDots);
        }

        string onlyStarsLine = new String('*', width);
        Console.WriteLine(onlyStarsLine);

        begginingMidDotsCount++;
        middleDotsCount--;

        for (int row = 0; row < size-1; row++)
        {
            string begginingMidDots = new String('.', begginingMidDotsCount);
            string middleDots = new String('.', middleDotsCount);

            Console.WriteLine("{0}*{1}*{1}*{0}", begginingMidDots, middleDots);
            begginingMidDotsCount++;
            middleDotsCount--;
        }

        string lastLineDots = new String('.', (width - 1) / 2);
        Console.WriteLine("{0}*{0}", lastLineDots);
    }
}

