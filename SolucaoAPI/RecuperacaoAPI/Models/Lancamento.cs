using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecuperacaoAPI.Models
{
    public class Lancamento
    {
        public int ID_Categoria { get; set; }
        public string? Tipo_Categoria { get; set; }
        public string? Text_Lancamento { get; set; }
        public double Valor_Total { get; set; }
    }
}