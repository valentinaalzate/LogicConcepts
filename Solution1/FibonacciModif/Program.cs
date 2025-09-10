using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInter("Cuantos terminos quiere (minimo 3): ");
    double a = 0;
    double b = 1;
    double c = 2;
    Console.Write($"{a,20:n0}{b,20:n0}{c,20:n0}");

    for (int i = 3; i < n; i++)
    {

        double d = a + b+c;
        Console.Write($"{d,20:n0}");
        a = b;
        b = c;
        c = d;

    }

    Console.WriteLine();
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

