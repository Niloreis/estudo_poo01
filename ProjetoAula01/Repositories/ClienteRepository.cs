using ProjetoAula01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula01.Repositore
{
    public class ClienteRepository
    {
        public void ExportarDados( Cliente cliente)
        {
            using (var streamWriter= new StreamWriter($"c:\\clientes\\cliente_{cliente.Id}.txt"))
            {
                streamWriter.WriteLine($"ID DO CLIENTE...:{cliente.Id }");
                streamWriter.WriteLine($"NOME...:{cliente.Nome}");
                streamWriter.WriteLine($"TELEFONE...:{cliente.Telefone}"); 
                streamWriter.WriteLine($"EMAIL...:{cliente.Email}"); 
                streamWriter.WriteLine($"CPF...:{cliente.Cpf}");

            }
        }
    }
}
