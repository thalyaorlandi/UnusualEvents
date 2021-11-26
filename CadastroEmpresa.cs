using System;
using System.Windows.Forms;
using UnusualEvents.Banco;
using UnusualEvents.Banco.Entidades;

namespace UnusualEvents
{
    public partial class CadastroEmpresa : Form
    {
        private GerenciadorBanco _banco;
        public CadastroEmpresa()
        {
            _banco = new GerenciadorBanco();
            InitializeComponent();
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                MessageBox.Show("Informe um nome.");
                return;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBoxCnpj.Text))
            {
                MessageBox.Show("Informe um CNPJ.");
                return;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBoxTelefone.Text))
            {
                MessageBox.Show("Informe um Telefone.");
                return;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBoxWhatsapp.Text))
            {
                MessageBox.Show("Informe um WhatsApp.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Informe um Email.");
                return;
            }

            var empresa = new Empresa();
            empresa.Nome = textBoxNome.Text;
            empresa.Cnpj = maskedTextBoxCnpj.Text;
            empresa.Telefone = maskedTextBoxTelefone.Text;
            empresa.Whatsapp = maskedTextBoxWhatsapp.Text;
            empresa.Email = textBoxEmail.Text;

            _banco.CadastrarEmpresa(empresa);
            MessageBox.Show("Empresa cadastrada com sucesso");
            Close();
        }
    }
}
