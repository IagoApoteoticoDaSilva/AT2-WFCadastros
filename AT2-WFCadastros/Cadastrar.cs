using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        public void LimparFormulario()
        {
            mtbCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            dtpData.Value = DateTime.Today;
            cbxStatus.SelectedIndex = -1;
        }
        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Atencao(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Info(string mensagem)
        {
            MessageBox.Show(mensagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (CamposNaoPreenchidos() == true)
            {
                Erro("Os Campos Obrigatórios devem ser Preenchidos");
                return;
            }

            Produtos dog = new Produtos();
            dog.Codigo = int.Parse(mtbCodigo.Text);
            dog.Nome = txtNome.Text;
            dog.Descricao = txtDescricao.Text;
            dog.DataCadastro = dtpData.Value;
            switch (cbxStatus.SelectedItem?.ToString())
            {
                case "Ativo":
                    dog.Status = Status.Ativo;
                    break;
                case "Inativo":

                    dog.Status = Status.Inativo;
                    break;
            }

            dog.AddProduto();

            Info("Categoria catastrada com sucesso!");

            LimparFormulario();
            int qtdeItems = Produtos.ObterLista().Count;
            int novoCodigo = qtdeItems + 1;
            mtbCodigo.Text = novoCodigo.ToString("D4");
            dtpData.Value = DateTime.Today;
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            int qtdeItems = Produtos.ObterLista().Count;
            int novoCodigo = qtdeItems + 1;
            mtbCodigo.Text = novoCodigo.ToString("D4");
            dtpData.Value = DateTime.Today;
        }

        public bool CamposNaoPreenchidos()
        {
            if (string.IsNullOrEmpty(mtbCodigo.Text))
                return true;
            if (cbxStatus.SelectedIndex == -1)
                return true;
            if (string.IsNullOrEmpty(txtNome.Text))
                return true;
            if (dtpData.Value == DateTime.Today)
                return true;
            if (string.IsNullOrEmpty(txtDescricao.Text))
                return true;

            return false;
        }
    }
}
