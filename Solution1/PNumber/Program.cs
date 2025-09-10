using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("*** CALCULO DEL NUMERO pi ***");
    var n = ConsoleExtension.GetInter("Cuantos terminos de presición quieres: ");

    //do process
    var pi = CalculatePi(n);

    //results
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine($"El valor de 'pi' con: {n} terminos de presicion es: {pi}");

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
        Console.WriteLine();
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

double CalculatePi(int n)
{
    double sum = 0;
    double den = 1;
    int sig = 1;

    for (int i=0; i<n;i++) {
        double ter =1 / den*sig;
        sum += ter;

        den += 2;
        sig *= -1;
    
    
    }
    return sum * 4;
}