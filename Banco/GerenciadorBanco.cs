using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UnusualEvents.Banco.Entidades;

namespace UnusualEvents.Banco
{
    public class GerenciadorBanco
    {
        public List<Evento> ConsultarEventos(string nome, int codigoTipoEvento)
        {
            using BancoContext bancoContext = new BancoContext();
            var eventos = bancoContext.Eventos;
            var consulta = eventos.Where(e => e.Nome.Contains(nome));
            if (codigoTipoEvento > 0)
            {
                consulta = consulta.Where(e => e.CodigoTipoEvento == codigoTipoEvento);
            }

            consulta = consulta
                .Include(e => e.HorarioEvento)
                .Include(e => e.EnderecoLocal)
                .ThenInclude(e => e.Bairro)
                .ThenInclude(b => b.Cidade)
                .ThenInclude(c => c.Uf)
                .Include(e => e.TipoEvento)
                .Include(e => e.RequisitoEvento)
                .ThenInclude(r => r.Requisito);

            return consulta.ToList();
        }

        public List<Cidade> ConsultarCidades(int codigoUf)
        {
            using BancoContext bancoContext = new BancoContext();
            var cidades = bancoContext.Cidades.Where(c => c.CodigoUf == codigoUf).ToList();
            return cidades;
        }

        public List<Uf> ConsultarEstados()
        {
            using BancoContext bancoContext = new BancoContext();
            var estados = bancoContext.Ufs.ToList();
            return estados;
        }

        public List<TipoEvento> ConsultarCategorias()
        {
            using BancoContext bancoContext = new BancoContext();
            
            var tiposEventos = bancoContext.TiposEventos.ToList();
            return tiposEventos;
        }

        internal void CadastrarParticipante(Participante participante)
        {
            using BancoContext bancoContext = new BancoContext();
            bancoContext.Participantes.Add(participante);
            bancoContext.SaveChanges();
        }

        public Evento ConsultarDadosEvento(int codigoEvento)
        {
            using BancoContext bancoContext = new BancoContext();
            
            var evento = bancoContext.Eventos
                .Include(e => e.HorarioEvento)
                .Include(e => e.EnderecoLocal)
                .ThenInclude(e => e.Bairro)
                .ThenInclude(b => b.Cidade)
                .ThenInclude(c => c.Uf)
                .Include(e => e.TipoEvento)
                .Include(e => e.RequisitoEvento)
                .ThenInclude(r => r.Requisito)
                .FirstOrDefault(e => e.Codigo == codigoEvento);

            return evento;
        }

        public List<Empresa> ConsultarEmpresas()
        {
            using BancoContext bancoContext = new BancoContext();
            var empresas = bancoContext.Empresas.ToList();
            return empresas;
        }

        public void CadastrarEmpresa(Empresa empresa)
        {
            using BancoContext bancoContext = new BancoContext();

            bancoContext.Empresas.Add(empresa);
            bancoContext.SaveChanges();
        }

        public Bairro ConsultarBairro(string nomeBairro, int codigoCidade)
        {
            using BancoContext bancoContext = new BancoContext();
            var bairro = bancoContext.Bairros.FirstOrDefault(b => b.CodigoCidade == codigoCidade && b.Nome == nomeBairro);
            return bairro;
        }

        public void CadastrarEvento(Evento evento)
        {
            using BancoContext bancoContext = new BancoContext();
            bancoContext.Eventos.Add(evento);
            bancoContext.SaveChanges();
        }

        public int CadastarBairro(Bairro bairro)
        {
            using BancoContext bancoContext = new BancoContext();
            bancoContext.Bairros.Add(bairro);
            bancoContext.SaveChanges();

            return bairro.Codigo;
        }
    }
}
