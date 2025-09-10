using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInter("Cuantos números primos quieres: ");
    var primes = GetPrimes(n);
    foreach (var prime in primes)
    {// por cada numero primo en la lista de primos se imprime
        Console.Write($"{prime,10:n0}");
    
    }
    Console.WriteLine();
    Console.WriteLine($"La sumatoria es: {primes.Sum(),10:n0}");
    Console.WriteLine($"El promedio es: {primes.Average(),10:n0}");
    Console.WriteLine();
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
        Console.WriteLine();
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

List<int> GetPrimes(int n)
{
    var primes = new List<int>();
    var num = 2; // El primer número primo
    while (primes.Count< n) {

        if (MyMath.IsPrime(num)) {
            primes.Add(num);
        
        }
        num++;
    
    }
    return primes;
}