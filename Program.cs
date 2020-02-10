using System;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {



      // Create a variable (use your best judgment for type) that stores the numberOfCupsOfCoffee that you drink every day

      var numberOfCupsOfCoffee = 0;

      //Create a variable (use your best judgment for type) called fullName and set it equal to your full name.

      var fullName = "Marcus De La Garza";
      //Create a variable (use your best judgment for type) call today and set it equal to today's date.
      // Use the type DateTime to represent today.

      var today = DateTime.Now;

      //using your variables, numberOfCupsOfCoffee, fullNameand today, Console.WriteLine out all three on one line.
      Console.WriteLine(fullName + "has drank " + numberOfCupsOfCoffee + " cups of coffee on " + today);

      //Ask the user for their name and store it in a variable called 'user'.
      Console.WriteLine("What is your name?");
      var user = Console.ReadLine();
      //Print out a greeting to the user, using their name
      // Some logic to your program that prints our a special message for a user with the of Alice
      if (user == "Alice")
      {
        Console.WriteLine("Hello Alice, we've been waiting for you");
      }
      else
      {
        Console.WriteLine("Hello " + user);
      }
      //Ask the user to input two numbers
      Console.WriteLine("Please enter two numbers, one at a time.");
      //Get the numbers as Strings using Console.ReadLine
      var number1 = Console.ReadLine();
      var number2 = Console.ReadLine();
      //Convert a String to a double using double.parse. Save the first double value in an operand1 variable and the second double value in an operand2 variable
      var operand1 = double.Parse(number1);
      var operand2 = double.Parse(number2);
      //Add the operands and save in a sum variable
      var sum = operand1 + operand2;
      //Subtract the operands and save in a difference variable
      var difference = operand1 - operand2;
      //Divide the operands and save in a quotient variable
      var quotient = operand1 / operand2;
      //Multiply the operands and save in a product variable
      var product = operand1 * operand2;
      //Find the remainder when one operand is divided by the other and save in a remainder variable. See this page if you need to learn more about the modulo operator.
      var remainder = operand1 % operand2;
      //print all the results to the screen in a meaningful way.
      Console.WriteLine("Hello " + user + " your numbers were " + number1 + " and " + number2);
      Console.WriteLine("The sum of your numbers is " + sum);
      Console.WriteLine("The differene of your numbers is " + difference);
      Console.WriteLine("The product of of your numbers after division is " + quotient);
      Console.WriteLine("The product after multiplying your numbers is " + product);
      Console.WriteLine("The remainder after dividing your numbers is " + remainder);
      //Move all of your logic to separate file and Call it from the Main method
    }
  }
}
