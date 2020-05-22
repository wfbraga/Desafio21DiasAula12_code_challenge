using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula10
{
    class Servico
    {
        public static List<IPessoa> TabelaFisica = new List<IPessoa>();

        public static List<IPessoa> TabelaJuridica = new List<IPessoa>();

        public Servico()
        {
        }
        public static void Salvar(IPessoa iPessoa)
        {
            if (iPessoa.GetType().Name == "Fisica")
            // Tambem poderia ser feito com => if (iPessoa.GetType() == typeof(Fisica))
            {
                Servico.TabelaFisica.Add((Fisica)iPessoa);
            }
            else if (iPessoa.GetType().Name == "Juridica")
            {
                Servico.TabelaJuridica.Add((Juridica)iPessoa);
            }
        }
        public static List<IPessoa> Buscar(IPessoa iPessoa)
        {
            if(iPessoa.GetType() == typeof(Fisica))
            {
                return Servico.TabelaFisica;
            }
            else if (iPessoa.GetType() == typeof(Juridica))
            {
                return Servico.TabelaJuridica;
            }
            return null;
        }
        public static T Procurar<T>()
        {
            //List<IPessoa> lista = new List<IPessoa>();
            var lista = Servico.TabelaFisica;
            return (T)Convert.ChangeType(lista, typeof(T));
            /*
            if (iPessoa.GetType() == typeof(Fisica))
            {
                return Servico.TabelaFisica;
            }
            else if (iPessoa.GetType() == typeof(Juridica))
            {
                return Servico.TabelaJuridica;
            }
            return null;
            */
        }


    }
}
