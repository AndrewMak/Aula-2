using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
           
            var status = cliente.Gravar_Status(@"C:\Users\Andrew\Documents\Visual Studio 2013\Projects\Aula_2_Linq\", "Arquivo_Banco.txt", "novoarquivo.txt", 2);

            Console.ReadKey();
        }
    }
}
