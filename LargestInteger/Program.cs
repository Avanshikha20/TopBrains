using System;
class Program
{
    public int Largest(int a,int b,int c)
    {
        if(a>b && a > c)
        {
            return a;
        }else if(b>c && b > a)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
    public static void Main()
    {
        Program p=new Program();
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        int c=Convert.ToInt32(Console.ReadLine());
        int Largestint=p.Largest(a,b,c);
        System.Console.WriteLine(Largestint);
    }
}
