using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecuperacaoAPI.Models
{
    public class Despesas
    {
        public int ID_Despesa { get; set; }
        public string? Usuario_Despesa { get; set; }
        public string? Text_Despesa { get; set; }
        public double Valor_Despesa { get; set; }
    }
}