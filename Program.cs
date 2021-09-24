using System;

namespace Reverse_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number, Reverse = 0, Rem;
            Console.WriteLine("Enter a Number to reverse it");
            Number = int.Parse(Console.ReadLine());

            while (Number != 0)
            {
                Rem = Number % 10;
                Reverse = Reverse * 10 + Rem;
                Number /= 10;
            }
            Console.WriteLine("Reversed Number: {0}",Reverse);

         
        }
    }
}
