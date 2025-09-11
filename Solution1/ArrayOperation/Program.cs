using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("*** OPERACIONES EN UN ARREGLO***");
    var n = ConsoleExtension.GetInter("Cuantas posiciones quieres en el arreglo: ");
    var numbers = new int[n];

    //do process
    FillArrayt(numbers);
  
   

    //results
    ShowArray(numbers);
    Console.WriteLine($"La sumatoria es: {numbers.Sum(),30:n2}"); //.sum() suma
    Console.WriteLine($"El promedio es:  {numbers.Average(),30:n2}"); // .average() promedio

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
        Console.WriteLine();
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));


void ShowArray(int[] numbers)
{
    foreach (var number in numbers) // utilizarlo cuando no necesito el subindice u operaciones, o solo para recorrer y no llenar un arreglo
    {
        Console.Write($"{number,10:n0}");
    }
    Console.WriteLine();
}

void FillArrayt(int[] numbers) // estamos recibiendo un arreglo
{
    var random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(0, 100);
    }
}