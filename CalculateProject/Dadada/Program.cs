using System.ComponentModel.Design;

class Calculator
{
    public static double Calculate(double first, double second, string operation)
    {
        switch (operation) {
            case "+":
                return first+second;
            case "-":
                return first - second;
            case "*":
                return first * second;
            case "/":
                return first / second;
            case "%":
                return first % second;
            default:
                return -1;
        }
    }
};

class Program
{
    static void Main()
    {
        int[] mas1 = new int[] { 5, 7, 13, 18, 34 };
        int[] mas2 = new int[] { 2, 3, 4, 5, 6 };
        string[] op = new string[] { "+", "-", "*", "/", "%" };

        Console.WriteLine("Вычисления из массивов:\n");
        for (int i = 0; i < mas1.Length; i++)
        {
            Console.WriteLine($"{mas1[i]} {op[i]} {mas2[i]} = {Calculator.Calculate(mas1[i], mas2[i], op[i])}\n");

        }

        while (true)
        {
            Console.WriteLine($"Для выхода напишите <Выход>\n");

            Console.WriteLine("Введите первое число: ");

            string temp = Console.ReadLine();
            if (temp.ToLower() == "выход") { break;}

            double first = double.Parse(temp);

            Console.WriteLine("Введите операцию (+, -, *, /, %): ");
            string operation = Console.ReadLine();
            if (operation.ToLower() == "выход") { break;}

            Console.WriteLine("Введите второе число: ");
            temp = Console.ReadLine();
            if (temp.ToLower() == "выход") { break;}
            double second = double.Parse(temp);

            Console.WriteLine($"\n{first} {operation} {second} = {Calculator.Calculate(first, second, operation)}\n");


        }
    }
}
