using System;
using System.Collections.Generic;

namespace DigitsIvayloBoolList
{
    internal class DigitsIvaylo
    {
        static int[,] _digits;

        private static void Main()
        {
            // прочитане на матрица от конзолата!

            int n = int.Parse(Console.ReadLine()); //четем число за ред и колона, може да са две

            var patterns = InitializeListOfPatterns();

            _digits = new int[n, n]; // създаваме матрица с тази големина
            for (int row = 0; row < n; row++) // пускам форцикъл до големината на това число
            {
                string[] currentLine = Console.ReadLine().Split(); // четем всеки ред и разделяме всяка 
                // цифра със спейс, крайният резултат пазим в стринг масив
                for (int col = 0; col < currentLine.Length; col++) // пускаме нов цикъл до края на масива
                {

                    _digits[row, col] = int.Parse(currentLine[col]);
                    //на текущия ред и текущата колона имаме цифра, парсната като инт
                }
            }

            int sum = 0; // пазим резултата в нова променлива
            for (int row = 0; row <= n - 5; row++) // търсим само, докъде може да се получи патерн, ред - 5
            {
                for (int col = 0; col <= n - 3; col++) // колона - 3
                {
                    if (_digits[row + 2, col] == 1) // ако цифрата на ред + 2 и текущата колона е 1
                    {
                        if (CheckPattern(patterns[1], 1, row, col)) // извикваме метода
                        {
                            sum += 1; // и прибавяме 1 към сумата
                            continue;
                        }
                    }
                    if (_digits[row + 1, col] == 2) //ако цифра на ред + 1 и колоната е равна на 2
                    {
                        if (CheckPattern(patterns[2], 2, row, col)) // извикваме метода
                        {
                            sum += 2; // и прибавяме 1 към сумата
                            continue;
                        }
                    }
                    // тук проверяваме за цифри от 3 до 9, понеже си приличат и започват от row, col
                    int currentDigit = _digits[row, col]; // създаваме си променлива за яснота
                    if (CheckPattern(patterns[currentDigit], currentDigit, row, col))
                    {
                        sum += currentDigit; // прибавяме текущото число към сумата
                    }
                }
            }
            Console.WriteLine(sum);
        }
        // създаваме метод, който проверява за pattern
        static bool CheckPattern(bool[,] pattern, int digit, int row, int col)
        {
            for (int i = 0; i < pattern.GetLength(0); i++)
            {
                for (int j = 0; j < pattern.GetLength(1); j++)
                {
                    if (pattern[i, j])
                    {
                        if (_digits[row + i, col + j] != digit)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        // създаваме си нов метод, който създава нов булев масив и го проверява, съответно за 1
        static List<bool[,]> InitializeListOfPatterns()
        {
            // 0
            var list = new List<bool[,]>();

            list.Add(new bool[,]
            {
               // faking zero // нулата не ни трябва, тъй като при сумирането, тя е излишна
            });

            // 1
            list.Add(new bool[,]
            {
                {false, false, true}, // 0 0 1
                {false, true, true},  // 0 1 1
                {true, false, true},  // 1 0 1
                {false, false, true}, // 0 0 1
                {false, false, true}  // 0 0 1
            });

            // 2
            list.Add(new bool[,]
            {
                {false, true, false}, // 0 2 0
                {true, false, true},  // 2 0 2
                {false, false, true}, // 0 0 2
                {false, true, false}, // 0 2 0
                {true, true, true}    // 2 2 2
            });

            // 3
            list.Add(new bool[,]
            {
                {true, true, true},    // 3 3 3
                {false, false, true},  // 0 0 3
                {false, true, true},    // 3 3 3
                {false, false, true},  // 0 0 3
                {true, true, true}     // 3 3 3
            });

            // 4
            list.Add(new bool[,]
            {
                {true, false, true},  // 4 0 4
                {true, false, true},  // 4 0 4
                {true, true, true},   // 4 4 4
                {false, false, true}, // 0 0 4
                {false, false, true}  // 0 0 4
            });

            // 5
            list.Add(new bool[,]
            {
                {true, true, true},    // 5 5 5
                {true, false, false},  // 5 0 0
                {true, true, true},    // 5 5 5
                {false, false, true},  // 0 0 5
                {true, true, true}     // 5 5 5
            });

            // 6
            list.Add(new bool[,]
            {
                {true, true, true},    // 6 6 6
                {true, false, false},  // 6 0 0
                {true, true, true},    // 6 6 6
                {true, false, true},   // 6 0 6
                {true, true, true}     // 6 6 6
            });

            // 7
            list.Add(new bool[,]
            {
                {true, true, true},   // 7 7 7
                {false, false, true}, // 0 0 7
                {false, true, false}, // 0 7 0
                {false, true, false}, // 0 7 0
                {false, true, false}  // 0 7 0
            });

            // 8
            list.Add(new bool[,]
            {
                {true, true, true},  // 8 8 8
                {true, false, true}, // 8 0 8
                {false, true, false},// 0 8 0
                {true, false, true}, // 8 0 8
                {true, true, true}   // 8 8 8
            });

            // 9
            list.Add(new bool[,]
            {
                {true, true, true},  // 9 9 9
                {true, false, true}, // 9 0 9
                {false, true, true}, // 0 9 9
                {false, false, true},// 0 0 9
                {true, true, true}   // 9 9 9
            });
            return list;
        }
    }
}