using Shared;

var response = String.Empty;//string vacio

do
{
    try
    {
        var number1 = ConsoleExtension.GetInt("ingrese primer numero:");
        var number2 = ConsoleExtension.GetInt("ingrese segundo numero:");
        var number3 = ConsoleExtension.GetInt("ingrese tercer numero:");

        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine($"El numero mayor es {number1}");
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine($"El numero mayor es {number2}");
        }
        else if (number3 > number1 && number3 > number2)
        {
            Console.WriteLine($"El numero mayor es {number3}");
        }
        else
        {
            Console.WriteLine("los numeros son iguales o no se puede determinar un unico numero mayor");
            }
    }catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    
    Console.Write("desea continuar [S/N]?");
    response = Console.ReadLine()!.ToUpper(); //igual a lo que el usuario lea
} while (response == "S");