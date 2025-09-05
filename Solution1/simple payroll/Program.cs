using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var name = ConsoleExtension.GetString    ("Ingrese su nombre...........: ");
    var workHours = ConsoleExtension.GetFloat("Ingrese numero de horas trabajadas: ");
    var hourValue = ConsoleExtension.GetDecimal("Ingrese valor hora: ");
    var salaryMinimun = ConsoleExtension.GetDecimal("Ingrese valor salario mínimo mensual: : ");

    var salary = (decimal) workHours * hourValue; //castin para que el resultado sea decimal

    if (salary < salaryMinimun)
    {
        Console.WriteLine($"Nombre{ name}");
        Console.WriteLine($"Salario {salaryMinimun:c2}");//c2 de moneda en 2 decimales
    }
    else {
        Console.WriteLine($"Nombre{name}");
        Console.WriteLine($"Salario {salary:c2}");
    }

        do
        {
            answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
        } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
