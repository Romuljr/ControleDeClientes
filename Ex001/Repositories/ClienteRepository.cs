using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ex001.Entities;

namespace Ex001.Repositories
{
    public class ClienteRepository
    {
        private string path = "c:\\temp\\clientes.txt";
        public void GravarDados(Cliente cliente)
        {
            using(var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine("ID: " + cliente.Id);
                streamWriter.WriteLine("NOME: " + cliente.Nome);
                streamWriter.WriteLine("EMAIL: " + cliente.Email);
                streamWriter.WriteLine("CPF: " + cliente.Cpf);
                streamWriter.WriteLine("=-=-=-=<>=-=-=-=");

            }
        }
        public string LerDados()
        {
            using (var streamReader = new StreamReader(path))
            {
                return streamReader.ReadToEnd();
            }
        }

        internal void LerDados(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
