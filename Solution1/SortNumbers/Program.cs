using Shared;

var response = String.Empty;//string vacio

do
{
    Console.WriteLine("Ingrese 3 numeros diferentes");
        var a = ConsoleExtension.GetInt("ingrese primer numero:");
        var b = ConsoleExtension.GetInt("ingrese segundo numero:");
    if (a==b) {
        Console.WriteLine("Deben ser diferentes, vuelva a empezar...");
        continue;
    }
        var c = ConsoleExtension.GetInt("ingrese tercer numero:");
    if (b==c|| c==a)
    {
        Console.WriteLine("Deben ser diferentes, vuelva a empezar...");
        continue;
    }
    if (a > b && a>c)
    {
        if (b > c)
        {
            Console.WriteLine($"El mayor es {a}, el medio es {b}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {a}, el medio es {c}, el menor es {b}");
        }
    }
    else if(b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El mayor es {b}, el medio es {a}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {b}, el medio es {c}, el menor es {a}");
        }
    }
    else 
    {
        if (a >b)
        {
            Console.WriteLine($"El mayor es {c}, el medio es {a}, el menor es {b}");
        }
        else
        {
            Console.WriteLine($"El mayor es {c}, el medio es {b}, el menor es {a}");
        }
    }


} while (true);
