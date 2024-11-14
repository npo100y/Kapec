float a = 0.0f;
float b = 0.0f;
string c = "";
Console.WriteLine("Калькулятор (знак '=' для результата)\n\n");

Console.WriteLine("Введите число:");
b = Convert.ToInt32(Console.ReadLine());

while (true)
{
    Console.WriteLine("Введите знак: ");
    c = Console.ReadLine();
    if (c[0] == '-' || c[0] == '+' ||c[0] == '*' || c[0] == '/')
    {
        Console.WriteLine("Введите следующее число: ");
        a = Convert.ToInt32(Console.ReadLine());
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
