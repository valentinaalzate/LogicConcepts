using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInter("Cuantos terminos quiere (minimo 2): ");
    double a = 0;
    double b = 1;

    Console.Write($"{a:n0}\t{b:n0}\t");

     for (int i=2; i<n;i++) {

            double c = a + b;
            Console.Write($"{c:n0}\t");
            a = b;
            b = c;

     }

    Console.WriteLine();
        do
        {
            answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
        } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));


