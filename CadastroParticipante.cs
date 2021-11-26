using System;
using System.Windows.Forms;
using UnusualEvents.Banco;
using UnusualEvents.Banco.Entidades;

namespace UnusualEvents
{
    public partial class CadastroParticipante : Form
    {
        private GerenciadorBanco _banco;
        private Evento _evento;
        public CadastroParticipante(Evento evento)
        {
            InitializeComponent();
            _evento = evento;
            _banco = new GerenciadorBanco();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                MessageBox.Show("Informe o seu nome.");
                return;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBoxCpf.Text))
            {
                MessageBox.Show("Informe o seu CPF.");
                return;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBoxRg.Text))
            {
                MessageBox.Show("Informe o seu RG.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxIdade.Text))
            {
                MessageBox.Show("Informe a sua idade.");
                return;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBoxWhatsApp.Text))
            {
                MessageBox.Show("Informe o seu WhatsApp.");
                return;
            }

            var participante = new Participante();
            participante.NomeCompleto = textBoxNome.Text;
            participante.Cpf = maskedTextBoxCpf.Text;
            participante.Rg = maskedTextBoxRg.Text;
            participante.Idade = byte.Parse(textBoxIdade.Text);
            participante.NumeroCelular = maskedTextBoxWhatsApp.Text;
            participante.CodigoEvento = _evento.Codigo;

            _banco.CadastrarParticipante(participante);

            MessageBox.Show("Participante cadastrado com sucesso!");
            Close();
        }
    }
}
