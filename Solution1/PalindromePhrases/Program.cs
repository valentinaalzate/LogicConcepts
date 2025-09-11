using Shared;
using System.ComponentModel.Design;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("*** FRASES PALINDROMAS***");
    var phrase = ConsoleExtension.GetString("Ingrese la palabra o frase: ");


    //do process
    var isPalindrome = IsPalindrome(phrase);



    //results
    Console.WriteLine($"La palabra o frase '{phrase}' {(isPalindrome ? "Si":"No")} es palindrome");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]0?: ", options);
        Console.WriteLine();
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

bool IsPalindrome(string? phrase)
{
    phrase = PreparePhrase(phrase);
    

    var n = phrase!.Length;
    for (int i=0; i<n/2;i++) {

        if (phrase[i] != phrase[n-i-1]) {

            return false;
        }
    }
    return true;
}

string PreparePhrase(string phrase)
{
    phrase = phrase.ToLower();
    string newPhrase = string.Empty;
    var exceptions = new List<char> { ' ', ',', '.', ',', ';', '¿', '?', '!', '¡', ':', '-', '_', '"' };

    foreach (char c in phrase)
    {
        if (!exceptions.Contains(c)) // contains contiene
        {
            newPhrase += c;
        }
    }

    newPhrase = newPhrase.Replace('á', 'a'); // Replace reemplaza
    newPhrase = newPhrase.Replace('é', 'e');
    newPhrase = newPhrase.Replace('í', 'i');
    newPhrase = newPhrase.Replace('ó', 'o');
    newPhrase = newPhrase.Replace('ú', 'u');

    return newPhrase;

}