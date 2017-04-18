using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ugralos_frontendard
{
    class Program
    {
        static void Main(string[] args)
        {
            bool eredmeny = true;
            int tombMeret = 6;
            int randomMax = 10;
            int[] tomb = new int[tombMeret];
            Random rnd = new Random();
            for(int i = 0; i < tombMeret; i++)
            {
                tomb[i] = rnd.Next(0, randomMax);
                if (tomb[i] == 0 && i < tombMeret - 1)
                    eredmeny = false;
            }
            Console.WriteLine("[{0}] {1}", string.Join(",", tomb), eredmeny);

            Console.ReadLine();
        }
    }
}
