using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aula_2_Linq
{
    //estrutura do arquivo : codigo_cliente - nome - cpf/CNPJ - numero_cc - status_cc ;
    public class Cliente
    {
        public int Codigo_Cliente { get; set; }

        public string Nome { get; set; }

        public string CPF_CNPJ { get; set; }

        public int Numero_CC { get; set; }

        public int Status_CC { get; set; }

        public bool Gravar_Status(string path, string nome_arq, string novoarq, int status)
        {
            List<Cliente> lista = new List<Cliente>();

            //caminho do diretorio
            String diretorio = @"" + path + "";
            //nome do arquivo
            String arq = "" + nome_arq + "";

            String novoArquivo = "" + novoarq + "";
            try
            {
                using (StreamReader sr = File.OpenText(diretorio + arq))
                {
                    string s = "";
                    while (!string.IsNullOrEmpty(s = sr.ReadLine()))
                    {
                        Cliente cliente = new Cliente();

                        cliente.Codigo_Cliente = Convert.ToInt32(s.Split('-')[0].Trim());
                        cliente.Nome = s.Split('-')[1].Trim(); ;
                        cliente.CPF_CNPJ = s.Split('-')[2].Trim();
                        cliente.Numero_CC = Convert.ToInt32(s.Split('-')[3].Trim());
                        cliente.Status_CC = Convert.ToInt32(s.Split('-')[4].Trim());
                        if (status == 0)
                        {
                            lista.Add(cliente);
                        }
                        else 
                        {
                            if (cliente.Status_CC == status)
                                lista.Add(cliente);
                        }

                    }
                    try
                    {
                        using (FileStream fs = File.Open(diretorio + novoArquivo, FileMode.Append))
                        {
                            foreach (var linha in lista)
                            {
                                Byte[] texto = new UTF8Encoding(true).GetBytes(linha.Codigo_Cliente + "-" + linha.Nome + "-" + linha.CPF_CNPJ + "-" + linha.Numero_CC + "-" + linha.Status_CC);
                                fs.Write(texto, 0, texto.Length);
                            }
                        };
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine(Ex.ToString());
                    }
                }
                return true;
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                return false;
            }


        }

    }
}
