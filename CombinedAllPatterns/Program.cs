


//5.Комбинация всех паттернов для анализа объектов
//Создайте классы:

//Shape(базовый класс).
//Circle(наследник с полем Radius).
//Rectangle(наследник с полями Width и Height).
//Triangle(наследник с полями Base и Height).
//Напишите метод DescribeShape(Shape shape), который:

//Использует комбинацию паттернов типов, свойств, кортежей и позиционных паттернов для анализа:
//Если это Circle, возвращает: "Круг с радиусом [Radius]".
//Если это Rectangle, проверяет:
//Если это квадрат (Width == Height), возвращает: "Квадрат со стороной [Width]".
//Иначе возвращает: "Прямоугольник [Width]x[Height]".
//Если это Triangle, возвращает: "Треугольник с основанием [Base] и высотой [Height]".
//Для других объектов возвращает: "Неизвестная фигура".


// Time 60:00 minute


using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(15);
        Shape rectangle = new Rectangle(15, 15);
        Shape rectangle2 = new Rectangle(15, 16);
        Shape triangle = new Triangle(3, 15);

        
        
        
        //DescribeShape();
        Console.WriteLine(DescribeShape(circle));
        Console.WriteLine(DescribeShape(rectangle));
        Console.WriteLine(DescribeShape(rectangle2));
        Console.WriteLine(DescribeShape(triangle));
    }

    static string DescribeShape(Shape shape)
    {
        if (shape is Circle circle)
        {
            return $"Круг с радиусом {circle.Radius}";
        }
        else if (shape is Rectangle(var width, var height))
        {
            if (width == height)
            {
                return $"Это квадрат со стороной {width}";
            }

            return $"Это прямоугольник {width}x{height}";
        }
        else if (shape is Triangle { Height: (var triangleHeight), Base: (var triangleBase)})
        {
            return $"Это треугольник с основанием {triangleBase} и высотой {triangleHeight}";
        }
        else
        {
            return "Неизвестная фигура";
        }
    }
}

abstract class Shape;

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public void Deconstruct(out double width, out double height)
    {
        width = Width;
        height = Height;
    }
}


class Triangle : Shape
{
    public int Base { get; set; }
    public double Height { get; set; }

    public Triangle(int basse, double height)
    {
        Base = basse;
        Height = height;
    }

}
