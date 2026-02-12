namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("---------------CADASTRO DE USUÁRIO--------------");

        //Solicitar o nome do usuário
        Console.WriteLine("Digite seu nome: ");
        string name = Console.ReadLine();

        //Solicitar a idade do usuário
        Console.WriteLine("Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Sua idade é: " + age);
        Console.WriteLine("Nome do Usuário: " + name);

    }

}