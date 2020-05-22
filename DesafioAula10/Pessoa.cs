using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula10
{
    public abstract class Pessoa : IPessoa
    {
        public Pessoa()
        {
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public abstract void Excluir();

        public List<IPessoa> Buscar()
        {
            return null;
        }

        public void Salvar()
        {
            Servico.Salvar(this);
        }
    }
}
