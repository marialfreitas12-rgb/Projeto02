using System;

namespace Projeto02
{
    public abstract class Transacao
    {
        protected decimal _valor;

        public decimal Valor
        {
            get { return _valor; }
            set { if (value > 0) _valor = value; }
        }

        public DateTime Data { get; set; } = DateTime.Now;
        public ContaBancaria Origem { get; set; }
        public ContaBancaria Destino { get; set; }

        public virtual bool Validar()
        {
            return _valor > 0 && Origem != null && Destino != null;
        }
    }
 }