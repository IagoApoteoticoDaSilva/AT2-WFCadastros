using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastroContato
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimparFormulario()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mtbDddTelefone.Clear();
            rdbComercial.Checked = false;
            rdbPessoal.Checked = false;
            rdbRecado.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string semMaskTelefone = mtbDddTelefone.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "");


            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Erro("Campo Nome não pode estar Vazio!");
                return;
            }

            else if (string.IsNullOrEmpty(semMaskTelefone))
            {
                Erro("Campo Telefone não pode estar Vazio!");
                return;
            }

            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Erro("Campo Email não pode estar Vazio!");
                return;
            }

            ETipoTelefone tipoTelefone;

            if (!rdbComercial.Checked && !rdbPessoal.Checked && !rdbRecado.Checked)
            {
                Erro("Deve-se marcar uma opção de Tipo de Telefone!");
                return;
            }
            else
            {
                if (rdbComercial.Checked)
                    tipoTelefone = ETipoTelefone.Comercial;
                else if (rdbPessoal.Checked)
                    tipoTelefone = ETipoTelefone.Pessoal;
                else
                    tipoTelefone = ETipoTelefone.Recado;
            }

            Cadastro c1 = new Cadastro();
            c1.Codigo = 0;
            c1.Nome = txtNome.Text;
            c1.Email = txtEmail.Text;
            c1.TipoTelefone = tipoTelefone;



            c1.Ddd = mtbDddTelefone.Text.Substring(0, 2);
            c1.Telefone = mtbDddTelefone.Text.Substring(2);
            c1.Ddd = semMaskTelefone.Substring(0, 2);
            c1.Telefone = semMaskTelefone.Substring(2);

            Cadastro.ListaCadastro.Add(c1);
            
            Sucesso("Cadastrado com Sucesso!");

            LimparFormulario();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
