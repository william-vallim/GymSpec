using GymSpec.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymSpec.DAO
{
    public class AlunoDAO
    {
        private GymSpecContext context;
        // código do construtor da classe

        public AlunoDAO(GymSpecContext context)
        {
            this.context = context;
        }

        public void Adiciona(Aluno aluno)
        {
            context.Alunoes.Add(aluno);
            context.SaveChanges();
        }
        public IList<Aluno> Lista()
        {
            return context.Alunoes.ToList();
        }
    }
}