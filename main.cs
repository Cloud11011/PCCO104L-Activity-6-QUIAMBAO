using System;

class Program {

  public static void Main (string[] args) {
    Console.WriteLine("Choose the Activity that you want to do");

    while(true)
    {
            Console.WriteLine("\nSelect an activity from 1-5:");
            Console.WriteLine("1 - PH Money Denomination");
            Console.WriteLine("2 - Number Divisibility by 3 and 5");
            Console.WriteLine("3 - Input Message");
            Console.WriteLine("4 - Build Pyramid");
            Console.WriteLine("5 - Sum vs. Append");
            Console.WriteLine("0 - Exit");

            Console.Write("Enter the activity number: ");
            string activityChoice = Console.ReadLine();

            switch (activityChoice)
            {
                case "1":
                    MoneyActivity();
                    break;
                case "2":
                    NumberActivity();
                    break;
                case "3":
                    InputActivity();
                    break;
                case "4":
                    PyramidActivity();
                    break;
                case "5":
                    SumNAppendActivity();
                    break;
                case "0":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid activity number.");
                    break;
            }
        }
    }

    static void MoneyActivity()
      {
Console.WriteLine("Welcome to Philippine Bank Note Scanner!");
        Console.WriteLine("Please enter the denomination (in PHP):");

        if (double.TryParse(Console.ReadLine(), out double denomination))
        {
            string personality = banknotepersonality(denomination);
            if (personality != null)
                Console.WriteLine($"Personality found on {denomination} PHP: {personality}");
            else
                Console.WriteLine("No person is found on the banknote.");
        }
        else
        {
            Console.WriteLine("Invalid Denomination");
        }
    }

    static string banknotepersonality(double denomination)
    {
        switch (denomination)
        {
            case 1: return "Jose Rizal";
            case 5: return "Emilio Aguinaldo";
            case 10: return "Andres Bonifacio, Apolinario Mabini";
            case 20: return "Manuel L. Quezon";
            case 50: return "Sergio Osmena";
            case 100: return "Manuel Roxas";
            case 200: return "Diosdado Macapagal";
            case 500: return "Benigno Sr. and Corazon Aquino";
            case 1000: return "Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda";
            default: return null;
        }
    }

    static void NumberActivity()
    {
      int num = 30;
      for (int i = 1; i <= num; i++){
        if (i % 3 == 0 && i % 5 == 0){
          Console.WriteLine($"{i} - Foobar");
          }
        else if (i % 5 == 0){
          Console.WriteLine($"{i} - Bar");
          }
        else if (i % 3 == 0){
          Console.WriteLine($"{i} - Foo");
          }
        else{
          Console.WriteLine(i);
          }
    }
    }
    static void InputActivity()

    {  Console.WriteLine("Welcome to the My Input Code!");
          Console.WriteLine("Enter text or type 'exit' to end the program:");

          string input;
          while ((input = Console.ReadLine()) != "exit")
          {
              Console.WriteLine("You entered this text: " + input);
          }

          Console.WriteLine("PROGRAM CLOSED. Press any key to exit this please.");
          Console.ReadKey();
      }
    static void PyramidActivity()
      {
        int num;
        bool validinput;

        do { Console.Write("Enter the number of rows: ");
             string input = Console.ReadLine();

             validinput = int.TryParse(input, out num) && num >= 0;

            if(!validinput) {
                Console.Write("Invalid Input, Input a non-negative Integer:  ");
            } 

            else if (num == 0) {
                Environment.Exit(0);
            }
            else {
             for (int i = 1; i <= num; i++) {
                    for (int j = 1; j <= num - i; j++) {
                    Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++) {
                        Console.Write("*");
                        if (j < i) {
                            Console.Write("*");
                        }
                    }

                    Console.WriteLine();
                }
            }

        } while (!validinput || num != 0);
     }
      static void SumNAppendActivity()                    {
        string inputstring = "String of words: ";
        int sumofintegers = 0;

        while (true)
        {
            Console.Write("Enter a string or an integer(Enter 'exit' to exit program): ");
            string userInput = Console.ReadLine();

            if (userInput == "exit")
            {
                Console.WriteLine("Exiting the program.");
                break;
            }

            if (int.TryParse(userInput, out int number))
            {
                sumofintegers += number;
                Console.WriteLine("Sum of integers: " + sumofintegers);
            }
            else
            {
               inputstring += userInput;
               Console.WriteLine(inputstring); 
            }
        }
      }
}
