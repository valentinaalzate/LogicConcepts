

using Shared;

var response=String.Empty;//string vacio

do
{
    try//intente
    {
        var number = ConsoleExtension.GetInt("ingrese un numero entero: ");

        if (number % 2 == 0)
        {
            Console.WriteLine($"El numero {number}, es par");
        }
        else
        {
            Console.WriteLine($"El numero {number}, es impar");
        }
    }
    catch (Exception ex)//ex nombrar la exception como ex
    {
        Console.WriteLine(ex.Message);
    }
   
 
    Console.Write("desea continuar [S/N]?");
    response= Console.ReadLine()!.ToUpper(); //igual a lo que el usuario lea
} while (response=="S");
