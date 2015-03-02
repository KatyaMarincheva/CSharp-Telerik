using System;
using System.Linq;
using System.Numerics;

class TwoGirlsOnePath
{
    static void Main()
    {
        var path = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
        int maxIndex = path.Length - 1;
        BigInteger molly = 0, dolly = 0; // collected flowers
        int m = 0, d = maxIndex; // positions
        string result = "";

        while (result == "")
        {
            var flowersM = path[m];
            var flowersD = path[d];
            if (path[m] > 0 && path[d] > 0)
            {
                // Collect
                if (m != d)
                {
                    molly += path[m];
                    dolly += path[d];
                    path[m] = 0;
                    path[d] = 0;
                }
                else // On the same cell
                {
                    path[m] = flowersM % 2;
                    molly += flowersM / 2;
                    dolly += flowersM / 2;
                }

                // Move
                m = (int)((m + flowersM) % (maxIndex + 1));
                d = ((int)((d - flowersD) % (maxIndex + 1)) + (maxIndex + 1)) % (maxIndex + 1);

            }
            else // Game over
            {
                if (path[m] == 0 && path[d] != 0)
                {
                    result = "Dolly";
                    dolly += path[d];
                }
                else if (path[m] != 0 && path[d] == 0)
                {
                    result = "Molly";
                    molly += path[m];
                }
                else // Both end up on an empty cell
                {
                    result = "Draw";
                }
            }
        }
        Console.WriteLine(result);
        Console.WriteLine("{0} {1}", molly, dolly);
    }
}
