using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            int faktoriyel = 1;
            sayı = Convert.ToInt16(Console.ReadLine());
            
            for(int i =sayı; i>0 ; i--)
            {
                faktoriyel = faktoriyel * i;
            }
            Console.WriteLine(faktoriyel);

        }

    }

}
