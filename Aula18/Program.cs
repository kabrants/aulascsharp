namespace Aula18;

using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        //1. Criar um arquivo
        //string content = "Hello World!";
        //System.IO.File.WriteAllText("file2.txt", "Hello World!");

        //Console.WriteLine("Arquivo criado com sucesso!");

        //2. Criar um arquivo em local específico
        //string path = @"C:\\Users\\Usuario\\Pictures\\Aulas\\C#\\Aula18\\bin\\Debug\\net10.0\\fileName.txt";

        //string content = "Hello World! testando o texto que contém dentro do arquivo";

        //File.WriteAllText(path, content);

        //Console.WriteLine("Arquivo criado com sucesso!");

        //3. Criar um arquivo Word
        //string path = @"C:\Users\Usuario\Pictures\Aulas\C#\Aula18\";
        //string fileName = "myDocument.Doc";
        //string filhePath = path + fileName;


        //string content = "Hello World! testando o texto que contém dentro do arquivo";

        //File.WriteAllText(filhePath, content);

        //Console.WriteLine("Arquivo Word criado com sucesso!");

        //4. Inserir um parágrafo em um arquivo.
        //string path = @"C:\Users\Usuario\Pictures\Aulas\C#\Aula18\";
        //string fileName = "myDocument.Doc";
        //string filePath = path + fileName;


        //string additionalContent = "Curso de C# e .NET";

        //File.AppendAllText(filePath, additionalContent);

        //Console.WriteLine("Arquivo Word criado com sucesso!");

        //5.Ler o arquivo
        string path = @"C:\Users\Usuario\Pictures\Aulas\C#\Aula18\";
        string fileName = "myDocument.Doc";
        string filePath = path + fileName;


       
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine("Conteúdo do arquivo: " + fileContent);

        //Files: criar, ler e alterar.
    }
}