using ProjetoAula01.Entities;
using ProjetoAula01.Repositore;

namespace ProjetoAula01
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" ***CONTROLE DE CLIENTE***");

            var cliente = new Cliente();
            cliente.Id = Guid.NewGuid();

            Console.Write("ENTRE COM O NOME DO CLIENTE...");
            cliente.Nome = Console.ReadLine();

            Console.Write("ENTRE COM O TELEFONE... ");
            cliente.Telefone = Console.ReadLine();

            Console.Write("ENTRE COM O EMAIL... ");
            cliente.Email = Console.ReadLine();

            Console.Write("ENTRE COM O CPF... ");
            cliente.Cpf = Console.ReadLine();

            Console.WriteLine("***DADOS DO CLIENTE: ");
            Console.WriteLine("ID.....:" + cliente.Id);
            Console.WriteLine("NOME .....:" + cliente.Nome);
            Console.WriteLine("TELEFONE.....:" + cliente.Telefone);
            Console.WriteLine("EMAIL.....:" + cliente.Email);
            Console.WriteLine("CPF.....:" + cliente.Cpf);

            try
            {
                var clienteRepository = new ClienteRepository();
                clienteRepository.ExportarDados(cliente);

                Console.WriteLine("\n DADOS GRAVADOS!");
                
            }
            catch
            {
                Console.WriteLine("\n ERRO  AO CADASTRAR!");
            }

            Console.ReadLine();
        }
    }
}