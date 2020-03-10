﻿using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class PacoteRepository : IPacoteRepository
    {
        SenaturContext ctx = new SenaturContext();

        public void Atualizar(Pacotes pacoteAtualizado)
        {
            ctx.Pacotes.Update(pacoteAtualizado);

            ctx.SaveChanges();
        }

        public Pacotes BuscarPorId(int id)
        {
            return ctx.Pacotes.FirstOrDefault(p => p.IdCidade == id);
        }

        public void Cadastrar(Pacotes novoPacote)
        {
            ctx.Pacotes.Add(novoPacote);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Pacotes p = ctx.Pacotes.Find(id);

            ctx.Pacotes.Remove(p);

            ctx.SaveChanges();
        }

        public List<Pacotes> Listar()
        {
            return ctx.Pacotes.ToList();
        }
    }
}
