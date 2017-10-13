using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Identifying the two int types by having the user enter in a number

            int numberOne = getNumber("Please enter a number.");
            int numberTwo = getNumber("Please enter another a number with the same number of digits as the first submitted number.");

            //If statement to determine if the entered numbers are the same length

            if (sameLength(numberOne, numberTwo))
            {
                Console.WriteLine("The sum of the corresponding positions of the entered numbers are: {0}", sumsAllEqual(numberOne, numberTwo));
                Console.Read();
            }
            else
            {
                Console.WriteLine("Please enter in the same number of digits.");
                //Recursive function
                Main(args);
            }


        }
        

        private static bool sumsAllEqual(int numberOne, int numberTwo)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();

            while (numberOne > 0)
            {
                uniqueNumbers.Add(numberOne % 10 + numberTwo % 10);
                numberOne /= 10;
                numberTwo /= 10;
            }
            return uniqueNumbers.Count() == 1;
        }
        private static bool sameLength( int numberOne, int numberTwo)
        {
            //Cast int to string in order to compare the length
            return numberOne.ToString().Length == numberTwo.ToString().Length;
        }
        private static int getNumber(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int number;
            if(Int32.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                //Recursive function
                return getNumber("Please enter a valid number.");
            }
        }
    }
}
