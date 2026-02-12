namespace Aula08
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=================Operadores Relacionais================");
            Console.WriteLine("Digite o primeiro número(x): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número(y): ");
            int y = Convert.ToInt32(Console.ReadLine());

            string result;
            //Aula08 - Operadores Relacionais

            //Operador de Igualdade (==)
            if (x == y)
            {
                result = "x é igual a y";
            }
            else
            {
                result = "x não é igual a y";
            }

            Console.WriteLine("\nIgualdade (==): " + result);

            //Operador de Diferença (!=)
            if (x != y)
            {
                result = "x é diferente de y ";
            }
            else
            {
                result = "x é igual a y ";
            }
            Console.WriteLine("\nDiferença (!=): " + result);

            //Operador maior que (>)
            if (x > y)
            {
                result = "x é maior que y";
            }
            else
            {
                result = "x não é maior que y";
            }
            Console.WriteLine("\nMaior que (>): " + result);

            //Operador menor que (<)
            if (x < y)
            {
                result = "x é menor que y";
            }
            else
            {
                result = "x não é menor que y";
            }
            Console.WriteLine("\nMenor que(<): " + result);

            //Operador maior ou igual (>=)
            if (x >= y)
            {
                result = "x é maior ou igual a y";
            }
            else
            {
                result = "x não é maior ou igual a y";
            }
            Console.WriteLine("\nMaior ou igual (>=): " + result);

            //Operador menor ou igual (<=)
            if (x <= y)
            {
                result = "x é menor ou igual a y";
            }
            else
            {
                result = "x não é menor ou igual a y";
            }
            Console.WriteLine("\nMenor ou igual (<=): " + result);
        }
        
    }
}

