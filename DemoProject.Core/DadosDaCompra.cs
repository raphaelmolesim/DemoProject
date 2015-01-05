using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoProject.Core
{
    public class DadosDaCompra
    {
        public int parcelas { get; set; }
        public decimal ValorTotal { get; set; }
        public Tuple<int, int> Vencimento { get; set; }
    }
}
