using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Core
{
    interface ICompraCartao
    {
        ResultadoDaCompra Comprar(Cartao cartao, DadosDaCompra dados);
    }
}
