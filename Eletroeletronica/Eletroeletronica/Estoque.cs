using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletroeletronica
{
    internal class Estoque
    {
        private int quantidade;
        private string nome;
        private string descricao;

        public int Quantidade
        {
            get { return Quantidade; }
            set { Quantidade = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Descricao
        {
            get { return Descricao; }
            set { Descricao = value; }
        }

    }
}
