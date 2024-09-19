namespace MerryMethodsProject;
internal class Program
{

    static void Main(string[] args)
    {
        MethodBench method = new MethodBench();
        int i = 0;
        do
        {
            method.FistMethod();
            i++;

        } while (i < 3);
        method.SecondMethod("C# Now and Forever!\n");
        Console.Write("Enter something: ");
        string? input = Console.ReadLine();
        method.SecondMethod(input!);

        method.ThirdMethod(input!, Reply());

        Console.Write("\nType in a question. [S] is Upper case and [W] is lower case: ");
        string? question = Console.ReadLine();
        Console.WriteLine(question);
        
        string? check2 = Console.ReadLine()!.ToLower();

        if (check2 == "w")
            method.ThirdMethod(input!, false);
        else if (check2 == "s")
            method.ThirdMethod(input!, true);

        bool shout = method.FourthMethod();
        method.ThirdMethod(input!, shout);
        method.ThirdMethod(input!, method.FourthMethod());

        var sixth = method.SixthMethod();

        if (sixth.LengthyName)
            Console.WriteLine($"{sixth.Name} is a long name");
        else
            Console.WriteLine($"{sixth.Name} is not a long name");
    }

    static bool Reply()
    {
        Console.Write("\n[U] to print in upper case, otherwise lower case: ");
        string? check = Console.ReadLine()!.ToLower();
        return check == "u";
    }
}
