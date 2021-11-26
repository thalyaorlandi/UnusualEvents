using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UnusualEvents.Banco;
using UnusualEvents.Banco.Entidades;

namespace UnusualEvents
{
    public partial class UnusualEvents : Form
    {
        private readonly GerenciadorBanco _banco;

        public UnusualEvents()
        {
            InitializeComponent();
            
            _banco = new GerenciadorBanco();

            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            comboBoxCategoria.Items.Add(new TipoEvento { Codigo = 0, Descricao = "Todos"});
            comboBoxCategoria.SelectedIndex = 0;

            List<TipoEvento> tipoEventos =  _banco.ConsultarCategorias();
            foreach (var tipo in tipoEventos)
            {
                comboBoxCategoria.Items.Add(tipo);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var tipo = (TipoEvento)comboBoxCategoria.SelectedItem;

            var lista = _banco.ConsultarEventos(textBoxPesquisar.Text, tipo.Codigo);

            if (lista.Count == 0)
            {
                MessageBox.Show("Nenhum evento encontrado.");
                return;
            }

            foreach (var item in lista)
            {
                var cidade = item.EnderecoLocal.Bairro.Cidade.Nome;
                var uf = item.EnderecoLocal.Bairro.Cidade.Uf.Sigla;
                var data = item.HorarioEvento.DataHoraInicio.ToString(@"dd/MM/yyyy");

                var index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.Codigo;
                dataGridView1.Rows[index].Cells[1].Value = item.Nome;
                dataGridView1.Rows[index].Cells[2].Value = $"{cidade} - {uf}" ;
                dataGridView1.Rows[index].Cells[3].Value = data;
            }
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var codigo = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var evento = _banco.ConsultarDadosEvento(codigo);
            var detalhesEvento = new DetalhesEvento(evento);
            detalhesEvento.Show();
        }

        private void buttonCadastrarEmpresa_Click(object sender, EventArgs e)
        {
            var cadastroEmpresa = new CadastroEmpresa();
            cadastroEmpresa.Show();
        }

        private void buttonCadastrarEvento_Click(object sender, EventArgs e)
        {
            CadastroEvento cadastroEvento = new CadastroEvento();
            cadastroEvento.Show();
        }
    }
}
