using System;
using System.Data.Entity.Migrations;
using Itanio.SessaoAoVivo.Dominio;

namespace Itanio.SessaoAoVivo.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Contexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.ObterLista<Parametro>().AddOrUpdate(
                p => p.Chave,
                new Parametro
                {
                    Ativo = true,
                    DataCriacao = DateTime.Now,
                    Valor = "irc.BrasIRC.com.br",
                    Chave = Parametro.CHAVE_SERVIDOR_IRC
                },
                new Parametro
                {
                    Ativo = true,
                    DataCriacao = DateTime.Now,
                    Valor = "IT_Newest_58132_In",
                    Chave = Parametro.CHAVE_SENHA_SALAS
                },
                new Parametro {Ativo = true, DataCriacao = DateTime.Now, Valor = "FBG", Chave = Parametro.CHAVE_PROJETO}
            );
        }
    }
}