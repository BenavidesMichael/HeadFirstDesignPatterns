namespace DesignPattern.Models;

internal abstract class Canard
{
    protected ICancanComportement _cancanComportement;
    protected IVolComportement _volComportement;


    public string EffectuerCancan() => _cancanComportement.cancaner();
    public string EffectuerVol() => _volComportement.voler();


    public string Nager() => "Tous les canards flottent, même les leurres!";
    public abstract string Afficher();
}

