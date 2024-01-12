using System;

class Cylinder : Circle
{
    private double height;

    public Cylinder() : base()
    {
        height = 1.0;
    }

    public Cylinder(double radius, string color, double height) : base(radius, color)
    {
        this.height = height;
    }

    public double getHeight()
    {
        return height;
    }

    public void setHeight(double height)
    {
        this.height = height;
    }

    public double getVolume()
    {
        return getArea() * height;
    }

    public override string ToString()
    {
        return $"Cylinder: radius={getRadius()}, color={getColor()}, height={height}, volume={getVolume()}";
    }
}

class Cricle
{
    static void Main()
    {
        // Test for Circle
        Circle circle1 = new Circle();
        Console.WriteLine(circle1);

        Circle circle2 = new Circle(3.5, "blue");
        Console.WriteLine(circle2);

        // Test for Cylinder
        Cylinder cylinder1 = new Cylinder();
        Console.WriteLine(cylinder1);

        Cylinder cylinder2 = new Cylinder(3.5, "green", 5.0);
        Console.WriteLine(cylinder2);
    }
}
