using System;
using System.Data.Entity;
using AuvoSelecao.Core.Business;
using AuvoSelecao.Core.Interfaces;

namespace AuvoSelecao.Data
{
    public class DataContext : DbContext, IUnitOfWork
    {
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<PrevisaoClima> Previsoes { get; set; }

        public DataContext(string connString)
        {
            this.Database.Connection.ConnectionString = connString;
        }


        public void Save()
        {
            base.SaveChanges();
        }
    }
}
