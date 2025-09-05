namespace Shared
{
        public class ConsoleExtension
        {
            public static int GetInt(string message)
            {
                Console.Write(message);
                var input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    return result;

                }
            throw new Exception("El valor ingresado no es un numero entero valido"); //sino lance una excepsion
                

            }

        public static string? GetValidOptions(string message, List<string> options)
        {
            Console.Write(message);
            var answer = Console.ReadLine();
            if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase))) {

                return answer;
            }
            return null;
        }
        }
        
       
}
