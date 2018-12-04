using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras
{
    
    class Lista
    {
        private int id;
        private string nome;
        private double disponivel;
        private double precoPrioridade;
        private double precoTotal;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Disponivel { get => disponivel; set => disponivel = value; }
        public double PrecoPrioridade { get => precoPrioridade; set => precoPrioridade = value; }
        public double PrecoTotal { get => precoTotal; set => precoTotal = value; }
    }
}
