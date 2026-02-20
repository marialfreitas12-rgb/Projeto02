using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
    public class Banco
    {
        private string _codigoBACEN;
        private string _nome;

        public string Nome
        {
            get { return _nome?.ToUpper(); }
            set { _nome = value; }
        }

        public string CodigoBACEN
        {
            get { return _codigoBACEN; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Erro: Código BACEN não pode ser vazio!");
                }
                else
                {
                    _codigoBACEN = value;
                }
            }
        }
    }
}
