namespace DesignPattern.Exercices.Models
{
    internal class King : Character
    {
        public King()
        {
            _weapon = new Sword();
        }

        public override string Fight() => $"King Fight with {_weapon.UseWeapon()}";
    }
}
