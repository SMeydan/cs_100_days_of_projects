Console.WriteLine("Welcome to the calculator program");
Console.WriteLine("---------------------------------");


int counter = 0;

while (true)
{    
    string user_input;
    
    Console.WriteLine("Enter 1 for calculator mode; 2 for counter mode; Enter 'exit' for exit : ");
    user_input = Console.ReadLine();
    Console.WriteLine("---------------------------------");

    if(user_input == "1")
    {
        Console.WriteLine("Enter the first number: ");
        float num1 = float.Parse(Console.ReadLine());


        Console.WriteLine("Enter the operator (+, -, *, /, //, **, %): ");
        string operators = Console.ReadLine();

        Console.WriteLine("Enter the second number: ");
        float num2 = float.Parse(Console.ReadLine());
        
        if(operators == "+")
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        
        else if(operators == "-")
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        
        else if(operators == "*")
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        
        else if(operators == "/")
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        
        else if(operators == "//")
            Console.WriteLine($"{num1} // {num2} = {num1 / num2}");
        
        else if(operators == "**")
            Console.WriteLine($"{num1} ** {num2} = {Math.Pow(num1, num2)}");
        
        else if(operators == "%")
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
        
        else
        {
            Console.WriteLine("Invalid operator");
        }
    }
    
    else if(user_input == "2")
    {
        Console.WriteLine("Counter mode; Use '+' for increment and '-' for decrement");
        Console.WriteLine("----------------");
        Console.WriteLine("Enter counter value:");
        string c = Console.ReadLine();
        
        if(c == "+")
        {
            counter += 1;
            Console.WriteLine($"Counter value: {counter}");
        }
        else if(c == "-")
        {
            counter -= 1;
            Console.WriteLine($"Counter value: {counter}");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    else if(user_input == "exit" )
    {
        break;
    }

    else
    {
        Console.WriteLine("Invalid input");
    }
}