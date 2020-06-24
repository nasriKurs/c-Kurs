using System;

namespace kursProjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kolatzova teorema
             * 
             */
            Console.Write("Molimo Vas unesite neki broj: ");
            int broj = int.Parse(Console.ReadLine());
            while (broj != 1)
            {
                if (broj % 2 == 0)
                    broj = broj / 2;
                else
                    broj = broj * 3 + 1;
                Console.WriteLine(broj);
            }
            Console.ReadKey();
            
        }
    }
}
