using GymSpec.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymSpec.DAO
{
    public class PagamentoDAO
    {
        private GymSpecContext context;
        public PagamentoDAO(GymSpecContext context)
        {
            this.context = context;
        }
        public void Adiciona(Pagamento pagamento)
        {
            context.Pagamentoes.Add(pagamento);
            context.SaveChanges();
        }
        public IList<Pagamento> Lista()
        {
            return context.Pagamentoes.ToList();
        }
    }
}