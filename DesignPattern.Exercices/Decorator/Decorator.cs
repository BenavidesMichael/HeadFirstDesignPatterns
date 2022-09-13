using DesignPattern.Exercices.Decorator.Models;

namespace DesignPattern.Exercices.Decorator {
    public abstract class Decorator : LibraryItemComponent
    {
        protected LibraryItemComponent libraryItem;
        // Constructor
        public Decorator(LibraryItemComponent libraryItem)
        {
            this.libraryItem = libraryItem;
        }
        public override void Display()
        {
            libraryItem.Display();
        }
    }
}