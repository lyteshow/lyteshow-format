using System;
using System.IO;
using Lyteshow;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Please input a path to a .JSON Lyteshow File: ");
        string? path = Console.ReadLine();
        if(path != null)
        {
            string jsonString = File.ReadAllText(path);
            LyteFile? file = LyteFormat.DeserializeLyte(jsonString);
            Console.WriteLine("Printing the time value of the first object:");
            Console.WriteLine(file?.objects?[0].Time);
        }
    }
}