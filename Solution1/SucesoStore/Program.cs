using Shared;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("***DATOS DE ENTRADA * **");
    var cc= ConsoleExtension.GetDecimal("Costo de compra ($)....................................................:");

    var tpOptions = new List<string> { "p", "n" };
    var tp = string.Empty;
    do {
        tp = ConsoleExtension.GetValidOptions("Tipo de producto [P]erecedero, [N]o perecedero.........................:", tpOptions);
    } while (!tpOptions.Any(x => x.Equals(tp, StringComparison.CurrentCultureIgnoreCase)));

    var tcOptions = new List<string> { "f", "a" };
    var tc = string.Empty;

    do {
        tc = ConsoleExtension.GetValidOptions("Tipo de conservación [F]rio, [A]mbiente................................:", tcOptions);
    } while (!tcOptions.Any(x => x.Equals(tc, StringComparison.CurrentCultureIgnoreCase)));

    var pc = ConsoleExtension.GetInter("Periodo de conservación (días).........................................:");
    var pa = ConsoleExtension.GetInter("Periodo de almacenamiento (días).......................................:");
    var vol = ConsoleExtension.GetInter("Volumen (litros).......................................................:");

    var maOptions = new List<string> { "n", "c", "e", "g" };
    var ma = string.Empty;

    do {
        ma = ConsoleExtension.GetValidOptions("Medio de almacenamiento [N]evera, [C]ongelador, [E]estanteria, [G]uacal:", maOptions);
    } while (!maOptions.Any(x => x.Equals(ma, StringComparison.CurrentCultureIgnoreCase)));
     

    Console.WriteLine("*** CALCULOS ***");
    var ca = GetCostoAlmacenamiento(tp,cc, tc, pc, vol);
    var pdp = GetPorcentajeDeprecicionDelProducto(pa);
    var ce = GetCostoExhibicion(tp, tc, ma,ca);
    var vr_p = GetValorProducto(cc,ca,ce,pdp);
    var vr_v = GetValorventa(vr_p,tp);

    // show results
    Console.WriteLine($"Costos de almacenamiento..............................................: {ca,20:c2}");
    Console.WriteLine($"Porcentaja de depreciación............................................: {pdp,20:p2}");
    Console.WriteLine($"Costo de exhibición...................................................: {ce,20:c2}");
    Console.WriteLine($"Valor producto........................................................: {vr_p,20:c2}");
    Console.WriteLine($"Valor venta...........................................................: {vr_v,20:c2}");


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal GetValorventa(decimal vr_p, string? tp)
{
    if (tp.Equals("p", StringComparison.CurrentCultureIgnoreCase)) {
        
        return vr_p * 1.4m; // 40%
    
    }
    return vr_p * 1.2m; // 20%
}

decimal GetValorProducto(decimal cc, decimal ca, decimal ce, float pdp)
{
    return (cc + ca + ce) * (decimal)pdp; 
}

decimal GetCostoExhibicion(string? tp, string? tc, string? ma, decimal ca)
{
    if (tp.Equals("p", StringComparison.CurrentCultureIgnoreCase)) {

        if (tc.Equals("f", StringComparison.CurrentCultureIgnoreCase)) {

            if (ma.Equals("n", StringComparison.CurrentCultureIgnoreCase))
            {

                return ca * 2;

            }

            return ca;
        }
    }

    if (ma.Equals("e", StringComparison.CurrentCultureIgnoreCase))
    {

        return ca * 0.05m;

    }
    return ca * 0.07m;
}



float GetPorcentajeDeprecicionDelProducto(int pa)
{
    if (pa <30) {
        return 0.95f;
    }
    return 0.85f;
}

decimal GetCostoAlmacenamiento(string? tp, decimal cc, string? tc, int pc, int vol)
{
    if (tp.Equals("p", StringComparison.CurrentCultureIgnoreCase)) {

        if (tc.Equals("f", StringComparison.CurrentCultureIgnoreCase) ) {
            if (pc < 10) {
                return cc * 0.05m;
            }
            return cc * 0.1m;
        
        }

        if (pc < 20) {

            return cc * 0.03m;
        }
        if (pc > 20)
        {

            return cc * 0.1m;
        }
        return cc * 0.05m;
    }

    if (vol>=50) {

        return cc * 0.1m;
    }

    
    return cc *0.2m;
}