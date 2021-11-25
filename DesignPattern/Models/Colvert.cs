namespace DesignPattern.Models;

internal class Colvert : Canard
{
    public Colvert()
    {
        _cancanComportement = new Cancan();
        _volComportement = new VolerAvecDesAiles();
    }

    public override string Afficher() => "Je suis un vrai colvert";
}
