Console.WriteLine("Hello, World!");
Console.WriteLine("Введите значение радиуса окружности 'r' ");
Console.WriteLine("Введите координаты точки соответственно 'x' и 'y' ");
Circle.Cirumference();
Circle.SqCircle();
Circle.PointCoord();
static class Circle
{
    static double r=Convert.ToDouble(Console.ReadLine());
    static double C;
    static double S;
    static double x= Convert.ToDouble(Console.ReadLine());
    static double y = Convert.ToDouble(Console.ReadLine());
    static double L;
  
    public static void Cirumference()
    {
        C = 2 * Math.PI * r;
        Console.WriteLine("Длина окружности равна {0}", C);
    }
    public static void SqCircle()
    {
        S = Math.PI * r * r;
        Console.WriteLine("Площадь круга равна {0}", S);
    }
    public static void PointCoord()
    {
        L = Math.Sqrt(x * x + y * y);
        if (L>=r)
        {
            Console.WriteLine("Точка не принадлежит кругу");
        }
        else
        {
            Console.WriteLine("Точка принадлежит кругу");
        }
    }
}
