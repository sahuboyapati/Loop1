using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLoop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("First 10 Natural Numbers:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

                Console.WriteLine("\nFirst 10 Even Natural Numbers:");
                for (int i = 2; i <= 20; i += 2)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

                Console.WriteLine("\nFirst 10 Odd Natural Numbers:");
            for (int i = 1; i <= 19; i += 2)
            {
                Console.Write(i + " ");
            }
               Console.ReadKey();
        }

    }

  }

       