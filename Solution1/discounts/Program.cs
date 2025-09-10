using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var desks = ConsoleExtension.GetInter("Número de escritorios: ");
    var valueToPay = CalculateValue(desks);

    Console.WriteLine($"El valor a pagar es: {valueToPay:c2}");
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

object CalculateValue(int desks)
{
    float discount;

    if (desks < 5)
    {
        discount = 0.10f;
    }
    else if (desks < 10)
    {
        discount = 0.2f;
    }
    else
    {
        discount = 0.4f;

    }
   return desks * 650000M * (decimal)(1 - discount);
}