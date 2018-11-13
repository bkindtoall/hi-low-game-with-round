using System;
using System.Collections.Generic;
using System.Linq;

  public class Program
  {
    public static void Main()
    {
        Console.WriteLine("Would you like to play the higher/lower game? (Yes/No)");
        string userAnswer = Console.ReadLine();
        if (userAnswer == "Yes") {
            Console.WriteLine("Pick a number between 1-100: ");
            int userNumber = int.Parse(Console.ReadLine());
            int computerGuess = 50;
            int maxGuess = 100;
            int minGuess = 1;
            Random rnd = new Random();
            
            
            while (computerGuess != userNumber) {
                Console.WriteLine("Is your number higher or lower than " + computerGuess + "? (Higher/Lower/Correct)");
                string userResponse = Console.ReadLine();
               
                if (userResponse == "Higher") 
                {
                    minGuess = computerGuess + 1;
                    computerGuess = rnd.Next(minGuess, maxGuess + 1);
                }
                if (userResponse == "Lower") 
                {
                    maxGuess = computerGuess - 1;
                    computerGuess = rnd.Next(minGuess, maxGuess + 1);
                }
            }
            Console.WriteLine("Your number was " + userNumber);
        
        }
        else {
            Console.WriteLine("You suck.");
        }    
  }
}
