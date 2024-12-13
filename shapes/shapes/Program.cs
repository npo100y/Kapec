abstract class Shape
{
    public abstract double Square_Volume();
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    public override double Square_Volume()
    {
        return length * width;
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Square_Volume()
    {
        return 3.14 * radius * radius;
    }
}

class Cylinder : Shape
{
    private double radius;
    private double height;

    public Cylinder(double radius, double height)
    {
        this.radius = radius;
        this.height = height;
    }

    public override double Square_Volume()
    {
        // Площадь основания умноженная на высоту
        return 3.14 * radius * radius * height;
    }
}

class Program
{
    static void Main()
    {
        // Создание объекта прямоугольника
        Shape rectangle = new Rectangle(3, 4);
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Square_Volume()}");

        // Создание объекта окружности
        Shape circle = new Circle(5);
        Console.WriteLine($"Площадь окружности: {circle.Square_Volume()}");

        // Создание объекта цилиндра
        Shape cylinder = new Cylinder(2, 10);
        Console.WriteLine($"Объем цилиндра: {cylinder.Square_Volume()}");
    }
}