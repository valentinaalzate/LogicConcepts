using Shared;



do
{
    var a = ConsoleExtension.GetInt("ingrese primer numero:");
    var b = ConsoleExtension.GetInt("ingrese segundo numero:");

    if (b % a == 0)
    {
        Console.WriteLine($"El numero {a} es multiplo de  {b}");
    }
    else {
        Console.WriteLine($"{a} no es  multiplo de {b}");
    }


} while (true);

