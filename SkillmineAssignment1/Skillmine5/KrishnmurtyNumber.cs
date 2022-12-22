using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineAssignment1.Skillmine5
{
    class KrishnmurtyNumber
    {
        public static bool IsKrishnamurthy(int number)
        {
            //Declare Variables 
            int sum = 0, lastDigit = 0;
            int tempNum = number;
            // traverse through all digits of number 
            while (tempNum != 0)
            {
                lastDigit = tempNum % 10;
                sum += Convert.ToInt32(Factorial(lastDigit));
                tempNum /= 10;
            }

            // compare sum and number 
            if (sum == number)
                return true;
            return false;
        }
        //Method to calculate factorial of an integer 
        public static long Factorial(int number)
        {
            long fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }
        //Main method 
        public static void Main()
        {
            //Take input from end-user 
            Console.WriteLine("Enter an integer number:");
            int number = Convert.ToInt32(Console.ReadLine());
            // check number is Krishnamurthy number 
            bool result = IsKrishnamurthy(number);
            if (result)
                Console.WriteLine(number + " Is a Krishnamurthy Number.");
            else
                Console.WriteLine(number + " Is not a Krishnamurthy Number.");
            Console.ReadLine();
        }
    }
}
