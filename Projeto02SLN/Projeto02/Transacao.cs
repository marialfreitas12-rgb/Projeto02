using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
public class Transacao
{
    private decimal _valor;

    public decimal Valor
    {
        get { return _valor; }
        set
        {
            if (value > 0)
            {
                _valor = value;
            }
            else
            {
                Console.WriteLine("Erro: O valor da transação deve ser maior que zero!");

            }
        }
    }

    public DateTime Data { get; set; }
    public string Tipo { get; set; }
}
}
