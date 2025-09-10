using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var credits= ConsoleExtension.GetInter("Número de créditos....: ");
    var creditValue = ConsoleExtension.GetDecimal("Valor credito..:");
    var stratum= ConsoleExtension.GetInter("Estrato del estudiante:");

    var registrationValue = CalculateregistrationValue(credits, creditValue, stratum);
    var subsidy = Calculatesubsidy(stratum);

    Console.WriteLine($"Costo de la matricula....: {registrationValue,20:c2}");
    Console.WriteLine($"valor del subsidio.......: {subsidy,20:c2}");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal Calculatesubsidy(int stratum)
{
    if (stratum==1) {

        return 200000m;
    }
    if (stratum == 2)
    {

        return 100000m;
    }

    return 0;
}

decimal CalculateregistrationValue(int credits, decimal creditValue, int stratum)
{
    decimal value;
    if (credits <= 20) {
        value = credits * creditValue;

    } else {
        value = 20 * creditValue + (credits - 20) * creditValue * 2;
    }

    if (stratum==1) {
        return value * 0.2m;// m money 0.2 es el 80%
    }
    if (stratum == 2)
    {
        return value * 0.5m;// m money
    }
    if (stratum == 3)
    {
        return value * 0.7m;// 0.7 es el 30%
    }

    return value;
}