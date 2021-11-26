using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UnusualEvents.Banco.Entidades;

namespace UnusualEvents
{
    public partial class DetalhesEvento : Form
    {
        public Evento Evento { get; set; }

        public DetalhesEvento(Evento evento)
        {
            InitializeComponent();
            
            Evento = evento;    

            AtribuirDadosEvento(evento);
        }

        private void AtribuirDadosEvento(Evento evento)
        {
            labelNomeEvento.Text = evento.Nome;
            labelCategoria.Text += evento.TipoEvento.Descricao;
            AtribuirEndereco(evento.EnderecoLocal);
            labelDataHora.Text += evento.HorarioEvento.DataHoraInicio.ToString(@"dd/MM/yyyy HH:mm");
            labelPreco.Text += $"R${evento.Preco.ToString("0.00")}";
            AtribuirRequisitos(evento.RequisitoEvento);
            richTextBoxDescricao.Text = evento.Descricao;
        }

        private void AtribuirRequisitos(List<RequisitoEvento> requisitosEvento)
        {
            var requisitos = requisitosEvento.Select(r => r.Requisito).ToList();

            string textoRequisitos = "";
            foreach (var item in requisitos)
            {
                textoRequisitos += $"{item.Descricao}, ";
            }
            textoRequisitos = textoRequisitos.Remove(textoRequisitos.Length - 2);

            labelRequisitos.Text += textoRequisitos;
        }

        private void AtribuirEndereco(EnderecoLocal endereco)
        {
            var rua = endereco.Rua;
            var numero = endereco.Numero;
            var bairro = endereco.Bairro.Nome;
            var cidade = endereco.Bairro.Cidade.Nome;
            var uf = endereco.Bairro.Cidade.Uf.Sigla;
            labelEndereco.Text += $"{rua}, {numero}, {bairro}, {cidade} - {uf}";
        }

        private void buttonIncrever_Click(object sender, System.EventArgs e)
        {
            var cadastroParticipante = new CadastroParticipante(Evento);
            cadastroParticipante.Show();
        }
    }
}
