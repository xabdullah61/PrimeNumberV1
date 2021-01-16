using System;

namespace Degiskenler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter number pls: ");
            x = Convert.ToInt16(Console.ReadLine());
            if (IsPrimeNumber(x))
            {
                Console.WriteLine("This number is a prime number.");
            }
            else
            {
                Console.WriteLine("This number is not prime number");
            }
        }
       static bool IsPrimeNumber(int sayı)
        {
            bool result = true;
            for (int i = 2; i < sayı-1; i++)
            {
                if (sayı % i == 0) 
                {
                    result = false;
                    i = sayı;

                }
            }
            return result;
        }
    }
}
