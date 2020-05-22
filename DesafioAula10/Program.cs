using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula10
{
    class Program
    {
        static void Main(string[] args)
        {
            new Fisica() { Nome="Wagner Braga", Endereco="Mora no Mundo", Id=1, Cpf = "2332" }.Salvar();
            new Juridica() { Nome = "Braga Enterprise", Endereco = "Mora no Mundo", Id = 1, Cnpj = "2536" }.Salvar();

            var fisicas = Servico.Procurar<Fisica>().ToList();

            var juridicas = Servico.Procurar<Juridica>().ToList();

            var listaFisica = Servico.Buscar(new Fisica());

            var listaJuridica = Servico.Buscar(new Juridica());

            foreach (IPessoa iPessoa in listaFisica)
            {
                Console.WriteLine(((Fisica)iPessoa).Cpf);
            }
            
            foreach (Juridica juridica in listaJuridica)
            {
                Console.WriteLine(juridica.Cnpj);
            }
            
            Console.ReadLine();
        }
    }
}
