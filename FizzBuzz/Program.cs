using System;
namespace FizzBuzz
{/// <summary>
/// This class computes the FizzBuzz from an user input
/// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            //Getting a user input from the console
            string userInputInString = Console.ReadLine();
            int userValue;
            if (int.TryParse(userInputInString, out userValue))
            {
                Console.WriteLine(FizzBuzz(userValue));
            }
            else
            {
                Console.WriteLine("User Input must be an integer");
            }
        }
        /// <summary>
        /// This method calculates whether  the input 
        /// value is Fizz, Buzz, Both ,or none of these
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns>String Output </returns>
        public static string FizzBuzz(int userInput)
        {
            //I chose this approach than the traditional - 
            //if else because in this application user is entering number from the console
            //If we were to build an app that processes a large amouunt of random numbers, you could 
            //either use bitwise modulo or even traditional approach would be better  

           string outPut = "" ;
            if ((userInput % 3) == 0)
            {
                outPut+="Fizz";
            }
            if (userInput % 5 == 0)
            {
                outPut += "Buzz";
            }
            if (outPut.Length == 0)
            {
                outPut =userInput.ToString();
            }
            return outPut;

        }
    }
}
