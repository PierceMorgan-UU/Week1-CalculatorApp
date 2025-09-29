CalculatorApp();
void CalculatorApp()
{
    //Declare the variables and initialise them to 0
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    //Ask the user to declare the first number 
    Console.WriteLine("Type in the first number and use the enter key to confirm: ");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    //Ask the user to declare the second number
    Console.WriteLine("Type in the second number and use the enter key to confirm: ");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    //use a loop to make the relevant decision
    //and perform the requested maths operation
    Console.WriteLine("Choose an option from the following list: ");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    //Convert string to integer 
    choice = Convert.ToInt32(Console.ReadLine());

    //Use an IF statement to perform selected maths operation
    if (choice == 1)
    {   //Perform the calculation 
        result = firstNumber + secondNumber;
        Console.WriteLine($"The addition of {firstNumber} and {secondNumber} is {result}");
    }
    else if (choice == 2)
    {   //Perform the calculation
        result = firstNumber - secondNumber;
        Console.WriteLine($"The subtraction of {firstNumber} and {secondNumber} is {result}");
    }
    else if (choice == 3)
    {   //Perform the calculation
        result = firstNumber / secondNumber;
        Console.WriteLine($"The division of {firstNumber} and {secondNumber} is {result}");
    }
    else if (choice == 4)
    {   //Perform the calculation
        result = firstNumber * secondNumber;
        Console.WriteLine($"The multiplication of {firstNumber} and {secondNumber} is {result}");
    }
    else
    {
        Console.WriteLine("That is not a valid number between 1 -4");
    }

    Console.ReadKey();
}
