namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000: COMPLETED!

        //Write a method that will print to the console numbers 3 through 999 by 3 each time: COMPLETED!

        //Write a method to accept two integers as parameters and check whether they are equal or not: COMPLETED!

        //Write a method to check whether a given number is even or odd: COMPLETED!

        //Write a method to check whether a given number is positive or negative: COMPLETED!

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse(): COMPLETED!

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10: COMPLETED!

        //Write a method to display the multiplication table(from 1 to 12) of a given integer: COMPLETED!


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {

        }

        //Method to print numbers from 1000 to -1000
        static void PrintNumbers1000ToMinus1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

            //Method to print numbers 3 through 999 by 3 each time
            static void PrintNumbersBy3()
            {
                for (int i = 3; i <= 999; i += 3)
                {
                    Console.WriteLine(i);
                }
            }

            //Method to check is numbers are equal
            static bool AreNumbersEqual(int num1, int num2)
            {
                return num1 == num2;
            }

            //Method to check is numbers are Odd or Even
            static string IsEvenOrOdd(int number)
            {
                return (number % 2 == 0) ? "Even" : "Odd";
            }

            //Method to check if a number is positive or negative
            static string IsPositiveorNegative(int number)
            {
                return (number >= 0) ? "Positive" : "Negative";
            }

            // Method to determine if a candidate can vote based on age
            static string CanVote(string ageInput)
            {
                if (int.TryParse(ageInput, out int age))
                {
                    return (age >= 18) ? "Can vote" : "Cannot vote";
                }
                else
                {
                    return "Invalid age";
                }
            }

            // Method to check if an integer is in the range -10 to 10
            static bool IsInRange(int number)
            {
                return number >= -10 && number <= 10;
            }

            // Method to display the multiplication table of a given integer
            static void DisplayMultiplicationTable(int number)
            {
                Console.WriteLine($"Multiplication table for {number}:");
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
        }
    }
}




