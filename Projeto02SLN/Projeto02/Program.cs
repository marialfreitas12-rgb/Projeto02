using System.Data;
using Projeto02;

static void Main(string[] args)
{
    Banco meuBanco= new Banco();
    meuBanco.Nome = "Banco do Brasil";
    meuBanco.CodigoBACEN = "001";

    Transacao minhaTransacao=new Transacao();
    minhaTransacao.Valor = 250.00m;
    minhaTransacao.Data = DateTime.Now;

    Console.WriteLine("---REGISTRO BACEN---");
    Console.WriteLine("Banco:"+meuBanco.Nome);
    Console.WriteLine("Codigo:" + meuBanco.CodigoBACEN);
    Console.WriteLine("-----------------");
    Console.WriteLine("Valor:R$"+minhaTransacao.Valor);
    Console.WriteLine("Data:"+minhaTransacao.Data);
    TransacaoPix meuPix = new TransacaoPix();
    meuPix.Valor = 1500;
    meuPix.ChavePix = "contato@dgemini.com";

    TransacaoTed meuTed = new TransacaoTed();
    meuTed.Valor = 6000;

    Console.WriteLine($"PIX de R$ {meuPix.Valor} é válido? {meuPix.Validar()}");
    Console.WriteLine($"TED de R$ {meuTed.Valor} é válido? {meuTed.Validar()}");


}