using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var a=ConsoleExtension.GetDouble("Ingrese el valor de a: ");
    var b=ConsoleExtension.GetDouble("Ingrese el valor de b: ");
    var c=ConsoleExtension.GetDouble("Ingrese el valor de c: ");
    var solution = CuadraticEquuationSolution(a,b,c);

    Console.WriteLine($"x1 ={solution.x1:n5}");
    Console.WriteLine($"x2 ={solution.x2:n5}");
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

CuadraticEquuationSolution CuadraticEquuationSolution(double a, double b, double c)
{
    return new CuadraticEquuationSolution
    {
        x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a),
        x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a),
    };

}

public class CuadraticEquuationSolution{ 

    public double x1 { get; set; }
    public double x2 { get; set; }
}
