using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 3 != 0)
                {
                    Console.Write(input[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
