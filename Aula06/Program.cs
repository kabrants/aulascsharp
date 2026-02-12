namespace Aula06
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("====================== Verificando Números Ímpares===============");
            Console.WriteLine("Digite seu número: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = number % 2;

            if (result == 0) //Identidade
            {
                Console.WriteLine("O número digitado é par!");
            }

            else
            {
                Console.WriteLine("O número é ímpar");
            }
            
        }
    }
}