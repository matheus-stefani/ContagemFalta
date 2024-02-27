using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemFalta
{
    internal class DisciplinaInformacao
    {
       
        public int IdVil { get; set; }
        public string NomeDisciplina { get; set; }
        public int QuantidadeFaltaTotal { get; set; }
        public int QuantidadeFaltaAtual { get; set; }

        public DisciplinaInformacao(int id,string nomeDisciplina, int quantidadeFaltaTotal,
            int quantidadeFaltaAtual)
        {
            IdVil = id;
            NomeDisciplina = nomeDisciplina;
            QuantidadeFaltaTotal = quantidadeFaltaTotal;
            QuantidadeFaltaAtual = quantidadeFaltaAtual;
        }
    }
}
