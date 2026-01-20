using System;
using System.Xml;
class Program
{
    public double Area(double radius)
    {
        
        double Area=Math.PI*(radius*radius);
        return Area;
    }
    public static void Main()
    {
        Program p=new Program();
        double input=Convert.ToDouble(Console.ReadLine());
        double output=p.Area(input);
        System.Console.WriteLine(Math.Round(output,2));
    }
}
