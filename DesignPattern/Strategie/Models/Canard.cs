namespace DesignPattern.Models;

internal abstract class Canard
{
    // Permet d’ajouter plusieurs nouvelles responsabilités aux objets,
    // des responsabilités auxquelles le concepteur de la superclasse n’avait même pas pensé.
    // Et je n’ai pas besoin de toucher à son code !
    protected ICancanComportement _cancanComportement;
    protected IVolComportement _volComportement;


    public string EffectuerCancan() => _cancanComportement.cancaner();
    public string EffectuerVol() => _volComportement.voler();


    public string Nager() => "Tous les canards flottent, même les leurres!";
    public abstract string Afficher();
}

