using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula10
{
    public class Juridica : Pessoa
    {
        public Juridica() { }
        public string Cnpj { get; set; }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        internal object ToList()
        {
            throw new NotImplementedException();
        }
    }
}
