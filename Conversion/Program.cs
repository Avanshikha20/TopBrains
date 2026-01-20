using System;
class Program
{
    public double Conversion(int Input)
    {
        double Output=Input*30.48;
        return Output;
    }
    public static void Main()
    {
        Program p=new Program();
        int input=Convert.ToInt32(Console.ReadLine());
        double output=p.Conversion(input);
        System.Console.WriteLine(Math.Round(output,2));


    }

}
