using Aula_2_Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteClasseLerArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\Andrew\Documents\Visual Studio 2013\Projects\Aula_2_Linq\
            //Arquivo_Banco.txt
            //novoarquivo.txt
            Console.WriteLine("Digite o Caminho do Arquivo:");
            string caminho = @"C:\Users\Andrew\Documents\Visual Studio 2013\Projects\Aula_2_Linq\";
            Console.WriteLine("Digite o Nome do Arquivo:");
            string nome_arquivo = Console.ReadLine();
            Console.WriteLine("Digite o Status desejado:");
            Console.WriteLine("0 - Todos | 1 - Inativo | 2 - Ativo");
            int Status = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do novo Arquivo");
            string NovoArquivo = Console.ReadLine();

            Cliente cliente = new Cliente();

            var Status_1 = cliente.Gravar_Status(caminho, nome_arquivo, NovoArquivo, Status);

            if (Status_1)
            {
                Console.WriteLine("Arquivo Gravado com Sucesso");
            }
            else
            {

                Console.WriteLine("erro ao gravar");
            }
            Console.ReadKey();
        }
    }
}
