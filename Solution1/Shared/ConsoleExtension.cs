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

        public static string? GetString(string message) {
            Console.Write(message);
            var text = Console.ReadLine();
            return text;
        }
        public static int GetInter(string message)
        {
            Console.Write(message);
            var numberString = Console.ReadLine();

            if (int.TryParse(numberString, out int numberInt))
            {
                return numberInt;
            }
            return 0;
        }

        public static float GetFloat(string message)
        {
            Console.Write(message);
            var numberString = Console.ReadLine();
            
            if (float.TryParse(numberString, out float numberFloat)) {
                return numberFloat;
            }
            return 0;
        }
        public static decimal GetDecimal(string message)
        {
            Console.Write(message);
            var numberString = Console.ReadLine();

            if (decimal.TryParse(numberString, out decimal numberDecimal))
            {
                return numberDecimal;
            }
            return 0;
        }

    }
        

       
}
