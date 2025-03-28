﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN01_WFCadastroContato
{
    public enum ETipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado
    }

    public class Cadastro
    {
        public Cadastro (int codigo, string? nome,
            string? sobrenome, string? ddd,
            string? telefone,
            ETipoTelefone tipoTelefone, string? email)
        {
            Codigo = codigo;
            Nome = nome;
            Sobrenome = sobrenome;
            Ddd = ddd;
            Telefone = telefone;
            TipoTelefone = tipoTelefone;
            Email = email;
        }

        public Cadastro() { }

        public static List<Cadastro> ListaCadastro =
            new List<Cadastro>();

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string? Ddd { get; set; }
        public string? Telefone { get; set; }
        public ETipoTelefone TipoTelefone { get; set; }
        public string? Email { get; set; }

    }
}
