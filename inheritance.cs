using System;

public class Base
{
    public int left;
    public int top;
    
    public void Set(int horizontal, int vertical)
    {
        left = horizontal;
        top = vertical;
    }
    
    public void Show()
    {
        Console.WriteLine($"{left},{top}");
    }
}

public class Derived : Base
{
    public int depth;
    
    public Derived(int z)
    {
        depth = z;
    }
    
    public void ShowDepth()
    {
        Console.WriteLine(depth);
    }
}

class Program
{
    static void Main()
    {
        Derived obj = new Derived(3);
        
        obj.Set(1, 2);
        obj.Show();
        obj.ShowDepth();
    }
}
