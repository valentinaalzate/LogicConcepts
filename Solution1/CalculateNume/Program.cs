using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("*** CALCULO DEL NUMERO e ***");
    var n = ConsoleExtension.GetInter("Cuantos terminos de presición quieres: ");

    //do process
    var e = CalculateE(n);

    //results
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine($"El valor de e con {n} terminos de presicion es: {e}");

    Console.BackgroundColor = ConsoleColor.Blue;
     Console.ForegroundColor = ConsoleColor.White;
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
        Console.WriteLine();
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

double CalculateE(int n)
{
    double sum = 0;
    for (int i=0;i<n;i++) {
        sum += 1 / MyMath.Factorial(i);
    
    }

    return sum;
}