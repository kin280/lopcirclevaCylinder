using System;

class Circle
{
    private double radius;
    private string color;

    public Circle()
    {
        radius = 1.0;
        color = "red";
    }

    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }

    public double getRadius()
    {
        return radius;
    }

    public void setRadius(double radius)
    {
        this.radius = radius;
    }

    public string getColor()
    {
        return color;
    }

    public void setColor(string color)
    {
        this.color = color;
    }

    public double getArea()
    {
        return Math.PI * radius * radius;
    }

    public override string ToString()
    {
        return $"Circle: radius={radius}, color={color}, area={getArea()}";
    }
}

class Program
{
    static void Main()
    {
        Circle circle1 = new Circle();
        Console.WriteLine(circle1);

        Circle circle2 = new Circle(3.5, "blue");
        Console.WriteLine(circle2);
    }
}
