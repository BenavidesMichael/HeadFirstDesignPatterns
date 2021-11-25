namespace DesignPattern.Exercices.Models
{
    internal class Queen : Character
    {
        public Queen()
        {
            _weapon = new BowAndArrow();
        }

        public override string Fight() => $"Queen Fight with {_weapon.UseWeapon()}";
    }
}
