using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IBM.Models
{
    public class Contrato
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data_Contrato { get; set; }
        public int Quantidade_Parcelas { get; set; }
        public int Valor_Financiado { get; set; }
        public int Prestacoes { get; set; }
    }
}
