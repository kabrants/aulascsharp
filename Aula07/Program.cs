namespace Aula07
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=================Operadores de Atribuição================");

            //Inicializar a variável
            int x = 10;
            Console.WriteLine("\nValor inicial da variável de x: " + x);

            //Operador de Atribuição Simples (=)
            x = 20;
            Console.WriteLine("\nAtribuição Simples");
            Console.WriteLine("Valor de x: " + x);

            //Atribuição  (incremento) (++)
            x++; //Equivale a x = x + 1
            Console.WriteLine("\n Atribuição Composta Incremento (++)");
            Console.WriteLine("Novo Valor de X: " + x);


            //Atribuição  (composta) (+=)
            x += 10; //Equivale x = x +10

            Console.WriteLine("\n Atribuição Composta Incremento (+=)");
            Console.WriteLine("Novo Valor de X: " + x);


            //Atribuição  (composta) (-=)
            x -= 10; //Equivale x = x - 10

            Console.WriteLine("\n Atribuição Composta Incremento (-=)");
            Console.WriteLine("Novo Valor de X: " + x);


            //Atribuição  (composta) (*=)
            x *= 10; //Equivale x = x * 10

            Console.WriteLine("\n Atribuição Composta Incremento (*=)");
            Console.WriteLine("Novo Valor de X: " + x);


            //Atribuição  (composta) (/=)
            x /= 10; //Equivale x = x / 10

            Console.WriteLine("\n Atribuição Composta Incremento (/=)");
            Console.WriteLine("Novo Valor de X: " + x);


        }
    }
}