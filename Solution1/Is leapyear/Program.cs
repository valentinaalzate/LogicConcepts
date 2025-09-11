using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    var year = ConsoleExtension.GetInt("ingrese año:");
    if (year == currentYear)
    {
        message = "es";
    }
    else if (year > currentYear)
    {
        message = "va a ser";

    }
    else {
        message = "fue";

    }

    var isLeapYear = DayUtilitis.IsLeapYear(year);
    Console.WriteLine($"El año: {year}, {(isLeapYear? "SI":"NO")} {message} biciesto");
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));