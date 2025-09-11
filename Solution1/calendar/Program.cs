using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("*** CALENDARIO ***");
    var year = ConsoleExtension.GetInter("Ingrese el año:  ");

    //do process
    

    //results
    ShowCalendar(year);
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
        Console.WriteLine();
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

void ShowCalendar(int year)
{
    Console.WriteLine($"*** Año: {year} ***");
    Console.WriteLine();
    List<string> months = ["Enero", "Febrero","Marzo","Abril","Mayo","Junio", "Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"];
    int i = 1;
    
    foreach(var month in months) {

        Console.WriteLine($"{month}");
        Console.WriteLine("Dom\t Lun\t Mar\t Mie\t Jue\t Vie\t Sab");
        
        var daysPerMonth = GetDasyPerMonth(year, i);

        var zeller = Zeller(year, i);

        var daysCounter = 0;

        for (int j=0; j<zeller; j++) {
            Console.Write("\t");
            daysCounter++;
        }

        for (int day=1; day<= daysPerMonth; day++) {
            Console.Write($"{day}\t");
            daysCounter++;
            if (daysCounter==7) {
                daysCounter = 0;
                Console.WriteLine();
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        i++;
    }
}

int GetDasyPerMonth(int year, int month)
{
    if (month==2 && DayUtilitis.IsLeapYear(year)) {

        return 29;
    }
    List<int> daysPermonth = [0,31,28,31,30,31,30,31,31,30,31,30,31];
    return daysPermonth.ElementAt(month);
}

// Devuelve
// 0 = Domingo, 1 = Lunes, 2 = Martes, 3 = Miercoles,
// 4 = Jueves, 5 = Viernes, 6 = Sábado
 int Zeller(int ano, int mes)
{
    int a = (14 - mes) / 12;
    int y = ano - a;
    int m = mes + 12 * a - 2;
    int dia = 1, d;
    d = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;
    return (d);
}
