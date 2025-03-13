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

		public void GetBookByTitle(Book[] books, string title)
		{
			foreach (Book item in books) 
			{
				string bookTitle = book.Title.ToLower();
				string searchTitle = title.ToLower();

				if (bookTitle == searchTitle) 
				{
					return item;	
				}
			}
			return null;
		}


		public override string ToString()
		{
			return $"Title: {title}, Author: {author}, Release Year: {releaseYear}, Page Count: {pageCount}";
		}
	}
}
