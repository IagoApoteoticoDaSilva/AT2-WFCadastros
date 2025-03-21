using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            CarregarLista();
        }

        public void Sucesso(string mensagem = "")
        {
            MessageBox.Show(mensagem, "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Erro(string mensagem = "")
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CarregarLista()
        {
            Usuario.ListaUsuario.Add(
                new Usuario
                {
                    Codigo = 1001,
                    Login = "sistema",
                    Senha = "123456",

                }

            );

        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Login = txtLogin.Text;
            user.Senha = txtSenha.Text;
            user.DataCadastro = DateTime.Now;


            if (string.IsNullOrEmpty(user.Login) || string.IsNullOrEmpty(user.Senha))
            {
                Erro("Login ou senha não podem estar vazios.");
                return;
            }

            bool loginValido = false;

            foreach (var pessoa in Usuario.ListaUsuario)
            {
                if (pessoa == null)
                {
                    continue;
                }


                if (user.Login == pessoa.Login && user.Senha == pessoa.Senha)
                {
                    Sucesso("Login efetuado com sucesso!");
                    loginValido = true;
                    FormPrincipal form = new FormPrincipal();
                    form.ShowDialog();
                    return;
                }
            }


            if (!loginValido)
            {
                Erro("Erro ao efetuar login! Verifique suas credenciais.");
            }
        }
    }
}
