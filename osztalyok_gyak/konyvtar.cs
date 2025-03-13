using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyok_gyak
{
	internal class Book
	{
		string title;
		string author;
		int pageCount;
		int releaseYear;

		public Book(string title, string author, int pageCount, int releaseYear)
		{
			this.title = title;
			this.author = author;
			this.pageCount = pageCount;
			this.releaseYear = releaseYear;
		}

		public string Title { get => title; }
		public string Author { get => author; }
		public int PageCount { get => pageCount; }
		public int ReleaseYear { get => releaseYear; }

		public static Book GetBookByTitle(Book[] books, string title)
		{
			foreach (Book item in books) 
			{
				string bookTitle = item.Title.ToLower();
				string searchTitle = title.ToLower();

				if (bookTitle == searchTitle) 
				{
					return item;	
				}
			}
			return null;
		}

		public void EditBookData(string newTitle, string newAuthor, int newPageCount, int newReleaseYear) 
		{
			this.title = newTitle;
			this.author = newAuthor;
			this.pageCount = newPageCount;
			this.releaseYear = newReleaseYear;
		}

		public override string ToString()
		{
			return $"Title: {title}, Author: {author}, Release Year: {releaseYear}, Page Count: {pageCount}";
		}
	}
}
