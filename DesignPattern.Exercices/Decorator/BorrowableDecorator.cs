using DesignPattern.Exercices.Decorator.Models;

namespace DesignPattern.Exercices.Decorator {
    public class BorrowableDecorator : Decorator
    {
        protected readonly List<string> borrowers = new List<string>();

        // Constructor
        public BorrowableDecorator(LibraryItemComponent libraryItem)
            : base(libraryItem)
        { }
        
        
        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }
        
        
        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }
        
        
        public override void Display()
        {
            base.Display();
            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}