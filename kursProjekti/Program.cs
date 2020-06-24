using System;

namespace kursProjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int broj = 1; broj < 100; broj++)
            {
                if ((broj % 3 == 0) && (broj % 5 == 0))
                    Console.WriteLine("fizzbuzz");
                else if (broj % 3 == 0)
                    Console.WriteLine("fizz");
                else if (broj % 5 == 0)
                    Console.WriteLine("buzz");
                else
                    Console.WriteLine(broj);
            }
            
        }
    }
}
