using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecuperacaoAPI.Models
{
    public class Receitas
    {
        public int ID_Receita { get; set; }
        public string? Usuario_Receita { get; set; }
        public string? Text_Receita { get; set; }
        public double Valor_ { get; set; }
    }
}