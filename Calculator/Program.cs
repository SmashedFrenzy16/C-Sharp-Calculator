// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.DarkRed;
string num1;
string num2;
double doubleNum1;
double doubleNum2;
string op;

Console.Write("Enter in your first number: ");

num1 = Console.ReadLine();

doubleNum1 = Convert.ToDouble(num1);

Console.Write("Enter in your second number: ");

num2 = Console.ReadLine();

doubleNum2 = Convert.ToDouble(num2);

Console.Write("Enter in your operator: ");

op = Console.ReadLine();

if (op == "+")
{
    Console.WriteLine(doubleNum1 + doubleNum2);
}

else if (op == "-")
{
    Console.WriteLine(doubleNum1 - doubleNum2);
}

else if (op == "*")
{
    Console.WriteLine(doubleNum1 * doubleNum2);
}

else if (op == "/")
{
    Console.WriteLine(doubleNum1 / doubleNum2);
}
