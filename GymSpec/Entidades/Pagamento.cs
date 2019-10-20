using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GymSpec.Entidades
{
    public class Pagamento
    {
        public int Id { get; set; }

        public decimal Valor { get; set; }

        public DateTime Vencimento { get; set; }

        public DateTime Data { get; set; }

        public Tipo Tipo { get; set; }

        public int AlunoId { get; set; }

        public virtual Aluno Aluno { get; set; }
    }

    public enum Tipo
    {
        Mensal, Anual
    }
}