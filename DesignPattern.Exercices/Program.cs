
// var King = new King();

// Console.WriteLine(King.Fight());
// Console.WriteLine("Change Weapon");
// King.SetWeapon(new BowAndArrow());
// Console.WriteLine(King.Fight());
// Console.ReadLine();



// Create book
using DesignPattern.Exercices.Decorator;
using DesignPattern.Exercices.Decorator.Models;

BookConcreteComponent book = new BookConcreteComponent("Worley", "Inside ASP.NET", 10);
book.Display();

// Create video
VideoConcreteComponent video = new VideoConcreteComponent("Spielberg", "Jaws", 23, 92);
video.Display();

// Make video borrowable, then borrow and display
Console.WriteLine("\nMaking video borrowable:");
BorrowableDecorator borrowvideo = new BorrowableDecorator(video);
BorrowableDecorator borrowBook = new BorrowableDecorator(book);
borrowvideo.BorrowItem("Customer #1");
borrowvideo.BorrowItem("Customer #2");
borrowvideo.BorrowItem("Customer #3");
borrowvideo.Display();

borrowBook.BorrowItem("Customer #1");
borrowBook.BorrowItem("Customer #2");
borrowBook.Display();
// Wait for user
Console.ReadKey();