namespace DesignPattern.Exercices.Models
{
    internal class Knight : Character
    {
        public Knight()
        {
            _weapon = new Knife();
        }

        public override string Fight() => $"Knight Fight with {_weapon.UseWeapon()}";
    }
}
