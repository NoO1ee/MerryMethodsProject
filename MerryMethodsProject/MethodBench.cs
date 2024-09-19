using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MerryMethodsProject;

internal class MethodBench
{
    public void FistMethod()
    {
        Console.WriteLine("Merry Methods");
    }

    public void SecondMethod(string args)
    {
        Console.WriteLine(args);
    }

    public void ThirdMethod(string input, bool isItTrue)
    {
        //if (isItTrue)
        //    //SecondMethod(input.ToUpper());
        //    input = input.ToUpper();
        //else
        //    //SecondMethod(input.ToLower());
        //    input = input.ToLower();

        // Ternary-operator ( ? = kolla) ( : = else)
        input = isItTrue ? input.ToUpper() : input.ToLower();

        SecondMethod(input);
    }

    public bool FourthMethod()
    {
        Console.Write("\nWould you like to [W]hisper or [S]hout?: \n");
        var keypressed = Console.ReadKey(true).Key;

        if (keypressed == ConsoleKey.S)
            return true;
        else if (keypressed == ConsoleKey.W)
            return false;
        else
            return FourthMethod();
            

    }

    public (string? Name, bool LengthyName) SixthMethod()
    {
        Console.Write("\nMata in ett namn: ");
        string? Name = Console.ReadLine()!;
        bool LengthyName = Name.Length > 5;


        return (Name, LengthyName);

    }
    
}
