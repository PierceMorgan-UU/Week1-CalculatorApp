//This integer variable stores the first number 
Console.WriteLine("Type in the first number and use the enter key to confirm: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

//This integer variable stores the second number
Console.WriteLine("Type in the second number and use the enter key to confirm: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//This integer variable stores the sum of firstNumber and secondNumber 
int result = firstNumber + secondNumber;

Console.WriteLine("The addition of both numbers is {0}", result);
Console.ReadKey();