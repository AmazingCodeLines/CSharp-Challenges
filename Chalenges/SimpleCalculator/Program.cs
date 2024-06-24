

/* Chalenge 1. Simple Calculator


Challenge: Simple Calculator

Create a simple console application in C# that functions as a basic calculator. The program should:

1. Prompt the user to enter two numbers.
2. Prompt the user to choose an operation (addition, subtraction, multiplication, division).
3. Perform the chosen operation on the two numbers.
4. Display the result to the user.

Requirements:
- Use `Console.ReadLine()` for accepting user input.
- Utilize `Console.WriteLine()` for displaying prompts and results.
- Implement basic control structures (`if`, `else if`, `else`) for handling user choices.
- Use appropriate variable types (`int`, `double`) based on the operations.
- Handle basic error scenarios (e.g., division by zero).
- Use comments to explain sections of your code.

Example Interaction:

Welcome to Simple Calculator App!

Enter the first number: 10
Enter the second number: 5

Choose an operation:
1. Addition
2. Subtraction
3. Multiplication
4. Division

Enter your choice (1/2/3/4): 3

Result of multiplication: 50


Tips:
- Start by declaring variables to store user input and results.
- Use `Convert.ToInt32()` or `Convert.ToDouble()` to convert string inputs to numerical types.
- Implement a loop to handle invalid inputs and ask the user to retry.
- Consider encapsulating operations in separate methods for better organization and reusability.
 */


using System;


class SimpleCalculator
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to the Simple Calculator App!");

        // Get first number from the user
        Console.WriteLine("Enter a number: ");
        double firstNumber = GetValidNumber();

        // Display operations choices
        Console.WriteLine("[1] to add.");
        Console.WriteLine("[2] to subtract.");
        Console.WriteLine("[3] to multiply.");
        Console.WriteLine("[4] to divide.");

        //Get the operation from the user
        Console.WriteLine("Choose an operation: ");
        int choice = GetValidChoice();

        // Get the second number from the user
        Console.WriteLine("Enter a number: ");
        double secondNumber = GetValidNumber();

        // Perform the choosen operation and present the result
        double result = 0;
        bool validOperation = true;

        switch (choice)
        {
            case 1: // Addition
            result = firstNumber + secondNumber;
            Console.WriteLine($"\nResult: {firstNumber} + {secondNumber} = {result}");
            break;

            case 2: // Subtraction
            result = firstNumber - secondNumber;
            Console.WriteLine($"\nResult: {firstNumber} - {secondNumber} = {result}");
            break;

            case 3: // Multiplication
            result = firstNumber * secondNumber;
            Console.WriteLine($"\nResult: {firstNumber} * {secondNumber} = {result}");
            break;

            case 4: // Division
                if(secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"\nResult: {firstNumber} / {secondNumber} = {result}");
                }
                else
                {
                    Console.WriteLine("Invalid operation.");
                    validOperation = false;
                }
                break;


            default:
                Console.WriteLine("Invalid Operation.");
                validOperation = false;
                break;

        }
        // Display a message if the operation was successful
        if(validOperation)
        {
            Console.WriteLine("Operation Successful.");
        }
    }

    static double GetValidNumber()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid Input. Please enter a valid number.");
        }
        return number;
    }

    static int GetValidChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid Choice. Please enter a valid choice.");
        }
        return choice;
    }
}
