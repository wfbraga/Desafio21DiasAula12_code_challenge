using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula10
{
    public interface IPessoa
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Endereco { get; set; }

        void Salvar();
        List<IPessoa> Buscar();
        void Excluir();
    }
}
