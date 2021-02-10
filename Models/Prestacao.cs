﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IBM.Models
{
    [Keyless]
    public class Prestacao
    {
        public Contrato Contrato { get; set; }
        public  DateTime Data_Vencimento { get; set; }
        public DateTime Data_Pagamento { get; set; }
        public int Valor { get; set; }
        public string Status { get; set; }
    }
}
