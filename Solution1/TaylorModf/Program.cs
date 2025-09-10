﻿using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInter("Cuantos terminos desea: ");
    var x = ConsoleExtension.GetDouble("Digita el valor de x:   ");

    var taylor = TaylorModified(x, n);
    Console.WriteLine($"f({x}) = {taylor:F5}");
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

double TaylorModified(double x, int n)
{
    double sum = 0;
    int signo = 1;
    for (int i = 0; i < n; i++)
    {

        sum += Math.Pow(x, i) / MyMath.Factorial(i)* signo;
        signo *= -1;
    
    }
    return sum;
}