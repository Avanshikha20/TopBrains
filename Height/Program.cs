using System;
class Program
{
    public string Category(int height)
    {
        if (height < 150)
        {
            return "short";
        }
        else if(height>=150 && height < 180)
        {
            return "Average";
        }
        else
        {
            return "tall";
        }
    }
    public static void Main()
    {
        Program p=new Program();
        int input=Convert.ToInt32(Console.ReadLine());
        string output=p.Category(input);
        System.Console.WriteLine(output);
    }
}
