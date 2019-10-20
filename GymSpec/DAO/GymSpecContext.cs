using GymSpec.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GymSpec.DAO
{
    public class GymSpecContext : DbContext
    {
        public DbSet<Aluno> Alunoes { get; set; }
        public DbSet<Pagamento> Pagamentoes { get; set; }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<Pagamento>().HasRequired(m => m.Aluno);
        }
    }
}