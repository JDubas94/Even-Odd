using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a range of numbers!");

            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            int i;

            int countEvenNumder = 0, countOddNumber = 0;

            int evenSumma = 0, oddSumma = 0;

            if (a > b)
            {
                i = a;

                a = b;

                b = i;
            }


            while (a <= b)
            {
                if (a % 2 == 0)
                {
                    countEvenNumder++;
                    evenSumma += a;
                }
                else
                {
                    countOddNumber++;
                    oddSumma += a;

                }
                a++;
            }
           Console.WriteLine("Number of even: " + countEvenNumder);

           Console.WriteLine("Number of odd: " + countOddNumber);

            Console.WriteLine("Sum of even: " + evenSumma);

            Console.WriteLine("Sum of odd: " + oddSumma);





        }
    }
}
