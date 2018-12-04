using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras
{
    class Itens
    {
        private int idLista;
        private string nome;
        private string categoria;
        private int quantidade;
        private int quantidadePrioridade;
        private string prioridade;
        private double preco;

        public int IdLista { get => idLista; set => idLista = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Quantidade { get => quantidade; set => quantidade = value;}
        public double Preco { get => preco; set => preco = value; }
        public int QuantidadePrioridade { get => quantidadePrioridade; set => quantidadePrioridade = value; }
        public string Prioridade { get => prioridade; set => prioridade = value; }

        
    }
}
