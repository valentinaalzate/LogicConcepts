using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("*** ORDENACION ESPECIAL DE UN ARREGLO***");
    var n = ConsoleExtension.GetInter("Cuantas posiciones quieres en el arreglo: ");
    var numbers = new int[n];

    //do process
    FillArrayt(numbers);


    //results
    Console.WriteLine("arreglo sin ordenar =>");
    ShowArray(numbers);
    Console.WriteLine();
    var numbersEven = GetNumbersEven(numbers);
    var numbersOdd = GetNumbersOdd(numbers);

    OrderArray(numbersEven,true);
    OrderArray(numbersOdd);

    Console.WriteLine("arreglo ordenado =>");
    ShowArray(numbersEven);
    ShowArray(numbersOdd);
    Console.WriteLine();

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
        Console.WriteLine();
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

int[] GetNumbersOdd(int[] numbers)
{
    var contOdds = 0;
    foreach (var number in numbers)
    { //este ciclo es para contar los numeros impares 
        if (!IsEven(number))
        {
            contOdds++;
        }
    }

    var numbersOdd = new int[contOdds];

    var i = 0;
    foreach (var number in numbers)
    {
        if (!IsEven(number))
        {
            numbersOdd[i] = number; // asignamos el numero y luego construimos el arreglo de numeros impares
            i++;
        }
    }

    return numbersOdd;
}

int[] GetNumbersEven(int[] numbers)
{
    var contEven = 0;
    foreach (var number in numbers) { //este ciclo es para contar los numeros pares 
        if (IsEven(number)) {
            contEven++;
        }
    }

    var numbersEven = new int[contEven];

    var i = 0;
    foreach (var number in numbers)
    { 
        if (IsEven(number))
        {
            numbersEven[i] = number; // asignamos el numero y luego construimos el arreglo de numeros pares
            i++;
        }
    }

    return numbersEven;
}

bool IsEven(int number)
{
    return number % 2 == 0;
}

void OrderArray(int[] numbers, bool isDescending = false)
{
    for (int i=0; i<numbers.Length-1;i++) {

        for (int j=i+1;j<numbers.Length;j++) {

            if (isDescending)
            {
                if (numbers[i] < numbers[j])
                {
                    //para que le afecte lo del metodo
                    Change(ref numbers[i], ref numbers[j]); // ref referencia

                }
            }
            else {
                if (numbers[i] > numbers[j])
                {
                    //para que le afecte lo del metodo
                    Change(ref numbers[i], ref numbers[j]); // ref referencia

                }

            }
        }
    
    }
}

void Change(ref int number1,ref int number2) // ref lo que se cambie aqui afecta a numbers[i] y numbers [j]
{
    int aux = number1;
    number1 = number2;
    number2 = aux;
}

void ShowArray(int[] numbers)
{
    foreach (var number in numbers) // utilizarlo cuando no necesito el subindice u operaciones, o solo para recorrer y no llenar un arreglo
    {
        Console.Write($"{number,10:n0}");
    }
  
}

void FillArrayt(int[] numbers) // estamos recibiendo un arreglo
{
    var random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(0, 100);
    }
}