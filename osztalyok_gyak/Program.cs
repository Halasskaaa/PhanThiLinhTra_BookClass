namespace osztalyok_gyak
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Book book1 = new Book("Harbinger of Chaos: Ruination", "Amy Stake", 911, 2001);
			Book book2 = new Book("Lucy was in Fact a Lucifer", "Paige Turner", 666, 1313);
			Book book3 = new Book("Shack Pallett at 5", "Jenny Rator", 614, 2016);
			Book book4 = new Book("How Backflips are Relevant during Fight Scenes", "Leon S. Kennedy", 322, 1996);
			Book book5 = new Book("My Dog will Deplete my Rocket Launcher Stash", "Ada Wong", 322, 2002);

			Book[] books = new Book[] { book1, book2, book3, book4, book5 };

			// GetBookByTitle(Book[] books, string title) metódus tesztelése

			Book foundBook = Book.GetBookByTitle(books, "Shack Pallett at 5");
			if (foundBook != null)
			{
				Console.WriteLine( "Book found: " + foundBook );
			}
			else
			{
				Console.WriteLine( "Book not found." );	
			}

			// EditBookData method testing

			Console.WriteLine("\nBefore editing: ");
			Console.WriteLine(book1);

			book1.EditBookData("Hex: Nothing but Misery", "Kaneki Ken", 780, 1120);

			Console.WriteLine("\nAfter editing: ");
			Console.WriteLine(book1);

		}
	}
}
