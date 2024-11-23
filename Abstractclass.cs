using System;

public abstract class Shape
{
    public abstract void Draw(); // Abstract method
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}

public class Prism : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Prism");
    }
}

class Program
{
    static void Main()
    {
        Shape shapeOne = new Circle();    // Polymorphism
        Shape shapeTwo = new Rectangle();// Polymorphism
        Shape shapeThree = new Prism();// Polymorphism

        shapeOne.Draw(); // Calls Circle's Draw()
        shapeTwo.Draw(); // Calls Rectangle's Draw()
        shapeThree.Draw();// Calls Prism,s Draw()
    }
}
