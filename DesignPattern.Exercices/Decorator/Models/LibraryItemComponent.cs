namespace DesignPattern.Exercices.Decorator.Models {
    public abstract class LibraryItemComponent
    {
        public int NumCopies { get; set; }
        public abstract void Display();
    }
}