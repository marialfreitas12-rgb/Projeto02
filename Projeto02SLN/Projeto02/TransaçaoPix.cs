using Projeto02;

public class TransacaoPix : Transacao
{
    public string ChavePix { get; set; }

    public override bool Validar()
    {
        return base.Validar() && _valor <= 10000;
    }
}
