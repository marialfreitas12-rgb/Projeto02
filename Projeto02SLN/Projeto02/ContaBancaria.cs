using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
    public abstract class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public Cliente Titular { get; set; } // A conta RECEBE o cliente
        public decimal Saldo { get; protected set; }

        public abstract void CalcularTarifa();
    }

    public class ContaCorrente : ContaBancaria
    {
        public override void CalcularTarifa() => Saldo -= 15.00m;
    }
}
