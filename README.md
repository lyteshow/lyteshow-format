# lyteshow-format
C# library for interacting with the .JSON lyteshow format

# Usage
A basic example can be found in `/Tests`:

```cs
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
            LyteFile? file = Utils.DeserializeLyte(jsonString);
            Console.WriteLine("Printing the time value of the first object:");
            Console.WriteLine(file?.objects?[0].Time);
        }
    }
}
```

More detailed docs will be available as the project advances.

# License
This library is licensed under the MIT License. Please check `/LICENSE.txt` for more info.