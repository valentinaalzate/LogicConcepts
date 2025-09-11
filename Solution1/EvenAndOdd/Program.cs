using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("*** PARES E IMPARES EN UN ARREGLO ***");
    var n = ConsoleExtension.GetInter("Cuantas posiciones quieres en el arreglo: ");
    var numbers = new int[n];
    //do process
    FillArrayt(numbers);
    var sum = GetSumEven(numbers);
    var pro = GetProdEven(numbers);

    //results
    ShowArray(numbers);
    Console.WriteLine($"La sumatoria es: {sum, 30:n0}");
    Console.WriteLine($"La productoria es: {pro,30:n0}");
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
        Console.WriteLine();
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

object GetProdEven(int[] numbers)
{
    var prod = 1;
    foreach (var number in numbers)
    {

        if (number % 2 != 0)
        {
            prod *= number;

        }
    }
    return prod;
}

int GetSumEven(int[] numbers)
{
    var sum = 0;
    foreach (var number in numbers) {

        if (number % 2 == 0) {
            sum += number;
        
        }
    }
    return sum;
}

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
    for (int i =0; i<numbers.Length; i++)
    {
        numbers[i] = random.Next(0, 100);
    }
}