// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace solar.Data.Tables
{
    public partial class localidade
    {
        public localidade()
        {
            habitacao = new HashSet<habitacao>();
            meteorologia = new HashSet<meteorologia>();
        }

        public int idLocalidade { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string Nome { get; set; }
        public string Distrito { get; set; }
        public string Concelho { get; set; }

        public virtual ICollection<habitacao> habitacao { get; set; }
        public virtual ICollection<meteorologia> meteorologia { get; set; }
    }
}