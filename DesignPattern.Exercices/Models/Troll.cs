namespace DesignPattern.Exercices.Models
{
    internal class Troll : Character
    {
        public Troll()
        {
            _weapon = new Axe();
        }

        public override string Fight() => $"Troll Fight with {_weapon.UseWeapon()}";
    }
}
