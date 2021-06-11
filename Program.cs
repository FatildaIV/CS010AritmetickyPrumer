using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS010AritmetickyPrumer
{
    class Program
    {
        static void Main(string[] args)
        {
            //double number1, number2, number3, number4;

            //Console.Write("Enter the First number: ");
            //number1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the Second number: ");
            //number2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the third number: ");
            //number3 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the fourth number: ");
            //number4 = Convert.ToDouble(Console.ReadLine());

            //   double result = (number1 + number2 + number3 + number4) / 4;
            //   Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
            //number1, number2, number3, number4, result);
            //Console.WriteLine("Aritmetický průměr: {0}",
            //AritmetickyPrumer(number1 + number2 + 
            // number3 + number4, 4));
            AritmetickyPrumerVypocet(6);
            Console.ReadKey();
        }

        static void AritmetickyPrumerVypocet(int pocet)
        {
            AritmetickyPrumerVypocet(0, 0, pocet);
        }

        static void AritmetickyPrumerVypocet(double soucet, int pocet,
                                            int maximalniPocet)
        {
            if (pocet < maximalniPocet)
            {
                Console.Write("Enter the {0}. number: ", pocet + 1);
                //number4 = Convert.ToDouble(Console.ReadLine());
                AritmetickyPrumerVypocet(
                        soucet + Convert.ToDouble(Console.ReadLine()),
                        pocet + 1,
                        maximalniPocet);
            }
            else
            {
                Console.WriteLine("Aritmetický průměr: {0}",
                                AritmetickyPrumer(soucet, pocet));
            }
        }

        static double AritmetickyPrumer(double soucet, int pocet)
        {
            return (soucet / (double)pocet);
        }
   

    }
}
