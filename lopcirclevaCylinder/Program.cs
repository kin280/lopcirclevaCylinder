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

 class Program
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
