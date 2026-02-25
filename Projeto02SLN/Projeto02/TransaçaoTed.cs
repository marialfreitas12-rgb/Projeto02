using Projeto02;

public class TransacaoTed : Transacao
{
    public override bool Validar()
    {
        return base.Validar() && _valor > 5000;
    }
}