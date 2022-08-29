namespace DesignPattern.Models;

internal class Colvert : Canard
{
    public Colvert()
    {
        // Quand j’hérite d’un comportement, Il est défini statiquement au moment de la compilation
        // Si je peux étendre le comportement d’un objet par la composition,
        // je peux le faire dynamiquement lors de l’exécution.
        _cancanComportement = new Cancan();
        _volComportement = new VolerAvecDesAiles();
    }

    public override string Afficher() => "Je suis un vrai colvert";
}
