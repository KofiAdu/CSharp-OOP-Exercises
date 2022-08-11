// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Shape
{
    protected Location? c;
    public double Area()
    {
        return 0.00;
    }
    public double Perimeter()
    {
        return 0.00;
    }
    public override string ToString()
    {
        return "This is a shape";
    }
}

public class Circle : Shape
{
    protected double radius;
}

public class Rectangle : Shape
{
    protected double side1;
    protected double side2;
}

public class Location
{
    private double x;
    private double y;
}
