using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastros
{

    public enum Status
    {
        Ativo = 0,
        Inativo = 1,
    }
    class Produtos
    {
        public static List<Produtos> ListaProdutos = new List<Produtos>();

        public int? Codigo { get; set; }
        public string? Nome { get; set; }
        public Status Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public string? Descricao { get; set; }

        public List<Produtos>? ListaProduto { get; set; }

        public void AddProduto()
        {
            ListaProdutos.Add(this);
        }

        public static List<Produtos> ObterLista()
        {
            return ListaProdutos;
        }
    }
}