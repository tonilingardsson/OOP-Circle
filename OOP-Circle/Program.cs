using System;

class Circle // US3
{
    // Private fields: data that belongs to every circle created
    private float _pi = 3.141f; // Use _underscore for private fields
    private int _radius; // Just declaring, will use it as a param

    // Constructor: when executed, it creates a new circle
    public Circle(int radius)
    {
        _radius = radius; // Saving the radius assigned while calling the constructor. US4
    }

    // Method to calculate area. US5
    public float GetArea()
    {
        return _radius * _radius * _pi;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create two new circles, 5 and 6 as value for radius. US6
        Circle circle1 = new Circle(5);
        Circle circle2 = new Circle(6);

        // Calculate their area. US7
        float area1 = circle1.GetArea();
        float area2 = circle2.GetArea();

        Console.WriteLine($"Area för cirkel med radie 5 är: {area1}");
        Console.WriteLine($"Area för cirkel med radie 6 är: {area2}");

        // Keep the console open
        Console.Read();
    }
}