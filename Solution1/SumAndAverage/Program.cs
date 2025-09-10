using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
   var n = ConsoleExtension.GetInter("cuantos numero desea:  ");
    int sum = 0;

    //ciclos
    int i = 1;
    while (i <= n)
    {
        Console.Write($"{i}\t");
        sum += i;
        i++;

    }
    /*for (int i = 1; i <= n; i++) {

        Console.Write($"{i}\t");
        sum += i;
    }*/
    var average = sum / n;
    Console.WriteLine();
    Console.WriteLine($"La suma es: {sum,20:n0}");
    Console.WriteLine($"el primedio es: {average,20:n0}");
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

