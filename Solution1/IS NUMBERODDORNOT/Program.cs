var numberString = string.Empty;
do
{
    Console.Write("Ingrese un número entero o 's' para salir: "); // esto para mensaje
    numberString = Console.ReadLine(); //para que el eusuario ingrese un numero y var es variable
    
    if (numberString.ToLower() =="s") {// tolower convertir a minuscula
        continue;//evalua la condicion del ciclo
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt)) //tryParse me devuelve un booleano y que si se puede convertir se lo pase a entero
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El numero {numberInt}, es par");//WriteLine para salto de linea y $
                                                                //interpolacion para combinar texto y numero
        }
        else
        {
            Console.WriteLine($"El numero {numberInt}, es impar");
        }
    }
    else {
        Console.WriteLine($"Lo que ingresaste: {numberString}, no es un numero entero");
    }


    
} while (numberString.ToLower()!= "s");
Console.WriteLine("Game Over..");