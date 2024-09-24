// This stores the first number from the user 
Console.WriteLine("Pleaase type in the first number, then hit the enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

// this stores, and converts the second value from the user
Console.WriteLine("Pleaase type in the second number, then hit the enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// calculating answer 
int result = firstNumber + secondNumber;
Console.WriteLine("Adding {0} and {1} will give the answer of {2}", firstNumber, secondNumber, result);

