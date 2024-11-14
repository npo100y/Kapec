double a = 0.0;
double b = 0.0;
string c = "";
Console.WriteLine("Калькулятор (знак '=' для результата)\n\n");

Console.WriteLine("Введите число:");
b = Convert.ToDouble(Console.ReadLine());

while (true)
{
    Console.WriteLine("Введите знак: ");
    c = Console.ReadLine();
    if (c[0] == '-' || c[0] == '+' ||c[0] == '*' || c[0] == '/')
    {
        Console.WriteLine("Введите следующее число: ");
        a = Convert.ToDouble(Console.ReadLine());
        switch (c[0])
        {
            case '+':
                b += a;
                break;
            case '-':
                b -= a;
                break;
            case '*':
                b *= a;
                break;
            case '/':
                b /= a;
                break;
        }
    }
    else if (c[0] == '=')
    {
        Console.WriteLine($"\nРезультат вычислений: {b}");
        break;
    }
}
