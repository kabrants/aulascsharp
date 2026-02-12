namespace Aula09
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("==========Operadores Lógicos=========");

            bool isLogged = true;
            bool hasAdminAcces = false;

            Console.WriteLine("\nInformações do Usuário");
            Console.WriteLine("Usuário Logado: " + isLogged);
            Console.WriteLine("Acesso ao painel de administrador: " + hasAdminAcces);

            Console.WriteLine("\nPermissões");

            //Operador (||) = ou
            if (isLogged || hasAdminAcces)
            {
                Console.WriteLine("Acesso ao sistema concedido");
            }
            else
            {
                Console.WriteLine("Acesso ao sistema NEGADO!");
            }


            //Operador (&&) = E
            if (isLogged && hasAdminAcces)
            {
                Console.WriteLine("Acesso ao painel de Administrador concedido!");
            }
            else
            {
                Console.WriteLine("Acesso ao painel de Administrador NEGADO!");
            }


            //Operador de negação (!) = "Não..."
            if (!isLogged)
            {
                Console.WriteLine("Usuário não está logado.");
            }
            else
            {
                Console.WriteLine("Usuário está logado!");
            }

           
        }
    }
}