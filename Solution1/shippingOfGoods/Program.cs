using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var weight = ConsoleExtension.GetDecimal("Peso de la mercancia.....:");
    var value = ConsoleExtension.GetDecimal("Valor de la mercancia......:");
    string isMonday;

    do
    {
       isMonday = ConsoleExtension.GetValidOptions("Es lunes [S]í, [N]0........: ", options)!;
    } while (!options.Any(x => x.Equals(isMonday, StringComparison.CurrentCultureIgnoreCase)));

    var payMethods = new List<string> { "e", "t" };
    string payMethod;
    do
    {
        payMethod = ConsoleExtension.GetValidOptions("Tipo de pago [E]fectivo [T]arjeta:........: ", payMethods)!;
    } while (!payMethods.Any(x => x.Equals(payMethod, StringComparison.CurrentCultureIgnoreCase)));

    var fare = CalculateFare(weight);
    var discount = CalbulateDiscount(fare, value);
    decimal promotion = 0;
    if (discount==0) {

        promotion = CalculatePromotion(fare, isMonday, payMethod, value);
    }

    Console.WriteLine($"Tarifa..............: {fare,20:c2}");
    Console.WriteLine($"Descuento...........: {discount,20:c2}");
    Console.WriteLine($"Promocion...........: {promotion,20:c2}");
    Console.WriteLine($"Total a pagar.......: {fare-discount-promotion,20:c2}");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal CalculatePromotion(decimal fare, string isMonday, string payMethod, decimal value)
{
    if (isMonday.ToLower()=="s" && payMethod.ToLower()=="t") {
        return fare * 0.5m;
    }
    if (payMethod.ToLower() == "e" && value>1000000m)
    {
        return fare * 0.4m;// 60% de descuento
    }
    return 0;
}

decimal CalbulateDiscount(decimal fare, decimal value)
{
    if (value>=300000m && value <=600000m) {
        return fare * 0.1m;
    
    }
    if (value >= 600000m && value <= 1000000m)
    {
        return fare * 0.2m;

    }
    if (value >= 1000000m) {

        return fare * 0.3m;
    }
    return 0;
}

decimal CalculateFare(decimal weight)
{

    if (weight<=100) {
        return 20000m;
    }
    if (weight <= 150)
    {
        return 25000m;
    }
    if (weight <= 200)
    {
        return 30000m;
    }
    int aditional = ((int)weight - 200)/10;
    return 35000m + aditional * 2000m;
}