using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UnusualEvents.Banco;
using UnusualEvents.Banco.Entidades;

namespace UnusualEvents
{
    public partial class CadastroEvento : Form
    {
        private readonly GerenciadorBanco _banco;
        public CadastroEvento()
        {
            InitializeComponent();
            _banco = new GerenciadorBanco();
            CarregarComboBoxTipoEvento();
            CarregarComboBoxEmpresa();
            CarregarEstados();
            CarregarCidades();
        }

        private void CarregarCidades()
        {
            var uf = (Uf)comboBoxUf.SelectedItem;
            List<Cidade> cidades = _banco.ConsultarCidades(uf.Codigo);
            cidades = cidades.OrderBy(c => c.Nome).ToList();
            comboBoxCidade.Items.Clear();
            foreach (var cidade in cidades)
            {
                comboBoxCidade.Items.Add(cidade);
            }
            comboBoxCidade.SelectedIndex = 0;
        }

        private void CarregarEstados()
        {
            List<Uf> ufs = _banco.ConsultarEstados();
            ufs = ufs.OrderBy(u => u.Sigla).ToList();
            foreach (var uf in ufs)
            {
                comboBoxUf.Items.Add(uf);
            }
            comboBoxUf.SelectedIndex = 0;
        }

        private void CarregarComboBoxEmpresa()
        {
            List<Empresa> empresas = _banco.ConsultarEmpresas();
            foreach (var empresa in empresas)
            {
                comboBoxEmpresa.Items.Add(empresa);
            }
            comboBoxEmpresa.SelectedIndex = 0;
        }

        private void CarregarComboBoxTipoEvento()
        {
            List<TipoEvento> tipoEventos = _banco.ConsultarCategorias();
            foreach (var tipo in tipoEventos)
            {
                comboBoxTipoEvento.Items.Add(tipo);
            }
            comboBoxTipoEvento.SelectedIndex = 0;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var evento = new Evento();

            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                MessageBox.Show("Informe o nome do evento.");
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBoxDescricao.Text))
            {
                MessageBox.Show("Informe a descricao do evento.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxBairro.Text))
            {
                MessageBox.Show("Informe o Bairro do evento.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxRua.Text))
            {
                MessageBox.Show("Informe a Rua do evento.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxNumero.Text))
            {
                MessageBox.Show("Informe o número do endreço do evento.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPreco.Text))
            {
                MessageBox.Show("Informe o preço do evento.");
                return;
            }

            var empresa = (Empresa)comboBoxEmpresa.SelectedItem;
            var tipoEvento = (TipoEvento)comboBoxTipoEvento.SelectedItem;
            int codigoBairro = CadastrarBairro();

            var endereco = new EnderecoLocal();
            endereco.Rua = textBoxRua.Text;
            endereco.Numero = textBoxNumero.Text;
            endereco.CodigoBairro = codigoBairro;

            var horario = new HorarioEvento();
            horario.DataHoraInicio = new DateTime(dateTimeDataInicio.Value.Year, dateTimeDataInicio.Value.Month,
                                                    dateTimeDataInicio.Value.Day, timeHoraInicio.Value.Hour,
                                                    timeHoraInicio.Value.Minute, timeHoraInicio.Value.Second);
            horario.DataHoraTermino = new DateTime(dateTimeDataFim.Value.Year, dateTimeDataFim.Value.Month,
                                                    dateTimeDataFim.Value.Day, timeHoraFim.Value.Hour,
                                                    timeHoraFim.Value.Minute, timeHoraFim.Value.Second);

            List<RequisitoEvento> requisitoEventos = ObterRequisitosEvento();

            evento.Descricao = richTextBoxDescricao.Text;
            evento.Nome = textBoxNome.Text;
            evento.CodigoEmpresa = empresa.Codigo;
            evento.CodigoTipoEvento = tipoEvento.Codigo;
            evento.Preco = decimal.Parse(textBoxPreco.Text);
            evento.HorarioEvento = horario;
            evento.EnderecoLocal = endereco;
            evento.RequisitoEvento = requisitoEventos;

            _banco.CadastrarEvento(evento);

            MessageBox.Show("Evento cadastrado com sucesso.");
            Close();
        }

        private List<RequisitoEvento> ObterRequisitosEvento()
        {
            List<RequisitoEvento> requisitos = new List<RequisitoEvento>();
            if (checkBoxPcr.Checked)
            {
                requisitos.Add(new RequisitoEvento { CodigoRequisito = 1 });
            }
            if (checkBoxVacinacao.Checked)
            {
                requisitos.Add(new RequisitoEvento { CodigoRequisito = 2 });
            }
            if (checkBoxMascara.Checked)
            {
                requisitos.Add(new RequisitoEvento { CodigoRequisito = 5 });
            }
            if (checkBoxIdade.Checked)
            {
                requisitos.Add(new RequisitoEvento { CodigoRequisito = 3 });
            }

            return requisitos;
        }

        private int CadastrarBairro()
        {
            Cidade cidade = (Cidade)comboBoxCidade.SelectedItem;
            Bairro bairro = _banco.ConsultarBairro(textBoxBairro.Text, cidade.Codigo);
            if (bairro != null)
            {
                return bairro.Codigo;
            }

            bairro = new Bairro();
            bairro.CodigoCidade = cidade.Codigo;
            bairro.Nome = textBoxBairro.Text;
            var codigoBairro = _banco.CadastarBairro(bairro);
            return codigoBairro;
        }

        private void ComboBoxUf_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarCidades();
        }
    }
}
