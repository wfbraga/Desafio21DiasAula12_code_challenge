using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula10
{
    class Fisica : Pessoa
    {
        public Fisica() { }

        public string Cpf { get; set; }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public List<Fisica> ToList()
        {
            throw new NotImplementedException();
        }

    }
}
