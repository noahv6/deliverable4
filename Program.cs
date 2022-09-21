using System;

namespace deliverable_4 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int next = 0;
            int previous = 0;

            for(int i = 0; i <= 24; i++)
            {
                Console.WriteLine("Fibonacci number " + "(" + i + ") " + "is " + next);
                if (next == 0)
                {
                    next = 1;

                }
                else
                {
                    int now = next;
                    next = next + previous;
                    previous = now;
                }

            }
            Console.ReadLine();
        }
    }
}

