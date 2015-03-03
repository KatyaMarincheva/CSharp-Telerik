using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TRES4Numbers
{
    internal class Tres4Numbers
    {
        private static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());

            List<string> list = new List<string>();
            do
            {
                switch (number % 9)
                {
                    case 0: list.Add("LON+");
                        break;
                    case 1: list.Add("VK-");
                        break;
                    case 2: list.Add("*ACAD");
                        break;
                    case 3: list.Add("^MIM");
                        break;
                    case 4: list.Add("ERIK|");
                        break;
                    case 5: list.Add("SEY&");
                        break;
                    case 6: list.Add("EMY>>");
                        break;
                    case 7: list.Add("/TEL");
                        break;
                    case 8: list.Add("<<DON");
                        break;
                }

                number /= 9;
            } while (number != 0);
            for (int i = list.Count - 1; i > -1; i--)
            {
                Console.Write(list[i]);
            }
            Console.WriteLine();
        }
    }
}
