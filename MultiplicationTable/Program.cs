using System;
class Progam
{
    public static int[] Multiplicationtable(int n,int upto)
    {
        int[] row=new int[upto];
        for(int i = 1; i <=upto; i++)
        {
            row[i-1]=n*i;
        }
        return row;

    }
    public static void Main()
    {
        int n=Convert.ToInt32(Console.ReadLine());
        int upto=Convert.ToInt32(Console.ReadLine());
        int[] arr=Multiplicationtable(n,upto);
        for(int i = 1; i <=upto; i++)
        {
            System.Console.Write(arr[i-1]+" ");
        }
        
    }
}