var King = new King();

Console.WriteLine(King.Fight());
Console.WriteLine("Change Weapon");
King.SetWeapon(new BowAndArrow());
Console.WriteLine(King.Fight());
Console.ReadLine();