using System;
using System.Diagnostics.CodeAnalysis;
class Program
{
    public static void Main()
    {
        System.Console.WriteLine("enter no of elements :");
        int n=Convert.ToInt32(Console.ReadLine());
        int[] num=new int[n];
        for(int i = 0; i < n; i++)
        {
            num[i]=Convert.ToInt32(Console.ReadLine());
        }
        int sum=0;
        for(int i = 0; i < n; i++)
        {
            if (num[i] > 0)
            {
                sum+=num[i];
            }
            else if(num[i] == 0){
                break;
            }
            else
            {
                continue;
            }
        }
        System.Console.WriteLine(sum);


    }
}
