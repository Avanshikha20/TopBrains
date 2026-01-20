using System;
class Program
{
    public static string TimeConversion(int Tseconds)
    {
        int minute=Tseconds/60;
        int Seconds=Tseconds%60;
        
        return minute+":"+Seconds.ToString("D2");

    }
    public static void Main()
    {
        int Seconds=Convert.ToInt32(Console.ReadLine());
        string output=TimeConversion(Seconds);
        System.Console.WriteLine(output);
    }
}
