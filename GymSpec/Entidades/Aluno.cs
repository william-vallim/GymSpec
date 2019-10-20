using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GymSpec.Entidades
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Identidade { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public string Endereco { get; set; }

        public Situacao Situacao { get; set; }
    }

    public enum Situacao
    {
        Adimplente, Inadimplente
    }
}