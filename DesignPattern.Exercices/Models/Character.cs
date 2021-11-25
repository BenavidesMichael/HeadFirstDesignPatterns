namespace DesignPattern.Exercices.Models
{
    internal abstract class Character
    {
        protected IWeapon _weapon;
        public void SetWeapon(IWeapon pWeapon) => _weapon = pWeapon;
        public abstract string Fight();
    }
}
