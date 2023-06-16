// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Check c = new();
        var num = Console.ReadLine();
        int a = Convert.ToInt32(num);
        
        bool answer = c.CheckMod(a);
        Console.WriteLine("number is multiple of two:" +answer);
        Console.ReadLine();
    }
}