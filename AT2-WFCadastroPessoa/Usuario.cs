using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    class Usuario
    {
        public Usuario(int codigo, string login, string senha, DateTime dataCadastro, List<Usuario> listaUsuarios)
        {
            Codigo = codigo;
            Login = login;
            Senha = senha;
            DataCadastro = dataCadastro;
            ListaUsuarios = listaUsuarios;
        }

        public static List<Usuario> ListaUsuario = new List<Usuario>();

        public int? Codigo { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public DateTime? DataCadastro { get; set; }
        public List<Usuario>? ListaUsuarios { get; set; }

        public Usuario()
        {

        }

    }
}
